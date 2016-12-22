# VkLibrary
.NET library that tries to cover all <a href="https://vk.com/dev">VK.COM API methods</a>. Huge parts of it were generated using <a href="https://github.com/VKCOM/vk-api-schema">Json Schema</a> and a self-written Python script <a href="https://github.com/Worldbeater/VkLibrary/blob/master/parser.py">parser.py</a>. Some features are not currently working and library may contain tons of bugs, but work is in progress. Instructions on how to use the library are provided below.

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
Most methods require a valid access token. To get that token using OAuth, you should show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found <a href="http://vk.com/dev/auth_mobile">here</a>. There are some examples below on how to get things done in UWP:
```c#
// Firstly we build an OAuth url and launch it. (assuming that WebView is a declared Web View control)
string url = vk.OAuth.GetAuthUrl(ScopeSettings.Root, AuthDisplayType.Mobile);
WebView.Navigate(new Uri(url));

// Secondly we subscribe on WebView's navigation starting event:
private async void WebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
{
    // And try to parse url when redirecting:
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

### Uploading files
VkLibrary has a helper section containing methods for photo/video/audio/document uploading. This section is called <b>UploadHelper</b>. There is an example below on how to upload a document to VK servers:
```c#
// Get documents upload server.
string serverUrl = await vk.UploadHelper.GetDocsUploadServer();

// Upload a document using POST request.
string response = await vk.UploadHelper.UploadDocument(
    serverUrl,       // Server url received on previous step
    "Document.docx", // Document name 
    bytes            // Bytes representing the document
  );

// Save document and receive it's instance.
VkLib.Types.Docs.Doc document = await vk.UploadHelper.SaveDocument(
    response,        // Data received on previous step
    "My document!",  // Custom name 
    "usefull, stuff" // Tags separated by comas
  );
```

### Executing scripts in VkScript
VK.COM API provides an ability to execute code on VK.COM servers. That code should be written in <a href="https://vk.com/dev/execute">VkScript</a>, a language similar to ActionScript or JavaScript, and end with a <b>return %expression%</b> statement. For example:
```c#
// Sends an execute request.
JToken result = await vk.Execute<JToken>(
  script: "return [API.users.isAppUser(), API.friends.get(), API.status.get()];"
  );
```
Outputs:
```JSON
[1, {
"count": 5,
"items": [12345678, 87654321, 12345679, 97654321, 01012345]
}, {
"text": "shiny winter"
}]
```

### Roadmap
- Add left methods for video/audio/photo uploading;
- Test and fix bugs.
