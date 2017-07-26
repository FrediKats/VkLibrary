<a href="https://github.com/worldbeater/VkLibrary">
  <img src="https://worldbeater.github.io/logos/VkLibrary.png" width="100" height="100">
</a>

<b>VkLibrary</b> is an <i>unofficial</i> <a href="https://vk.com/dev">VK API</a> library implemented in C# and covering almost all existing API methods and types, containing helper methods for DirectAuth and OAuth, containing methods for easy file uploading to vk servers using POST requests. Huge parts of it were generated using official JSON Schema to provide full API coverage.

|Targets|Nuget|Downloads|Issues|License|
|------|:------:|:------:|:------:|:------:|
| <a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-1.1-green.svg"></a> | <a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://img.shields.io/nuget/v/VkLibrary.Core.svg"></a> | <a href="https://www.nuget.org/packages/VkLibrary.Core/"><img src="https://img.shields.io/nuget/dt/VkLibrary.Core.svg"></a> | <a href="https://github.com/Worldbeater/VkLibrary/issues"><img src="https://img.shields.io/github/issues/Worldbeater/VkLibrary.svg"></a> | <a href="https://github.com/Worldbeater/VkLibrary/blob/master/LICENSE.md"><img src="https://img.shields.io/github/license/worldbeater/VkLibrary.svg"></a> |

# Quick Start
To use the library in your project you should install a <a href="https://www.nuget.org/packages/VkLibrary.Core/">VkLibrary.Core</a> nuget package using PM console or GUI:
```
Install-Package VkLibrary.Core
```
If you are targeting .NET Core, use the following command:
```
dotnet add package VkLibrary.Core
```

# Getting Started
To run most API methods you need to pass an <b>access_token</b>, a special access key. Token is a string of digits and latin characters and may refer to a user, community or application itself. There are several ways to get an <b>access_token</b>, VkLibrary supports <b>DirectAuth</b> and <b>OAuth</b>. 

## Getting Application ID
The first thing you need to do in order to get application id and access token is to register a VK application. Go to <a href="https://vk.com/apps?act=manage">my apps</a> section and select "Create an application". After you'r done with it, you will find app id and client secret code in application's settings section. More detailed instructions can be found <a href="https://vk.com/dev/manuals">here</a>.

## Initializing the Library
Then we can initialize library using preffered parameters. Here is the simpliest way to do this:
```csharp
var vk = new Vkontakte("application ID", JsonParsingType.UseString);
```
We can also specify client secret key, preffered API version and a custom logger.
```csharp
var vk = new Vkontakte(
    appId: "243254361", 
    jsonParsingType: JsonParsingType.UseStream,
    clientSecret: "qWeRtysbfdXT",
    apiVersion: "5.65",
    logger: o => Console.WriteLine(o)
);
```
<b>JsonParsingType</b> determines the way how received JSON objects are parsed. In general:
- <i>JsonParsingType.UseString</i> is optimal for debugging as it invokes the logger before deserializing objects, so we can see more detailed debug output; 
- <i>JsonParsingType.UseStream</i> is optimal for performance as it provides stream-based deserialization which uses less memory on larger JSON objects.

<b>ClientSecret</b> is used for calling secure API methods and usually is not needed.

<b>ApiVersion</b> determines which API version vk library will use.

<b>Logger</b> is an action that should be invoked when VkLibrary needs to log something for you. For example, you can pass <b>Console.WriteLine</b> or <b>Debug.WriteLine</b> as a logger, so VkLibrary will write logs to Console or Debug output when something important happens.

# Authentication using OAuth
As we already know, most methods require a valid access token. To get that token using <b>OAuth</b>, show a WebView-like control to a user, navigate him to authentication page and handle future redirects. More info can be found <a href="http://vk.com/dev/auth_mobile">in official docs</a>.

## Example
Here is a small instruction on how to get things done using UWP. Imagine we have a XAML-declared WebView control named <b>BrowserView</b>. Firstly we build an OAuth url and launch it using preffered ScopeSettings. Secondly we navigate our WebView control to url we've just built:
```csharp
var url = vk.OAuth.GetAuthUrl(ScopeSettings.CanAccessMessages, AuthDisplayType.Mobile);
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

# Authentication using Direct Auth
If you are developing an application that was <a href="https://vk.com/dev/auth_direct">approved</a> by vk administration, you can use Direct Auth extensions. Note that in this case you need to set your application's secret code (also known as <b>client_secret</b>). Do the following to authorize a user and to get an AccessToken:
```csharp
vk.AccessToken = await vk.DirectAuth.Login("login", "pass", ScopeSettings.CanAccessWhatever);
```

# Calling API Methods
All API methods are listed <a href="https://vk.com/dev/methods">here</a>. Calling them from VkLibrary is quite simple.

## Examples
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

## Invoking GetAsync<TResponse>
If you find an API method that VkLibrary does not support (this is unlikely, but may happen), use a generic <b>GetAsync</b> method. For example, method invocation with these parameters returns first 10 people, who are friends of a person whose id is equal to <b>1234567</b>.
```csharp
var friends = await vk.GetAsync<ApiItemsResponse<UserFull>>(
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

## Example
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
Firstly we get documents upload server.
```csharp
var server = await vk.Docs.GetUploadServer();
```
Then we upload a document to the server we've just received.
```csharp
var response = await vk.UploadHelper.UploadDocument(
    server.UploadUrl, // Server url received using GetUploadServer
    "Document.docx",  // Document name 
    bytes             // Bytes representing the document
);
```
Finally we save the document with desired name and tags and receive it's instance as an API object.
```csharp
var document = await vk.Docs.Save(
    response.File,   // Data received on previous step
    "My document!",  // Name for the document
    "usefull, stuff" // Tags separated by comas
);
```

## Photo for Messages Uploading Example
Firstly we get messages upload server.
```csharp
var uploadServer = await App.vk.Photos.GetMessagesUploadServer();
```
Then we upload a photo to the server we received on previous step.
```csharp
var uploadResponse = await App.vk.UploadHelper.UploadMessagesPhoto(
    uploadServer.UploadUrl, file.Name, bytes
);
```
Finally we save the photo and receive it's instance containing information about it's sizes.
```csharp
var uploadResult = await App.vk.Photos.Save(
    uploadResponse.Photo,
    uploadResponse.Server,
    uploadResponse.Hash,
    -3
);
```

# Generic PostAsync<T>
If there are no POST methods in UploadHelper that can suite you, use generic ones: <b>PostAsync<T></b> or <b>PostMultipleAsync<T></b>.

## Examples
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
<b>VkLibrary</b> provides an ability to process API captcha errors. When VK servers return a captcha error, VkLibrary throws an <a href="../api/VkLibrary.Core.ApiException.html">ApiException</a>. ApiException holds an <a href="../api/VkLibrary.Core.ApiError.html">ApiError</a> object that contains such fields as <b>Code</b> and <b>ErrorMessage</b>. So, when this type of exception is thrown, we should catch it and check <b>ApiError</b> code. If it equals <b>14</b>, than we will need to process the captcha.
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

VkLibrary provides a simple event-based wrapper to work with the LongPoll server in an easy way. This wrapper is named <a href="../api/VkLibrary.Core.LongPolling.LongPollClient.html">LongPollClient</a> and is located in <a href="../api/VkLibrary.Core.LongPolling.html">VkLibrary.Core.LongPolling namespace</a>. Let's learn how it works.

## Starting a Long Poll Client
Firstly we need to get new <a href="../api/VkLibrary.Core.Types.Messages.LongpollParams.html">long poll server parameters</a> from API.
```csharp
var longPollParams = await vk.Messages.GetLongPollServer();
```
Then we need to start a <a href="../api/VkLibrary.Core.LongPolling.LongPollClient.html">long poll client</a> to work with. 
```csharp
var longPollClient = vk.StartLongPollClient(
  longPollParams.Server, // Server received on previous step
  longPollParams.Key,    // Secret session key
  longPollParams.Ts,     // Event number
);
```

## Working with Events
Our long poll client is now ready to notify us when new vk events take place. A list of all available events can be found <a href="../api/VkLibrary.Core.LongPolling.LongPollClient.html">here</a>. Subscribing to events is easy and familiar. Let's subscribe to <b>FriendOnlineEvent</b> to be notified when friends launch vk applications:
```csharp
longPollClient.FriendOnlineEvent += (sender, args) => Console.WriteLine(
  $"Friend with id {args.Item1} is now online! He uses {args.Item2} platform."
);
```
Then let's subscribe to <b>CounterUpdateEvent</b> to be notified when message counters are updated:
```csharp
longPollClient.CounterUpdateEvent += (sender, args) => Console.WriteLine(
  $"Now new messages counter equals {args.Item1}."
);
```
Info about all available events with description can be found <a href="../api/VkLibrary.Core.LongPolling.LongPollClient.html">here</a>.

## Stopping and Disposing
If we don't need our long poll client anymore, we should stop it. 
```csharp
longPollClient.Stop();
```

# Other .NET languages

## For F# Developers
VkLibrary can also be used with <a href="http://fsharp.org/">F# programming language</a>!

### Examples
Before we start, let's create a generic function to simulate C#'s await operator for Task<'a>.
```fsharp
let await (task: Task<'a>) = 
    async {
        let! result = task |> Async.AwaitTask 
        return result 
    } |> Async.RunSynchronously
```
Then we need to initialize the library:
```fsharp
use lib = new Vkontakte (string 1234567, JsonParsingType.UseStream)
```
So we can call library methods in a familiar way!
```fsharp
let friends = await <| lib.Friends.Get()
```
To pass nullable parameters use <b>Nullable</b> keyword.
```fsharp
let firstFriend = 
    lib.Friends.Get(userId = Nullable 1234567, count = Nullable 1)
    |> await
    |> fun x -> x.Items.[0]
```

## For Visual Basic Developers
Using VkLibrary with Visual Basic is pretty much the same as using it with C#.

### Examples
As always, firstly we need to initialize the library.
```vb
Dim vk = new Vkontakte("12345", JsonParsingType.UseStream)
```
Then we can call library methods in a familiar way!
```vb
Dim result = Await vk.Friends.Get(userId := 12345, count := 10)
```
