using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

    }
}
