namespace collection_practice.HR
{
    public class JobHistory
    {
        public int EmployeeId { get; set; } // Идентификатор сотрудника
        public DateTime StartDate { get; set; } // Дата начала работы на должности
        public DateTime EndDate { get; set; } // Дата окончания работы на должности
        public string? JobId { get; set; } // Идентификатор должности
        public int DepartmentId { get; set; } // Идентификатор отдела
        public override string ToString()
        {
            return $"Employee id: {EmployeeId}\n" +
                $"Start date: {StartDate.Day}.{StartDate.Month}.{StartDate.Year}\n" +
                $"End date: {EndDate.Day}.{EndDate.Month}.{EndDate.Year}\n" +
                $"Job id: {JobId}" +
                $"Department id: {DepartmentId}";
        }
    }
}
