using Core.Entities.AuthEntities;
using Core.Interfaces.IServices;
using Core.Services;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configuracion de servicios y configuracion de la aplicacion
var _configuration = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", false, true)
                .AddJsonFile(@"appsettings.Development.json", false, true)
                .Build();

// Configuracion de AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Configuracion de Logs 
Log.Logger = new LoggerConfiguration()
            .Enrich.WithProperty("Application", $"{_configuration["GeneralData:AppName"]}")
            .Enrich.WithProperty("Ambiente", $"{_configuration["Serilog:WriteTo:0:Args:ambiente"]}")
            .WriteTo.Console()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.File($"{_configuration["Serilog:WriteTo:1:Args:path"]}", rollingInterval: RollingInterval.Day)
            .CreateLogger();

// Configuracion de DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

//Añadiendo Identity y configurando el uso del usuario AppUser y habilitando los roles, además se configuran requisitos para la contraseña
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 12;

}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication(options => {
    options.DefaultAuthenticateScheme =
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;


}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = _configuration["Jwt:SigninKey"],
        ValidateAudience = true,
        ValidAudience = _configuration["Jwt:Audience"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(_configuration["Jwt:SigninKey"]))
    };
});


// Dependency Inyection
builder.Services.AddScoped<ITokenService, TokenService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
