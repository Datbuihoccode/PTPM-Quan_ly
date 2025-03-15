using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
   public class Person 
    {
        [Key]
        public int Id { get; set; }
        public required string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}