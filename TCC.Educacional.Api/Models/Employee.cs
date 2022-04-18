namespace TCC.Educacional.Api.Models
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Position { get; set;}
        public string Department { get; set;}
        public int CompanyId { get; set;}
        public virtual Company Company { get; set;}

    }
}
