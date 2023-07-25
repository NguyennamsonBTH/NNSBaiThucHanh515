using System. ComponentModel.DataAnnotations;
namespace DemoNNS.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set;}
        public string StudentName { get; set;}
    }
}