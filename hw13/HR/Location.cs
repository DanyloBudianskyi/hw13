namespace collection_practice.HR
{
    public class Location
    {
        public int LocationId { get; set; }       // Идентификатор локации
        public string? StreetAddress { get; set; } // Улица и номер дома
        public string? PostalCode { get; set; }    // Почтовый индекс
        public string? City { get; set; }          // Город
        public string? StateProvince { get; set; } // Провинция или штат
        public Country? Country { get; set; }      // Объект страны, связывающий локацию с соответствующей страной
        public override string ToString()
        {
            return $"Location id: {LocationId}\n" +
                $"Street address: {StreetAddress}, " +
                $"Postal Code: {PostalCode}\n" +
                $"City: {City}, " +
                $"State: {StateProvince}, " +
                $"Country: {Country}\n";
        }
    }
}
