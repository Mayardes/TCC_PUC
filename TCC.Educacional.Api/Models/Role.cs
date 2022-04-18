using System.Collections.Generic;

namespace TCC.Educacional.Api.Models
{
    public class Role
    {
        public int Id { get; set;}
        public string Description { get; set;} = string.Empty;
        public virtual ICollection<User> Users { get; set;}
    }
}
