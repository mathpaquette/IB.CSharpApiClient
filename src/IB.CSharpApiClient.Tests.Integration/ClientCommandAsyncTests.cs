using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IBApi;
using NUnit.Framework;

namespace IB.CSharpApiClient.Tests.Integration
{
    public class ClientCommandAsyncTests
    {
        private IBClient _client;

        [SetUp]
        public void SetUp()
        {
            _client = IBClientFactory.CreateNew();
            _client.Connect("127.0.0.1", 4002, 2);
        }

        [Test]
        public async Task Should_GetScannerDataAsync_String()
        {
            // Arrange
            var subscription = new ScannerSubscription()
            {
                ScanCode = "MOST_ACTIVE",
                Instrument = "STK",
                LocationCode = "STK.US"
            };

            // Act
            var scanners = await _client.GetScannerDataAsync(subscription, "", "");

            // Assert
            var symbols = scanners.Select(x => x.ContractDetails.Contract.Symbol);
            Assert.Positive(symbols.Count());
        }


        [Test]
        public async Task Should_GetScannerDataAsync_Tags()
        {
            // Arrange
            var subscription = new ScannerSubscription()
            {
                ScanCode = "MOST_ACTIVE",
                Instrument = "STK",
                LocationCode = "STK.US"
            };

            // Act
            var scanners = await _client.GetScannerDataAsync(subscription, new List<TagValue>(), new List<TagValue>());

            // Assert
            var symbols = scanners.Select(x => x.ContractDetails.Contract.Symbol);
            Assert.Positive(symbols.Count());
        }
    }
}