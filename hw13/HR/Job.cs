namespace collection_practice.HR
{
    public class Job
    {
        public string? JobId { get; set; }     // Идентификатор должности
        public string? JobTitle { get; set; } // Название должности
        public decimal MinSalary { get; set; } // Минимальная зарплата
        public decimal MaxSalary { get; set; } // Максимальная зарплата
        public override string ToString()
        {
            return $"Job id: {JobId}," +
                $" Job title: {JobTitle}," +
                $" Min salary: {MinSalary}," +
                $" Max salary: {MaxSalary}";
        }
    }
}
