using System.Threading.Tasks;
using FluentAssertions;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests
{
    public class LongPoll : ClassFixtureBase
    {
        public LongPoll(ITestOutputHelper testOutputHelper) : base(Constants.ApplicationId, 
            string.Empty, Constants.AccessToken, testOutputHelper) { }

        [Fact]
        public async void GetLongPollServer()
        {
            var response = await Api.Messages.GetLongPollServer();
            response.Should().NotBeNull();
            
            response.Key.Should().NotBeNullOrEmpty();
            response.Server.Should().NotBeNullOrEmpty();
            response.Ts.Should().NotBe("0");
        }

        [Fact]
        public async void StartLongPollSever()
        {
            var response = await Api.Messages.GetLongPollServer();
            var client = await Api.StartLongPollClient(
                response.Server, response.Key, int.Parse(response.Ts));
            
            var success = false;
            client.ResponseReceived += (sender, args) => success = true;
            await Task.Delay(30000);
            client.Stop();
            success.Should().BeTrue();
        }
    }
}