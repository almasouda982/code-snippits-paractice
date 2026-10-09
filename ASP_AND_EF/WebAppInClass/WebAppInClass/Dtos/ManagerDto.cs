namespace WebAppInClass.Dtos
{
    public class ManagerDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public string DepartmentName { get; set; } = string.Empty;
    }




    public class ManagerCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int? DepartmentId { get; set; }
    }


    public class ManagerUpdateDto : ManagerCreateDto
    {
        public int Id { get; set; }

    }
}
