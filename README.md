<a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://img.shields.io/badge/.NET%20Standard-1.2-green.svg"></a>
<a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://img.shields.io/nuget/v/VkLibrary.Core.svg"></a>
<a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://img.shields.io/nuget/dt/VkLibrary.Core.svg"></a>
<a href="https://github.com/Worldbeater/VkLibrary/issues"><img src="https://img.shields.io/github/issues/Worldbeater/VkLibrary.svg"></a>
<a href="https://github.com/Worldbeater/VkLibrary/blob/master/LICENSE.md"><img src="https://img.shields.io/github/license/worldbeater/VkLibrary.svg"></a>

# VkLibrary <a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://worldbeater.github.io/logos/VkLibrary.png" width="22" height="22"></a>
<b>VkLibrary</b> is an unofficial <a href="https://vk.com/dev">vk.com API</a> library implemented in C# and covering almost all existing <a href="https://vk.com/dev/methods">API methods and types</a>, contains helper methods for <a href="https://vk.com/dev/access_token">DirectAuth and OAuth</a>, contains methods for easy file uploading to vk.com servers using POST requests. Huge parts of it were generated using <a href="https://github.com/VKCOM/vk-api-schema">JSON Schema</a> and Python scripts. Instructions on how to use the library are provided below.

## Contents
- <a href="#getting-started">Getting started</a>
- <a href="#initializing">Initializing</a>
- <a href="#authentication">Authentication</a>
- <a href="#calling-api-methods">Calling API methods</a>
- <a href="#uploading-files">Uploading files</a>
- <a href="#executing-scripts-in-vkscript">Executing scripts in VkScript</a>
- <a href="#for-f-developers">For F# developers</a>
- <a href="#for-visual-basic-developers">For Visual Basic developers</a>
- <a href="#reporting-bugs">Reporting bugs</a>
- <a href="#roadmap">Roadmap</a>

## Getting Started
To use VkLibrary in your project you should install a <a href="https://www.nuget.org/packages/VkLibrary.Core/">VkLibrary.Core</a> nuget package:
```
PM> Install-Package VkLibrary.Core
```

## Initializing
Firstly, initialize the library. Specify your vk app's ID and preffered JSON parsing type.
```c#
var vk = new Vkontakte("1234567", JsonParsingType.UseString);
```
- <i>JsonParsingType.UseString</i> is optimal for debugging; 
- <i>JsonParsingType.UseStream</i> is optimal for performance.

You can also specify your client secret key, preffered api version and a custom logger. Just do this:
```c#
var vk = new Vkontakte(
    appId: "1234567", 
    jsonParsingType: JsonParsingType.UseStream,
    clientSecret: "qWeRtysbfdXT",
    apiVersion: "5.65",
    logger: Console.WriteLine
);
```

## Authentication
Most methods require a valid access token. To get that token using <b>OAuth</b>, you should show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found <a href="http://vk.com/dev/auth_mobile">here</a>. There is an example below on how to get things done in UWP:
```c#
// Firstly we build an OAuth url and launch it. (assuming that WebView is a declared Web View control)
var url = vk.OAuth.GetAuthUrl(ScopeSettings.CanAccessMessages, AuthDisplayType.Mobile);
webView.Navigate(new Uri(url));

// Secondly we subscribe to WebView's navigation starting event:
void OnNavigationStarting(WebView sender, EventArgs args)
{
    // And try to parse url when redirecting:
    var result = vk.OAuth.ParseResponseUrl(args.Uri);
    if (result?.IsSuccess == true)
    {
        // We are authenticated! Let's save the token.
        vk.AccessToken = result.AccessToken;
        
        // So library will sign all future requests using 'token' value.
        var token = vk.AccessToken.Token;
    }
}
```
If you are developing an application that was <a href="https://vk.com/dev/auth_direct">approved</a> by vk administration, you can use Direct Auth extensions. You need to write the following code to perform user authentication:
```c#
var accessToken = await vk.DirectAuth.Login("login", "password", ScopeSettings.CanAccessWhatever);
```

## Calling API Methods
All API methods are listed <a href="https://vk.com/dev/methods">here</a>. Calling them is quite simple, just use the following syntax:
```c#
// Returns current user's friends enumerable.
var friends = await vk.Friends.Get();

// Returns a sequence of vk users containing only one user, whose id is '210700286'.
var users = await vk.Users.Get(
    userIds: new[] { "210700286" },    
    fields: new[] { "photo_50", "city", "verified" },
    nameCase: "Nom"
);

// Returns last 10 messages from a conversation.
var messages = await vk.Messages.GetHistory(userId: "12345", count: 10);
  
// Sends message to a user. Returns 1 if OK, 0 if not OK.
var ok = await vk.Messages.Send(userId: "12345", message: "Hey! What's up?");
```
If you find an API method that VkLibrary does not support (this is unlikely, but may happen), use a generic <b>GetAsync</b> method:
```c#
// Returns first 10 friends by using generic GetAsync method.
var friends = vk.GetAsync<ApiItemsResponse<UserFull>>("friends.get", 
    new Dictionary<string, string> {
        { "userId", "1234567" },
        { "count", "10" }
    }
);

// The code above is equivalent to:
var friends = vk.Friends.Get(userId: 1234567, count: 10);
```

## Uploading Files
VkLibrary has a helpers section containing methods for <a href="https://vk.com/dev/upload_files">photos, videos, audios and documents uploading</a>. This section is called <b>UploadHelper</b>. There is an example below on how to upload a document to VK servers:
```c#
// Get documents upload server.
var server = await vk.Docs.GetUploadServer();

// Upload a document using POST request.
var response = await vk.UploadHelper.UploadDocument(
    server.UploadUrl, // Server url received using GetUploadServer
    "Document.docx",  // Document name 
    bytes             // Bytes representing the document
);

// Save document and receive it's instance.
var document = await vk.Docs.Save(
    response.File,   // Data received on previous step
    "My document!",  // Name for the document
    "usefull, stuff" // Tags separated by comas
);
```
If there are no POST methods in UploadHelper that can suite you, use generics: <b>PostAsync</b> or <b>PostMultipleAsync</b>.
```c#
// Uploads multiple photos to vk servers using generic PostMultipleAsync method.
var response = await vk.UploadHelper.PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);  

// Uploads a document to vk servers using generic PostAsync method.
var response = await vk.UploadHelper.PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);
```

## Executing Scripts in VkScript
<a href="https://vk.com/dev/execute">API</a> provides an ability to execute code on VK.COM servers. Such code should be written in <a href="https://vk.com/dev/execute">VkScript</a>, a language similar to ActionScript or JavaScript, and end with a <b>return %expression%</b> statement. For example:
```c#
// Sends an execute request.
var result = await vk.Execute<JToken>(
    script: "return [ API.users.isAppUser(), API.friends.get(), API.status.get() ];"
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

## For F# Developers
VkLibrary can also be used with <a href="http://fsharp.org/">F# programming language</a>!
```f#
// Before we start, let's create a generic to simulate 
// C# await operator for Task<'a>.
let await (task: Task<'a>) = 
    async {
        let! result = task |> Async.AwaitTask 
        return result 
    } |> Async.RunSynchronously
 
// Firstly we need to initialize the library:
use lib = new Vkontakte (string 1234567, JsonParsingType.UseStream)

// So we can call library methods in a familiar way!
let friends = await <| lib.Friends.Get()
let firstFriend = 
    lib.Friends.Get(userId = Nullable 1234567, count = Nullable 1)
    |> await
    |> fun x -> x.Items.[0]
```

## For Visual Basic Developers
Using VkLibrary with Visual Basic is pretty much the same as using it with C#. Examples:
```vb
Dim vk = new Vkontakte("12345", JsonParsingType.UseStream)
Dim result = Await vk.Friends.Get(userId := 12345, count := 10)
```

## Reporting Bugs
Please, report any bugs you find! Use this link to submit a bug-report:
- <a href="https://github.com/Worldbeater/VkLibrary/issues/new">Open an issue</a>

## Roadmap
- Add long polling support
- Test and fix bugs left

## License Info
Licensed under the <a href="https://github.com/Worldbeater/VkLibrary/blob/master/LICENSE.md">MIT license</a>.
