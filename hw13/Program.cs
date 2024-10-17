using collection_practice.HR;
using hw13.Services;

namespace hw13
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHR serviceHR = new ServiceHR();

            //Найдите локацию в коллекции locations, и обновите информацию о стране, в которой она находится.


            //serviceHR.printLocation();
            //Console.WriteLine("-------------------------------------");
            //serviceHR.updateLocationCountry(2, serviceHR.ReadCountries()[5]);
            //serviceHR.updateLocationCountry(3, serviceHR.ReadCountries()[6]);
            //serviceHR.updateLocationCountry(4, serviceHR.ReadCountries()[7]);
            //serviceHR.printLocation();

            //Создание новой коллекции локаций с указанными городами:
            //Создайте новую коллекцию локаций, которые находятся в указанных городах.

            //List<string> specifiedCities = new List<string> { "City 1", "City 3" };
            //var newLocations = serviceHR.CreateLocationsForCities(serviceHR.ReadLocations(), specifiedCities);

            //Console.WriteLine("\nNew collection:");
            //foreach (var location in newLocations)
            //{
            //    Console.WriteLine($"ID: {location.LocationId}, City: {location.City}, Country: {location.Country.CountryName}");
            //}


            //Обновление информации о стране в отделе:
            //Найдите отдел в коллекции departments, и обновите информацию о стране, в которой он находится.


            //serviceHR.printDepartments();
            //Console.WriteLine("-----------------------------------------");
            //serviceHR.updateDepartmentCountry(2, serviceHR.ReadCountries()[5]);
            //serviceHR.updateDepartmentCountry(3, serviceHR.ReadCountries()[6]);
            //serviceHR.updateDepartmentCountry(4, serviceHR.ReadCountries()[7]);
            //serviceHR.printDepartments();

            //Создание новой коллекции локаций с определенными почтовыми кодами:
            //Создайте новую коллекцию локаций, у которых почтовый код соответствует указанным значениям.
            List<string> specifiedPostalCodes = new List<string> { "12345", "54321" };
            var newLocations = serviceHR.CreateLocationsForPostalCode(serviceHR.ReadLocations(), specifiedPostalCodes);

            Console.WriteLine("New collection:");
            foreach (var location in newLocations)
            {
                Console.WriteLine($"ID: {location.LocationId}, City: {location.City}, Postal Code: {location.PostalCode}, Country: {location.Country.CountryName}");
            }
        }
    }
}
