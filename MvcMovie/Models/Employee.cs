using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Employee : Person
    {
        [Required]
        public string EmployeeID { get; set; }
    }
}