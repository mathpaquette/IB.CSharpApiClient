using IB.CSharpApiClient.Example.Domain;
using IB.CSharpApiClient.Example.Infrastructure;

namespace IB.CSharpApiClient.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("Press enter to continue.");
            System.Console.WriteLine("----------------------------------");

            var host = "127.0.0.1";
            var port = 7497;
            var clientId = 10;

            var example = new DomainClassExample(new RealTimeDataProviderExample());
            example.RequestDataExample(host, port, clientId);

            System.Console.ReadLine();
        }
    }
}
