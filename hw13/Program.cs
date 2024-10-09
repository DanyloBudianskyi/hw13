using hw13.Services;

namespace hw13
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHR serviceHR = new ServiceHR();
            serviceHR.AddLocation(11, "123 Main St", "12345", "New York", "NY", "US");
            serviceHR.AddLocation(12, "456 Elm St", "54321", "Los Angeles", "CA", "US");
            serviceHR.AddLocation(13, "789 Maple St", "67890", "Toronto", "ON", "CA");
            serviceHR.printLocation();
            Console.WriteLine("-----------------------------------------------------");
            serviceHR.UpdateLocation(1, "124 Main St", "12345", "New York", "NY", "US");
            serviceHR.DeleteLocation(5);
            serviceHR.DeleteLocation(6);
            serviceHR.DeleteLocation(7);
            serviceHR.DeleteLocation(8);
            serviceHR.printLocation();
        }
    }
}
