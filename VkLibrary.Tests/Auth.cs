using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using FluentAssertions;
using VkLibrary.Core.Auth;
using VkLibrary.Tests.Helpers;
using Xunit;
using Xunit.Abstractions;

namespace VkLibrary.Tests
{
    public class Auth : ClassFixtureBase
    {
        public Auth(ITestOutputHelper testOutputHelper) : base(Constants.OfficialApplicationId,
            Constants.OfficialApplicationSecret, string.Empty, testOutputHelper) { }

        [Fact]
        public async void DirectAuth()
        {
            const string login = Constants.Login; 
            const string password = Constants.Password;
            var response = await Api.DirectAuth.Login(login, password, 
                ScopeSettings.CanAccessStatus);

            response.Should().NotBeNull();
            response.Token.Should().NotBeNull();
            response.HasExpired.Should().BeFalse();
        }

        [Fact]
        public void PrepareOAuthUrl()
        {
            const ScopeSettings scopeSettings = ScopeSettings.IamTheGod;
            const AuthDisplayType authDisplayType = AuthDisplayType.Page;
            var response = Api.OAuth.GetAuthUrl(scopeSettings, authDisplayType);
            
            var query = new Uri(response).Query;
            var decodedQuery = WebUtility.HtmlDecode(query);
            Log(decodedQuery);
            
            var parameters = decodedQuery
                .Substring(1)
                .Split('&')
                .Select(i => i.Split('='))
                .ToDictionary(i => i[0], i => i[1]);

            foreach (var parameter in new Dictionary<string, string>
            {
                {"display", authDisplayType.ToString().ToLower()},
                {"scope", ((int)scopeSettings).ToString().ToLower()},
                {"client_id", Constants.OfficialApplicationId.ToString()},
                {"response_type", "token"}
            })
            {
                var actual = parameters[parameter.Key];
                var expected = parameter.Value;
                actual.Should().Be(expected);
            }
        }

        [Fact]
        public void ParseSuccessUrl()
        {
            const string url = "https://oauth.vk.com/blank.html#" +
                               "access_token=foo&expires_in=0&user_id=1234&email=bar";
            var parsedUrl = Api.OAuth.ParseResponseUrl(new Uri(url));
            var token = parsedUrl.AccessToken.Token;

            parsedUrl.IsSuccess.Should().BeTrue();
            parsedUrl.Error.Should().BeNull();
            token.Should().Be("foo");
        }

        [Fact]
        public void ParseFailureUrl()
        {
            const string url = "https://oauth.vk.com/blank.html#" +
                               "error=access_denied&error_reason=user_denied&" +
                               "error_description=User denied access";
            var parsedUrl = Api.OAuth.ParseResponseUrl(new Uri(url));
            var token = parsedUrl.AccessToken.Token;

            parsedUrl.IsSuccess.Should().BeFalse();
            parsedUrl.Error.Should().Be("access_denied");
            token.Should().BeNull();
        }
    }
}