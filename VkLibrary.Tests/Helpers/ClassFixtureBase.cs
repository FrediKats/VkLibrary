using VkLibrary.Core;
using VkLibrary.Core.Auth;
using VkLibrary.Core.Services;
using Xunit.Abstractions;

namespace VkLibrary.Tests.Helpers
{
    public abstract class ClassFixtureBase
    {
        protected ClassFixtureBase(int id, string secret, string token, ITestOutputHelper testOutputHelper)
        {
            Logger = new XUnitLogger(testOutputHelper);
            Api = new Vkontakte(id, secret, "5.63", RequestMethod.Get, ParseJson.FromString, 
                Logger, new DefaultHttpService(Logger)) {
                AccessToken = AccessToken.FromString(token, id)
            };
        }

        protected Vkontakte Api { get; }

        protected ILogger Logger { get; }
    }
        
    public class XUnitLogger : ILogger 
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public XUnitLogger(ITestOutputHelper testOutputHelper) => _testOutputHelper = testOutputHelper;
            
        public void Log(object o) => _testOutputHelper.WriteLine(o.ToString());
    }
}