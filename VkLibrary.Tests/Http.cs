using System;
using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VkLibrary.Core.Services;
using VkLibrary.Tests.Helpers;
using Xunit.Abstractions;
using Xunit;

namespace VkLibrary.Tests
{
    public class Http : ClassFixtureBase
    {
        public Http(ITestOutputHelper testOutputHelper) : base(
            Constants.OfficialApplicationId,
            Constants.OfficialApplicationSecret,
            string.Empty, testOutputHelper) { }

        [Fact]
        public void QueryBuilder()
        {
            const string baseUrl = "http://a.bcd/ef.gh";
            var parameters = new Dictionary<string, string> {{"foo", "bar"}, {"key", "1234"}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
                defaultHttpService
                    .BuildGetRequestUrl(baseUrl, parameters)
                    .Should().Be("http://a.bcd/ef.gh?foo=bar&key=1234");
        }

        [Fact]
        public async void HttpBinGetForStream()
        {
            var url = new Uri("http://httpbin.org/get");
            var parameters = new Dictionary<string, string> {{"foo", "bar"}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.GetForStreamAsync(url, parameters))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                response["args"]["foo"].ToString().Should().Be("bar");
                response["url"].ToString().Should().Contain(url.AbsoluteUri);
            }
        }

        [Fact]
        public async void HttpBinPostForStream()
        {
            var url = new Uri("http://httpbin.org/post");
            var parameters = new Dictionary<string, string> {{"foo", "bar"}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.PostForStreamAsync(url, parameters))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                Logger.Log(response.ToString(Formatting.Indented));
                response["form"]["foo"].ToString().Should().Be("bar");
                response["url"].ToString().Should().Contain(url.AbsoluteUri);
            }
        }
        
        [Fact]
        public async void HttpBinPostSingle()
        {
            var url = new Uri("http://httpbin.org/post");
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.PostSingleFileAsync(url, new byte[] {1}, "doc", "doc"))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                var content = response["files"]["doc"].ToString();
                content.Should().Be(@"");
            }
        }

        [Fact]
        public async void HttpBinPostMultiple()
        {
            var url = new Uri("http://httpbin.org/post");
            var parameters = new Dictionary<string, byte[]> {{"one", new byte[] {1}}, {"two", new byte[] {1}}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.PostMultipleFilesAsync(url, parameters))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                response.Should().NotBeNull();
            }
        }

        [Fact]
        public async void VkApiGetForStream()
        {
            var url = new Uri("https://api.vk.com/method/users.get");
            var parameters = new Dictionary<string, string> {{"user_ids", "1"}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.GetForStreamAsync(url, parameters))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                var content = response["response"][0];
                content["first_name"].ToString().Should().Be("Павел");
                content["last_name"].ToString().Should().Be("Дуров");
            }
        }

        [Fact]
        public async void VkApiPostForStream()
        {
            var url = new Uri("https://api.vk.com/method/users.get");
            var parameters = new Dictionary<string, string> {{"user_ids", "1"}};
            using (var defaultHttpService = new DefaultHttpService(Logger))
            using (var stream = await defaultHttpService.PostForStreamAsync(url, parameters))
            using (var streamReader = new StreamReader(stream))
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var serializer = new JsonSerializer();
                var response = serializer.Deserialize<JToken>(jsonTextReader);
                var content = response["response"][0];
                content["first_name"].ToString().Should().Be("Павел");
                content["last_name"].ToString().Should().Be("Дуров");
            }
        }
    }
}