namespace WebAppInClass.Models
{
    public class Job
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }



    }
}
