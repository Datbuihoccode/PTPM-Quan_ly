using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    
    public class Student : Person
    {
        public required string Studentcode { get; set; }
        public string NameClass { get; set;}
    }
}