
namespace TCC.Educacional.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int RoleId { get; set;}
        public virtual Role Role { get; set;}

    }
}
