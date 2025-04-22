using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Employee : Person
    {
        [Required]
        public string EmployeeID { get; set; }
        public int Age { get; set; }
        public string? Factory { get; set; }
        public string? Department { get; set; }
        public string? PhonNumber { get; set; }
    }
}