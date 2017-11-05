namespace VkLibrary.Tests.Helpers
{
    /// <summary>
    /// To get your own constants consider creating a new Vkontakte application
    /// at https://dev.vk.com/apps, get Application Id from there, procceed OAuth to get 
    /// your access token, change Password and Login constant to your own vkontakte login 
    /// and password. After you are done with this, the tests should be running properly.
    /// ! WARNING ! 
    /// Ensure this file is being ignored via .gitignore file or erace your 
    /// credentials before pull requesting to not be compromised!
    /// </summary>
    public class Constants
    {   
        public const int OfficialApplicationId = 3502561;
        public const string OfficialApplicationSecret = "omvP3y2MZmpREFZJDNHd";
        
        #region Per-user configuration

        public const int ApplicationId = 0; // SET YOUR APP ID HERE
        public const string AccessToken = "SET_YOUR_TOKEN_HERE";
        public const string Password = "SET_YOUR_PASS_HERE";
        public const string Login = "SET_YOUR_LOGIN_HERE";
        
        #endregion
    }
}