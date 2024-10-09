namespace collection_practice.HR
{
    public class Employee
    {
        public int EmployeeId { get; set; }     // Идентификатор сотрудника
        public string? FirstName { get; set; }   // Имя сотрудника
        public string? LastName { get; set; }    // Фамилия сотрудника
        public string? Email { get; set; }       // Адрес электронной почты сотрудника
        public string? PhoneNumber { get; set; } // Номер телефона сотрудника
        public DateTime HireDate { get; set; }  // Дата найма сотрудника
        public string? JobId { get; set; }       // Идентификатор должности, на которую нанят сотрудник
        public decimal Salary { get; set; }     // Зарплата сотрудника
        public decimal CommissionPct { get; set; } // Процент комиссии сотрудника (если применимо)
        public int ManagerId { get; set; }      // Идентификатор руководителя сотрудника
        public int DepartmentId { get; set; }   // Идентификатор отдела, к которому принадлежит сотрудник
        public override string ToString()
        {
            return $"Id: {EmployeeId} Name: {FirstName} {LastName}\n" +
                $"Email: {Email}, Phone number: {PhoneNumber}\n" +
                $"Hire date: {HireDate.Day}.{HireDate.Month}.{HireDate.Year}\n" +
                $"Job id: {JobId}, Salary: {Salary}, Commission Pct:{CommissionPct}\n" +
                $"Manager id: {ManagerId}, Department id: {DepartmentId}\n";
        }
    }
}
