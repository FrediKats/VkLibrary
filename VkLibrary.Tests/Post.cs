using System;
using System.Collections.Generic;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests
{
    public class Post : ClassFixtureBase
    {
        public Post(ITestOutputHelper testOutputHelper) : base(Constants.OfficialApplicationId,
            Constants.OfficialApplicationSecret, string.Empty, testOutputHelper) { }
        
        [Fact]
        public async void PostSingle()
        {
            const string playground = "http://httpbin.org/post";
            var urlToUpload = new Uri(playground);
            var response = await Api.UploadHelper.PostAsync<JToken>(
                urlToUpload, new byte[] {1}, "doc", "doc");
            var content = response["files"]["doc"].ToString();
            content.Should().Be(@"");
        }

        [Fact]
        public async void PostMultiple()
        {
            const string playground = "http://httpbin.org/post";
            var urlToUpload = new Uri(playground);
            var response = await Api.UploadHelper.PostMultipleAsync<JToken>(
                urlToUpload, new Dictionary<string, byte[]>()
                {
                    {"one", new byte[] {1}},
                    {"two", new byte[] {1}}
                });
            Log(response.ToString());
            response.Should().NotBeNull();
        }
    }
}