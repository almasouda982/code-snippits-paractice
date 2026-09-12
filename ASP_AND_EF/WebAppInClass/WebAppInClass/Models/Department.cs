using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppInClass.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is required")]
        public string Name { get; set; }
    }
}
