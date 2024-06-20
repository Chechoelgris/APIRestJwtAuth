namespace Core.DTOs.Carreras
{
    public class CarreraDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class CreateCarreraDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

    public class UpdateCarreraDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
