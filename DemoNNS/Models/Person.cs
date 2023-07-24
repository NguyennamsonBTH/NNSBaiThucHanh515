using System. ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoNNS.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public int ID{ get; set; }
        public string FullName{ get; set; }
        public string Address{ get; set;}
        public DateTime BirthDay{ get; set; }

    }
}