using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}