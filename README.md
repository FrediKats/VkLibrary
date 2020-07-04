<a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-1.1-green.svg"></a> <a href="https://www.nuget.org/packages/VkApi.Wrapper/"><img src="https://img.shields.io/nuget/v/VkApi.Wrapper.svg"></a> <a href="https://www.nuget.org/packages/VkApi.Wrapper/"><img src="https://img.shields.io/nuget/dt/VkApi.Wrapper.svg"></a> <a href="https://github.com/inredikawb/VkLibrary/issues"><img src="https://img.shields.io/github/issues/Worldbeater/VkLibrary.svg"></a> <a href="https://github.com/inredikawb/VkLibrary/blob/master/LICENSE.md"><img src="https://img.shields.io/github/license/inredikawb/VkLibrary.svg"></a>

**Current VK Api version: 5.116** 

## Readme на русском
Можно посмотреть по ссылке: [RU](README_RU.md)

# Installation
The library is delivered via NuGet Package Manager:
```powershell
Install-Package VkApi.Wrapper
```
If you are targeting .NET Core, use the following command:
```cmd
dotnet add package VkApi.Wrapper
```

# Getting Started
To run most API methods you need to pass an <b>access_token</b>, a special access key. Token is a string of digits and latin characters and may refer to a user, community or application itself. There are several ways to get an <b>access_token</b>, VkLibrary supports <b>DirectAuth</b> and <b>OAuth</b>. 

## Getting Application ID
The first thing you need to do in order to get application id and access token is to register a VK application. Go to <a href="https://vk.com/apps?act=manage">my apps</a> section and select "Create an application". After you'r done with it, you will find app id and client secret code in application's settings section. More detailed instructions can be found <a href="https://vk.com/dev/manuals">here</a>.

## Initializing the library
Initialize the library using your <a href="https://vk.com/apps?act=manage">application id</a>.
```csharp
var vk = new Vkontakte(1234567);
```

# Authentication using OAuth
As we already know, most methods require a valid access token. To get that token using <b>OAuth</b>, show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found <a href="http://vk.com/dev/auth_mobile">in official docs</a>.

Here is a small instruction on how to get things done using UWP. Imagine we have a XAML-declared WebView control named <b>BrowserView</b>. Firstly we build an OAuth url and launch it using preffered ScopeSettings. Secondly we navigate our WebView control to url we've just built:
```csharp
var url = vk.OAuth.GetAuthUrl(ScopeSettings.CanAccessMessages | ScopeSettings.CanAccessOffline, AuthDisplayType.Mobile);
BrowserView.Navigate(new Uri(url));
```
Then we subscribe to WebView's navigation starting event and try to parse WebView's url when user is being redirected.
```csharp
void OnNavigationStarting(WebView sender, EventArgs args)
{
    var result = vk.OAuth.ParseResponseUrl(args.Uri);
    if (result?.IsSuccess == true)
    {
        // We are authenticated! Let's save the token.
        vk.AccessToken = result.AccessToken;
    }
}
```
So VkLibrary will sign all future requests using AccessToken stored in AccessToken property. 

# Authentication using an existing access token
If you'd like to use an existing access token to authenticate a user, just use <b>AccessToken.FromString</b> method:
```csharp
vk.AccessToken = AccessToken.FromString(accessTokenString);
```

# Authentication using Direct Auth
If you are developing an application that was <a href="https://vk.com/dev/auth_direct">approved</a> by vk administration, you can use Direct Auth extensions. Note that in this case you need to set your application's secret code (also known as <b>client_secret</b>). Do the following to authorize a user and to get an AccessToken:
```csharp
vk.AccessToken = await vk.DirectAuth.Login("login", "pass", ScopeSettings.CanAccessWhatever);
```

# Calling API Methods
All API methods are listed <a href="https://vk.com/dev/methods">here</a>.

Returns a list of current user's friends by invoking <a href="https://vk.com/dev/friends.get">friends.get</a> API method:
```csharp
var friends = await vk.Friends.Get();
```

Returns a sequence of vk users containing only one user, whose id is <b>210700286</b>, using Nom. name case:
```csharp
var users = await vk.Users.Get(
  userIds: new[] { "210700286" },    
  fields: new[] { "photo_50", "city", "verified" },
  nameCase: "Nom"
);
```
Returns last 10 messages from a conversation with user, whose id is <b>12345</b>.
```csharp
var messages = await vk.Messages.GetHistory(userId: "12345", count: 10);
```
  
Sends a message to a user. Returns 1 if OK, 0 if not OK.
```csharp
var ok = await vk.Messages.Send(userId: "12345", message: "Hey! What's up?");
```

## Invoking RequestAsync<TResponse>
If you find an API method that VkLibrary does not support (this is unlikely, but may happen), use <b>GetAsync</b> method.
```csharp
var friends = await vk.RequestAsync<ApiItemsResponse<UserFull>>(
  "friends.get", new Dictionary<string, string> {
    { "userId", "1234567" },
    { "count", "10" }
  }
);
```
The code above is equivalent to:
```csharp
var friends = await vk.Friends.Get(userId: 1234567, count: 10);
```

# Executing Scripts
<a href="https://vk.com/dev/execute">API</a> provides an ability to execute code on vk servers. Such code should be written in <a href="https://vk.com/dev/execute">VkScript</a>, a language similar to ActionScript or JavaScript, and end with a <b>return %expression%</b> statement.

If we send this kind of execute request:
```csharp
var script = "return [API.users.isAppUser(), API.friends.get()];";
var result = await vk.Execute<JToken>(script);
```
The server will answer with a similar response:
```json
[1, { 
"count": 5,
"items": [12345678, 87654321, 12345679, 97654321, 01012345]
}]
```

# Uploading Files
VkLibrary has a helpers section containing methods for <a href="https://vk.com/dev/upload_files">photos, videos, audios and documents uploading</a>. This section is called <b>UploadHelper</b>. Here are some examples on how to use these helpers.

## Document Uploading Example
```csharp
var server = await vk.Docs.GetUploadServer();
var response = await vk.UploadHelper.UploadDocument(
    server.UploadUrl, // Server url received using GetUploadServer
    "Document.docx",  // Document name 
    bytes             // Bytes representing the document
);
var document = await vk.Docs.Save(
    response.File,   // File received on previous step
    "My document!",  // Document name
    "usefull, stuff" // Tags separated by comas
);
```

## Photo for Messages Uploading Example
```csharp
var uploadServer = await App.vk.Photos.GetMessagesUploadServer();
var uploadResponse = await App.vk.UploadHelper.UploadMessagesPhoto(
    uploadServer.UploadUrl, file.Name, bytes
);
var uploadResult = await App.vk.Photos.Save(
    uploadResponse.Photo,
    uploadResponse.Server,
    uploadResponse.Hash,
    -3
);
```

# Generic PostAsync<T>
If there are no POST methods in UploadHelper that can suite you, use generic ones: <b>PostAsync<T></b> or <b>PostMultipleAsync<T></b>.

Uploads multiple photos to vk servers using PostMultipleAsync method.
```csharp
var response = await vk.UploadHelper.PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);  
```
Uploads a document to vk servers using PostAsync method.
```csharp
var response = await vk.UploadHelper.PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);
```

# Processing Captcha
If any action (e.g. sending a message) is performed too frequently, an API request may return "Captcha needed" error. After that a user needs to enter a code from the image and resend a request with a Captcha code input in the request parameters. 

<b>Error code:</b> 14 

<b>Error text:</b> Captcha needed

<a href="https://vk.com/dev/captcha_error">See official docs for more detailed info</a>

## Understanding Exception Handling
<b>VkLibrary</b> provides an ability to process API captcha errors. When VK servers return a captcha error, VkLibrary throws an <a href="VkApi.Wrapper/ApiException.cs">ApiException</a>. ApiException holds an <a href="VkApi.Wrapper/ApiException.cs">ApiError</a> object that contains such fields as <b>Code</b> and <b>ErrorMessage</b>. So, when this type of exception is thrown, we should catch it and check <b>ApiError</b> code. If it equals <b>14</b>, than we will need to process the captcha.
```csharp
try {
  // Invoke any library method
} catch (ApiException apiException) {
  var apiError = apiException.GetApiError();
  if (apiError.Code == 14) {
    // Hey! Captcha needed!
    var captchaSid = apiError.CaptchaSid;
    var captchaUrl = apiError.CaptchaImg;
  }
}
```

## Processing Captcha
To handle this kind of exception we should invoke <b>SetCaptchaForNextRequest</b> library method and pass <b>CaptchaSid</b> and user's answer <b>CaptchaKey</b> to it. So you we need to write something like this:
```csharp
// Show captcha to a user and store results in 'captchaKey' 
vk.SetCaptchaForNextRequest(captchaSid, captchaKey);
vk.SomeRequest.PerformAgain();
```

# Working with LongPoll Server

Long polling is a technology that allows the receiving of information about new events with the help of "long requests". The server receives the request but it doesn't immediately send the answer but rather when some event will happen (for example, receiving a new incoming message), or waiting period is over. Learn more about how VK's LongPoll server works on it's <a href="https://vk.com/dev/using_longpoll">documentation page</a>.

VkLibrary provides a simple event-based wrapper to work with the LongPoll server in an easy way. This wrapper is named <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs">LongPollClient</a> and is located in <a href="VkApi.Wrapper/LongPolling/User">VkApi.Wrapper.LongPolling.User
 namespace</a>. Let's learn how it works.

## Starting a Long Poll Client
Firstly we need to get new <a href="VkApi.Wrapper/Objects/Messages/MessagesLongpollParams.cs">long poll server parameters</a> from API. Then we need to start a <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs">long poll client</a> to work with. 
```csharp
var longPollParams = await vk.Messages.GetLongPollServer();
var longPollClient = vk.StartUserLongPollClient(
  longPollParams.Server, // Server received on previous step
  longPollParams.Key,    // Secret session key
  longPollParams.Ts,     // Event number
);
```

## Working with Events
Our long poll client is now ready to notify us when new vk events take place. A list of all available events can be found <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs#L97-L197">here</a>. Subscribing to events is easy and familiar. Let's subscribe to <b>FriendOnlineEvent</b> to be notified when friends launch vk applications:
```csharp
longPollClient.FriendOnlineEvent += (sender, args) => Console.WriteLine(
  $"Friend with id {args.Item1} is now online! He uses {args.Item2} platform."
);
```
Info about all available events with description can be found <a href="../api/VkLibrary.Core.LongPolling.LongPollClient.html">here</a>.

## Stopping and Disposing
If we don't need our long poll client anymore, we should stop it. 
```csharp
longPollClient.Stop();
```

# Extended Scenarios

VkLibrary also contains additional extended constructors, using them you can customize almost everything. 
```csharp
var api = new Vkontakte(
  appId: 1234567, 
  appSecret: "fb4f44tbuyh5k",
  apiVersion: "5.63",
  requestMethod: RequestMethod.Get,
  parseJson: ParseJson.FromString
);
```

<b>ParseJson</b> option determines how the library should parse JSONs received from VK servers.
- <i>ParseJson.FromString</i>: loads JSON into a string, logs it using default logger and only after that deserializes. Use this for testing purposes only due to potential high memory usage and performance issues;
- <i>ParseJson.FromStream</i>: to minimize memory usage and the number of strings allocated in memory, JSON.NET supports deserializing objects directly from a stream. Use this option in production for better performance.

<b>RequestMethod</b> determines which request method should be used when sending queries to Vkontakte API. GET option is generally a good choice for testing and debugging as GET queries are easy to read and understand. But when sending large objects to VK API servers consider using POST option, otherwise you'll receive "414 URI Too Long" error.

There may be some cases when you would like to customize default HttpService implementation. To do this, simply implement <b>IHttpService</b> interface and pass your new class instance to VkLibrary.Core via an extended constructor. The same thing you can do with a default logger, you'll need an <b>ILogger</b> interface. Default implementations of ILogger and IHttpService are <b>DefaultLogger</b> and <b>DefaultHttpService</b> respectively.
```csharp
class CustomLogger : ILogger { /* implementation */ }
class CustomHttpService : IHttpService { /* implementation */ }
var api = new Vkontakte(1234567, string.Empty, new CustomHttpService(), new CustomLogger());
```

# Other .NET languages

## For F# Developers
VkLibrary can also be used with <a href="http://fsharp.org/">F# programming language</a>! Use <a href="https://github.com/rspeele/TaskBuilder.fs">TaskBuilder.fs</a> to improve your code quality.
```fsharp
task {
  use lib = new Vkontakte(1234567, "your_secret_code")
  let! friends = lib.Friends.Get()
  let! users = lib.Users.Get()
}
```
F# gives us an ability to create annonymous interface implementations! Using this feature you can write code like this and inject a custom logger into VkLibrary.Core:
```fsharp
let logger = { new ILogger with member __.Log o = printfn "%A" o }
use api = new Vkontakte(1234567, "your_secret_code", logger = logger)
```

## For Visual Basic Developers
Using VkLibrary with Visual Basic is pretty much the same as using it with C#. 
```vb
Dim vk = new Vkontakte(12345, String.Empty)
Dim response = Await vk.Friends.Get(userId := 12345, count := 10)
```
