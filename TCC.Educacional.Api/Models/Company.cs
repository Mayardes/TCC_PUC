using System.Collections.Generic;

namespace TCC.Educacional.Api.Models
{
    public class Company
    {
        public int Id { get; set;}
        public string CompanyName { get; set; }
        public string TradingName { get; set;}
        public string RegisteredNumber { get; set;}
        public string Address { get; set;}
        public string MunicipalRegistration { get; set;}
        public string StateRegistration { get; set;}
        public virtual ICollection<Employee> Employees { get; set;}
    }
}
