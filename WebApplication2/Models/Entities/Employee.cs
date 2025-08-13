namespace WebApplication2.Models.Entities
{
    public class Employee
    {
        public Guid id { get; set; }

        public required string name { get; set; }

        public required int phone { get; set; }

        public string? email { get; set; }
        
        public required string role { get; set; }

        public required double salary { get; set; }





    }
}
