using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppInClass.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Uuid { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        public string Name { get; set; }
        [DisplayName("Position Title")]
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
        [DisplayName("Salary Amount")]
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; } = 0;

        //[ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        //public ICollection<Job>? Jobs { get; set; }

        //public int JobId { get; set; }
        //public Job? Job { get; set; }
    }
}
