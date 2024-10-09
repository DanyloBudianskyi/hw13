namespace collection_practice.HR
{
    public class Region
    {
        public int RegionId { get; set; }     // Идентификатор региона
        public string? RegionName { get; set; } // Название региона
        public override string ToString()
        {
            return $"Region id: {RegionId}, Region name: {RegionName}";
        }
    }
}
