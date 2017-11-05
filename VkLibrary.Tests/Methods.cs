using FluentAssertions;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests
{
    public class Methods : ClassFixtureBase
    {
        public Methods(ITestOutputHelper testOutputHelper) : base(Constants.ApplicationId, 
            string.Empty, Constants.AccessToken, testOutputHelper) { }

        [Fact]
        public void PhotosGetAlbums() => Api.Photos
            .GetAlbums(-44695971).Result.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void WallGet() => Api.Wall
            .Get(1).Result.Items.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void Execute() => Api
            .Execute<int>("return 40 + 2;").Result
            .Should().Be(42);

        [Fact]
        public void StatusGet() => Api.Status
            .Get().Result.Text
            .Should().Be("coldest summer");

        [Fact]
        public void StatusSet() => Api.Status
            .Set("coldest summer").Result
            .Should().Be(1);

        [Fact]
        public void NewsFeedGet() => Api.Newsfeed
            .Get(new[] {"post"}, count: 1).Result.NextFrom
            .Should().NotBeNull();

        [Fact]
        public void WallGetComments() => Api.Wall
            .GetComments(postId: 1571).Result.Count
            .Should().Be(0);

        [Fact]
        public void UtilsGetLastShortenedLinks() => Api.Utils
            .GetLastShortenedLinks(10, 0).Result.Items.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void GroupsSearch() => Api.Groups
            .Search("Live").Result.Items.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void NotesGet() => Api.Notes
            .Get().Result.Items
            .Should().NotBeNull();
    }
}