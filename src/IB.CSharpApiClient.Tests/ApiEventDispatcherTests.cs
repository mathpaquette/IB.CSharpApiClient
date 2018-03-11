using System;
using IB.CSharpApiClient.Events;
using NUnit.Framework;

namespace IB.CSharpApiClient.Tests
{
    public class ApiEventDispatcherTests
    {
        private ApiEventDispatcher _apiEventDispatcher;

        [SetUp]
        public void Init()
        {
            _apiEventDispatcher = new ApiEventDispatcher();
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_Exception_When_Calling_Error()
        {
            // Arrange
            ErrorEventArgs errorEventArgs = null;
            _apiEventDispatcher.Error += (sender, args) => { errorEventArgs = args; };

            // Act
            _apiEventDispatcher.error(new Exception());

            // Assert
            Assert.IsNotNull(errorEventArgs.Exception);
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_ErrorMsg_When_Calling_Error()
        {
            // Arrange
            var errorMsg = "ErrorMsg";
            ErrorEventArgs errorEventArgs = null;
            _apiEventDispatcher.Error += (sender, args) => { errorEventArgs = args; };

            // Act
            _apiEventDispatcher.error(errorMsg);

            // Assert
            Assert.AreEqual(errorEventArgs.Message, errorMsg);
        }

        [Test]
        public void Should_Get_ErrorEventArgs_With_Values_When_Calling_Error()
        {
            // Arrange
            var requestId = int.MinValue;
            var errorCode = int.MaxValue;
            var errorMsg = "ErrorMsg";
            ErrorEventArgs errorEventArgs = null;
            _apiEventDispatcher.Error += (sender, args) => { errorEventArgs = args; };

            // Act
            _apiEventDispatcher.error(requestId, errorCode, errorMsg);

            // Assert
            Assert.AreEqual(errorEventArgs.RequestId, requestId);
            Assert.AreEqual(errorEventArgs.ErrorCode, errorCode);
            Assert.AreEqual(errorEventArgs.Message, errorMsg);
        }

        [Test]
        public void Should_Get_CurrentTimeEventArgs_When_Calling_CurrentTime()
        {
            // Arrange
            var time = DateTime.Now.Ticks;
            TimeEventArgs timeEventArgs = null;
            _apiEventDispatcher.Time += (sender, args) => { timeEventArgs = args; };

            // Act
            _apiEventDispatcher.currentTime(time);

            // Assert
            Assert.AreEqual(timeEventArgs.CurrentTime, time);
        }
    }
}