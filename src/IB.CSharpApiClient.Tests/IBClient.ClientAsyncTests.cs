using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IB.CSharpApiClient.Messages;
using IBApi;
using NSubstitute;
using NUnit.Framework;

namespace IB.CSharpApiClient.Tests
{
    public class IBClientClientAsyncTests
    {
        private EReaderSignal _readerSignal;
        private IEClientSocket _clientSocket;
        private IClientMessageHandler _clientMessageHandler;

        private IBClient _client;

        [SetUp]
        public void SetUp()
        {
            _readerSignal = Substitute.For<EReaderSignal>();
            _clientSocket = Substitute.For<IEClientSocket>();
            _clientMessageHandler = Substitute.For<IClientMessageHandler>();
            _client = new IBClient(_readerSignal, _clientSocket, _clientMessageHandler, new ManualResetEventSlim(), TimeSpan.FromMilliseconds(250));
        }

        [Test]
        public void Should_GetScannerDataAsyncString_Throw_Exception_When_Timeout()
        {
            Assert.ThrowsAsync<TaskCanceledException>(async () =>
                await _client.GetScannerDataAsync(new ScannerSubscription(), "", ""));
        }

        [Test]
        public void Should_GetScannerDataAsyncList_Throw_Exception_When_Timeout()
        {
            Assert.ThrowsAsync<TaskCanceledException>(async () =>
                await _client.GetScannerDataAsync(new ScannerSubscription(), new List<TagValue>(),
                    new List<TagValue>()));
        }

        [Test]
        public async Task Should_GetScannerDataAsync_Return_Data_When_Match_ReqId()
        {
            // Arrange
            _clientSocket.When(x => x.reqScannerSubscription(Arg.Any<int>(), Arg.Any<ScannerSubscription>(),
                    Arg.Any<string>(), Arg.Any<string>()))
                .Do(x =>
                {
                    var requestId = x.ArgAt<int>(0);
                    _clientMessageHandler.ScannerData +=
                        Raise.Event<Action<ScannerDataMessage>>(new ScannerDataMessage(requestId, 0,
                            new ContractDetails(), "", "", "", ""));
                    _clientMessageHandler.ScannerDataEnd +=
                        Raise.Event<Action<ScannerDataEndMessage>>(new ScannerDataEndMessage(requestId));
                });
            // Act
            var scanners = await _client.GetScannerDataAsync(new ScannerSubscription(), "", "");
            // Assert
            Assert.That(scanners.Count(), Is.Positive);
        }


        [Test]
        public void Should_GetScannerDataAsync_Throw_Exception_When_Error()
        {
            // Arrange
            var requestId = 0;
            var errorCode = int.MaxValue;
            var errorMsg = "Invalid arguments.";
            var json = "{}";

            _clientSocket.When(x => x.reqScannerSubscription(Arg.Any<int>(), Arg.Any<ScannerSubscription>(),
                    Arg.Any<string>(), Arg.Any<string>()))
                .Do(x =>
                {
                    requestId = x.ArgAt<int>(0);
                    _clientMessageHandler.Error +=
                        Raise.Event<Action<ErrorMessage>>(new ErrorMessage(requestId, errorCode, errorMsg, json));
                });
            // Act
            var exception = Assert.ThrowsAsync<IBClientException>(async () => await _client.GetScannerDataAsync(new ScannerSubscription(), "", ""));
            Assert.That(exception.RequestId, Is.EqualTo(requestId));
            Assert.That(exception.ErrorCode, Is.EqualTo(errorCode));
            Assert.That(exception.Message, Is.EqualTo(errorMsg));
            Assert.That(exception.AdvancedOrderRejectJson, Is.EqualTo(json));
        }
    }
}