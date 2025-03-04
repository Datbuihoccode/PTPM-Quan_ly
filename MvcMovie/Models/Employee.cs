using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Employees")]
    public class Employee 
    {
        [Key]
        public required string EmployeeId { get; set; }
        public  required string FullName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}