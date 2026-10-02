using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppInClass.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}