using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using VkLibrary.Core.Responses.Newsfeed;
using VkLibrary.Tests.Helpers;
using Xunit.Abstractions;
using Xunit;

namespace VkLibrary.Tests
{
    public class OpenMethods : ClassFixtureBase
    {
        public OpenMethods(ITestOutputHelper testOutputHelper) : base(Constants.ApplicationId, 
            string.Empty, string.Empty, testOutputHelper) { }

        [Fact]
        public void GenericGetAsyncSigned() => Api
            .GetAsync<NewsFeedResponse>("newsfeed.get", new Dictionary<string, string>
            {
                {"filters", "post"},
                {"count", "1"},
                {"access_token", Constants.AccessToken}
            })
            .Result.Items.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void UsersGet() => Api.Users
            .Get(new[] {"1"}).Result.Count()
            .Should().BeGreaterThan(0);

        [Fact]
        public void GroupsGetById() => Api.Groups
            .GetById(new[] {"1"}).Result.Count()
            .Should().BeGreaterThan(0);

        [Fact]
        public void UtilsCheckLink() => Api.Utils
            .CheckLink("https://google.ru").Result.Status
            .Should().Be("not_banned");

        [Fact]
        public void DatabaseGetCities() => Api.Database
            .GetCitiesById(new int?[] {1}).Result
            .First().Title
            .Should().Be("Москва");
    }
}