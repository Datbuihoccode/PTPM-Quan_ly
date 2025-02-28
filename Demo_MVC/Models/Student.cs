using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_MVC.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public required string Id { get; set; }
        public  required string FullName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}