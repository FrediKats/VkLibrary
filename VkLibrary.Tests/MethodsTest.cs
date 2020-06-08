using System.Linq;
using FluentAssertions;
using VkApi.Wrapper.Objects;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests
{
    public class MethodsTest : ClassFixtureBase
    {
        public MethodsTest(ITestOutputHelper testOutputHelper) : base(Constants.ApplicationId, 
            string.Empty, Constants.AccessToken, testOutputHelper) { }

        [Fact]
        public void PhotosGetAlbums() => Api.Photos
            .GetAlbums(-44695971).Result.Count
            .Should().BeGreaterThan(0);

        [Fact]
        public void WallGet() => Api.Wall
            .Get(1).Result.Items.Length
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
            .Should().Be(BaseOkResponse.Ok);

        //TODO: fix
        //[Fact]
        //public void NewsFeedGet() => Api.Newsfeed
        //    .Get(new[] {"post"}, count: 1).Result.NextFrom
        //    .Should().NotBeNull();

        [Fact]
        public void WallGetComments() => Api.Wall
            .GetComments(ownerId: 372866972, postId: 164).Result.Count
            .Should().Be(0);

        [Fact]
        public void UtilsGetLastShortenedLinks() => Api.Utils
            .GetLastShortenedLinks(10, 0).Result.Items.Length
            .Should().Be(0);

        [Fact]
        public void GroupsSearch() => Api.Groups
            .Search("Live").Result.Items.Length
            .Should().BeGreaterThan(0);

        [Fact]
        public void NotesGet() => Api.Notes
            .Get().Result.Items
            .Should().NotBeNull();

        [Fact]
        public void UsersGet() => Api
            .Users.Get(new[] { "1" }, new[]{ UsersFields.Photo200}).Result
            .First().Photo200.Should().NotBeNull();
    }
}