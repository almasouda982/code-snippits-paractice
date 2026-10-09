namespace WebAppInClass.Dtos
{
    public class EmployeeDto
    {
        
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Position { get; set; } = string.Empty;

            public decimal Salary { get; set; }

            public string DepartmentName { get; set; } = string.Empty;
        }




        public class EmployeeCreateDto
        {
            public string Name { get; set; } = string.Empty;
            public string Position { get; set; } = string.Empty;
            public decimal Salary { get; set; }
            public int DepartmentId { get; set; }
        }


        public class EmployeeUpdateDto : EmployeeCreateDto
        {
            public int Id { get; set; }

        }
    }

