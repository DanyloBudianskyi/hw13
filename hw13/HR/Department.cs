namespace collection_practice.HR
{
    public class Department
    {
        public int DepartmentId { get; set; }   // Идентификатор отдела
        public string? DepartmentName { get; set; } // Название отдела
        public int ManagerId { get; set; }        // Идентификатор менеджера отдела
        public int LocationId { get; set; }       // Идентификатор локации, где расположен отдел
        public override string ToString()
        {
            return $"Department id: {DepartmentId}\n" +
                $"Department name: {DepartmentName}\n" +
                $"Manager id: {ManagerId}\n" +
                $"Location id: {LocationId}\n";
        }
    }
}
