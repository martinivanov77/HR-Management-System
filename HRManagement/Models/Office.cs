using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRManagement.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public bool IsHQ { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } 
    }
}
