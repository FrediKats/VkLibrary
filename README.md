# VkLibrary
.NET library that covers almost all <a href="https://vk.com/dev">VK.COM API methods</a>. Huge parts of it were generated using <a href="https://github.com/VKCOM/vk-api-schema">Json Schema</a> and a self-written Python script <a href="https://github.com/Worldbeater/VkLibrary/blob/master/parser.py">parser.py</a>. Some features are not currently working and library may contain bugs, but work is in progress. Instructions on how to use the library are provided below.

## Contents
- <a href="#installation">Installation</a>
- <a href="#initializing">Initializing</a>
- <a href="#authentication">Authentication</a>
- <a href="#calling-api-methods">Calling API methods</a>
- <a href="#uploading-files">Uploading files</a>
- <a href="#executing-scripts-in-vkscript">Executing scripts in VkScript</a>
- <a href="#roadmap">Roadmap</a>

## Installation
To install, use or edit this portable class library you should do the following:
- Open your project in Visual Studio solution explorer;
- Right-click "References", choose "Add Reference";
- From left-side menu choose "Browse";
- In Explorer file type menu choose "All types" and select "VkLib.sln" from VkLibrary/VkLib.Core/VkLib.sln


## Initializing
Firstly, initialize the library. Use your vk app's ID and Secret code.
```c#
Vkontakte vk = new Vkontakte(
    appId: "1234567",                 
    clientSecret: "Hfsbdjw364hbjf2",  
    apiVersion: "5.60"                
  );
```

## Authentication
Most methods require a valid access token. To get that token using <b>OAuth</b>, you should show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found <a href="http://vk.com/dev/auth_mobile">here</a>. There are some examples below on how to get things done in UWP:
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

If you are developing an vk application that was <a href="https://vk.com/dev/auth_direct">approved</a> by vk administration, than you can use Direct Auth extensions. You need to write the following code to achieve this:
```c#
AccessToken accessToken = await App.vk.DirectAuth.Login(
    login: LoginBox.Text,           // User's login (e-mail or phone)
    password: PasswordBox.Password, // User's password
    scope: ScopeSettings.IamTheGod  // Scope settings
);
```

## Calling API methods
All API methods are listed <a href="https://vk.com/dev/methods">here</a>. Calling them is quite simple, just use the following syntax:
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
If you find an API method that VkLibrary does not support (this is unlikely, but may happen), use a generic GetAsync<T> method:
```c#
JToken response = vk.GetAsync<JToken>("someSection.getSomeInfo", new Dictionary<string, string> {
    { "some_parameter_one", "its_value" },
    { "some_parameter_two", "its_value" }
  });
```

## Uploading files
VkLibrary has a helper section containing methods for <a href="https://vk.com/dev/upload_files">photo/video/audio/document uploading</a>. This section is called <b>UploadHelper</b>. There is an example below on how to upload a document to VK servers:
```c#
// Get documents upload server.
GetUploadServerResponse server = await vk.Docs.GetUploadServer();

// Upload a document using POST request.
DocUploadResponse response = await vk.UploadHelper.UploadDocument(
    server.UploadUrl, // Server url received on previous step
    "Document.docx",  // Document name 
    bytes             // Bytes representing the document
  );

// Save document and receive it's instance.
Doc document = await vk.Docs.Save(
    response.File,   // Data received on previous step
    "My document!",  // Custom name 
    "usefull, stuff" // Tags separated by comas
  );
```

If there are no POST methods in UploadHelper that can suite you, use generics: PostAsync<T> or PostMultipleAsync<T>.
```c#
// Uploads a photo and catches response into a PhotoUploadResponse object.
PhotoUploadResponse response = await vk.UploadHelper.PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);  

// Uploads a document and catches response into a DocUploadResponse object.
DocUploadResponse response = await vk.UploadHelper.PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);
```

## Executing scripts in VkScript
<a href="https://vk.com/dev/execute">VK.COM API</a> provides an ability to execute code on VK.COM servers. That code should be written in <a href="https://vk.com/dev/execute">VkScript</a>, a language similar to ActionScript or JavaScript, and end with a <b>return %expression%</b> statement. For example:
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

## Roadmap
- Add long polling support;
- Test and fix bugs.
