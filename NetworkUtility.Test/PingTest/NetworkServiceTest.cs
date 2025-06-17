using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Test.PingTest
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.SendPing();

            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());
        }
    }
}
