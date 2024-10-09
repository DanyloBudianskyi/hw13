namespace collection_practice.HR
{
    public class Country : Region
    {
        public string? CountryId { get; set; }   // Идентификатор страны
        public string? CountryName { get; set; } // Название страны
        public object Region { get; internal set; }
        public override string ToString()
        {
            return $"Country id: {CountryId}, Country name: {CountryName}";
        }
    }
}
