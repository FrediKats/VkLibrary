# VkLibrary
.NET library that tries to cover all <a href="https://vk.com/dev">VKCOM API methods</a>. Huge parts of it were generated using <a href="https://github.com/VKCOM/vk-api-schema">Json Schema</a> and a self-written script <a href="https://github.com/Worldbeater/VkLibrary/blob/master/parser.py">parser.py</a>. Some features are not currently working and library may contain tons of bugs, but work is in progress.

### Initializing
Firstly, initialize the library. Use your vk app's ID and Secret code.
```c#
Vkontakte vk = new Vkontakte(
    appId: "1234567",                 
    clientSecret: "Hfsbdjw364hbjf2",  
    apiVersion: "5.60"                
  );
```
### Authentication
Most methods require a valid access token. To get that token using OAuth, you should show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found here: http://vk.com/dev/auth_mobile. There are some examples on how this stuff could be done in UWP:
```c#
// Firstly we build an OAuth url and launch it. (assuming that WebView is a declared Web View control)
string url = vk.OAuth.GetAuthUrl(ScopeSettings.Root, AuthDisplayType.Mobile);
WebView.Navigate(new Uri(url));

// Secondly we should subscribe on WebView's navigation starting event and put some code there:
private async void WebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
{
    OAuthResult result = vk.OAuth.ParseResponseUrl(args.Uri);
    if (result != null && result.IsSuccess)
    {
        // We are authenticated!
        string token = result.AccessToken.Token;
        vk.AccessToken = result.AccessToken;
    }
}
```
### Calling API methods
Calling methods is quite simple. Just use the following syntax:
```c#
// Returns a sequence of vk users.
IEnumerable<UserFull> users = await vk.Users.Get(
    user_ids: new string[] { "210700286" },
    fields: new string[] { "photo_50", "city", "verified" },
    name_case: "Nom"
  );
  
// Returns 10 last messages from a conversation with a user.
ApiItemsResponse<Message> messages = await vk.Messages.GetHistory(
    user_id: "12345",
    count: 10,
    offset: 0
  );
  
// Sends message to a user. Returns 1 if OK, 0 if not OK.
int is_okay = await vk.Messages.Send(
    user_id: "12345",
    message: "Hey! What's up?"
  );
```


### Roadmap
- Add methods for video/audio/photo uploading
- Add vk script support
- Try to fix bugs
