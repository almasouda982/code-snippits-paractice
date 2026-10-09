namespace WebAppInClass.Dtos
{
    public class JobsDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? EmployeeName { get; set; }
        public string? DepartmentName { get; set; }
    }
    public class JobsCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public int? EmployeeId { get; set; }
    }
    public class JobsUpdateDto : JobsCreateDto
    {
        public int? Id { get; set; }
    }
}
