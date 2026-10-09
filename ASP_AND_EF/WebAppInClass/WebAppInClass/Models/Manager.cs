using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppInClass.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [DisplayName("Employee Name")]
        [Required(ErrorMessage = "Employee Name is required")]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = "";

        [DisplayName("Position Title")]
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; } = string.Empty;
        [DisplayName("Salary Amount")]
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; } = 0;

        //[ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
