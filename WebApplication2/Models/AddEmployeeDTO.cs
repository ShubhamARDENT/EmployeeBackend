namespace WebApplication2.Models
{
    public class AddEmployeeDTO
    {

        public required string name { get; set; }

        public required int phone { get; set; }

        public string? email { get; set; }

        public required string role { get; set; }
    }
}
