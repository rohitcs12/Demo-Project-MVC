using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models

{
    
    public class Employee
    {
        [Key]
        //public int Id { get; set; }
        public int EmpCode { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public string Designation { get; set; }
    }
}
