using FluentAssertions;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests.Methods
{
    public class PhotosTests : ClassFixtureBase
    {
        public PhotosTests(ITestOutputHelper testOutputHelper)
            : base(Constants.OfficialApplicationId, Constants.OfficialApplicationSecret, Constants.AccessToken, testOutputHelper)
        {
        }

        [Fact()]
        public void GetTest() => Api.Photos
            .Get(ownerId: -1, albumId: "wall")
            .Result.Count.Should().Be(42);

        [Fact()]
        public void GetAlbumsTest() => Api.Photos
                .GetAlbums(ownerId: 1, albumIds: new[] { 136592355 })
                .Result.Count.Should().Be(1);

        [Fact()]
        public void GetAlbumsCountTest() => Api.Photos
            .GetAlbumsCount(userId: 185014513)
            .Result.Should().BeGreaterThan(1);

        [Fact()]
        public void GetAllTest() => Api.Photos
            .GetAll(ownerId: 1, extended: true, skipHidden: true)
            .Result.Count.Should().BeGreaterThan(0);

        [Fact()]
        public void GetAllCommentsTest() => Api.Photos
            .GetComments(ownerId: 1, photoId: 263113261)
            .Result.Count.Should().BeGreaterThan(0);

        [Fact()]
        public void GetByIdTest() => Api.Photos
            .GetById(new []{ "1_278184324" })
            .Result.Length.Should().BeGreaterThan(0);

        [Fact(Skip = "This test needs an implementation")]
        public void GetChatUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void GetCommentsTest() => Api.Photos
            .GetComments(ownerId: 1, photoId: 263113261)
            .Result.Count.Should().BeGreaterThan(0);

        [Fact(Skip = "This test needs an implementation")]
        public void GetMarketAlbumUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetMarketUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetMessagesUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetNewTagsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetOwnerCoverPhotoUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetOwnerPhotoUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetTagsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetUserPhotosTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void GetWallUploadServerTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void MakeCoverTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void MoveTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void PutTagTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void RemoveTagTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void ReorderAlbumsTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void ReorderPhotosTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void ReportTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void ReportCommentTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void RestoreTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void RestoreCommentTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveMarketAlbumPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveMarketPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveMessagesPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveOwnerCoverPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveOwnerPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SaveWallPhotoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact(Skip = "This test needs an implementation")]
        public void SearchTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}