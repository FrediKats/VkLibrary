using VkLibrary.Core;
using VkLibrary.Core.Auth;
using Xunit.Abstractions;

namespace VkLibrary.Tests.Helpers
{
    public abstract class ClassFixtureBase
    {
        private readonly ITestOutputHelper _testOutputHelper;

        protected ClassFixtureBase(int id, string secret, string token, ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            Api = new Vkontakte(id.ToString(), JsonParsingType.UseString, secret, logger: Log)
            { AccessToken = AccessToken.FromString(token, id) };
        }

        protected Vkontakte Api { get; }

        protected void Log(object o) => _testOutputHelper.WriteLine(o.ToString());
    }
}