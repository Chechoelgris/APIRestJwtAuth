using Core.DTOs;
using Core.DTOs.Account;
using Core.Entities.AuthEntities;
using Core.Interfaces.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace APIRest.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;            
            _tokenService = tokenService;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == loginDto.Email.ToLower());
            if (user == null) return Unauthorized("Invalid Email!");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded) return Unauthorized("Email not found and/or incorrect password");

            return Ok(
                new NewUserDto
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Token = await _tokenService.CreateToken(user)
                }
            );
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if (createUser.Succeeded)
                {
                    var role = !string.IsNullOrEmpty(registerDto.Role) ? registerDto.Role : "Estudiante";

                    if (!await _roleManager.RoleExistsAsync(role))
                    {
                        return BadRequest("Role does not exist");
                    }

                    var roleResult = await _userManager.AddToRoleAsync(appUser, role);
                    if (roleResult.Succeeded)
                    {
                        var token = await _tokenService.CreateToken(appUser);
                        return Ok(new NewUserDto
                        {
                            UserName = appUser.UserName,
                            Email = appUser.Email,
                            Token = token
                        });
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("userinfo")]
        [Authorize]
        public async Task<IActionResult> GetUserInfo()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            if (email == null)
            {
                return Unauthorized("User is not authenticated");
            }

            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return NotFound("User not found");
            }

            var roles = await _userManager.GetRolesAsync(user);

            return Ok(new
            {
                UserName = user.UserName,
                Email = user.Email,
                Roles = roles
            });
        }

    }
}
