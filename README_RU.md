<a href="https://docs.microsoft.com/en-us/dotnet/standard/net-standard"><img src="https://img.shields.io/badge/.NET%20Standard-1.1-green.svg"></a> <a href="https://www.nuget.org/packages/VkApi.Wrapper/"><img src="https://img.shields.io/nuget/v/VkApi.Wrapper.svg"></a> <a href="https://www.nuget.org/packages/VkApi.Wrapper/"><img src="https://img.shields.io/nuget/dt/VkApi.Wrapper.svg"></a> <a href="https://github.com/inredikawb/VkLibrary/issues"><img src="https://img.shields.io/github/issues/Worldbeater/VkLibrary.svg"></a> <a href="https://github.com/inredikawb/VkLibrary/blob/master/LICENSE.md"><img src="https://img.shields.io/github/license/inredikawb/VkLibrary.svg"></a>

# Установка

Библиотека может быть становлена с помощью NuGet Package Manager:

```powershell
Install-Package VkApi.Wrapper
```

Если вы нацелены на использование с .Net Core, используйте следующую команду:

```cmd
dotnet add package VkApi.Wrapper
```

# Вступление

Для запуска большинства API методом необходимо предоставить <b>access_token</b> (ключ доступа). Токен представляет из себя строку из чисел и латинских букв и может относится к пользователю, сообществу  или самому приложению. Есть несколько способов получить <b>access_token</b>, VkLibrary поддерживает <b>DirectAuth</b> и <b>OAuth</b>.

## Получение ID вашего приложения

Первое, что нужно сделать чтобы получить ID приложения и токен - зарегестрировать VK приложение. Перейдите в <a href="https://vk.com/apps?act=manage">мои приложения</a> и выберите "Создать приложение". После того, как вы создали приложение, вы сможете найти ID приложения и секретный код клиента в настройках вашего приложения. Для более детального разъяснения следует перейти <a href="https://vk.com/dev/manuals">сюда</a>.

## Инициализация библиотеки

Инициализируйте библиотеку используя <a href="https://vk.com/apps?act=manage">ID приложения</a>.

```csharp
var vk = new Vkontakte(1234567);
```

# Аунтификация с помощью OAuth

Как мы уже знаем, большинство методов требуют действительный токен доступа. Чтобы получить этот токен с помощью <b>OAuth</b>, предоставьте WebView-подобное управление пользователю, направьте его к странице аунтификации и обработайте будущие перенаправления. Больше информации можно найти <a href="http://vk.com/dev/auth_mobile">в официальной документации</a>.

Здесь предоставлена небольшая инструкция о том, как можно это сделать с помощью UWP. Предположим у нас есть XAML-объявленное WebView управление, названное <b>BrowserView</b>. Сперва мы конструируем OAuth url и запускаем его, используя более предпочтительные ScopeSettings. Во-вторых мы направляем наш WebView упавления на url, которое мы только что сконструировали:

```csharp
var url = vk.OAuth.GetAuthUrl(ScopeSettings.CanAccessMessages | ScopeSettings.CanAccessOffline, AuthDisplayType.Mobile);
BrowserView.Navigate(new Uri(url));
```

Затем мы подписываемся на навигацию WebView, запуская событие и пытаемся запарсить url WebView когда пользователь перенаправляется:

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

После этого VkLibrary будет подписывать все будущие запросы используя AccessToken, сохранённый в имениях AccessToken'а

# Аунтификация с помощью активного токена

Если вы желаете использовать уже активный токен для аунтификации пользователя, просто используйте метод <b>AccessToken.FromString</b>:

```csharp
vk.AccessToken = AccessToken.FromString(accessTokenString);
```

# Аунтификация с помощью Direct Auth

Если вы разрабатываете приложение, которое было <a href="https://vk.com/dev/auth_direct">одобрено</a> администрацией ВКонтакте, вы можете использовать расширения Direct Auth. Учтите, что в этом случае вам понадобится задать секретный код вашего приложения (также известно как <b>client_secret</b>). Проделайте следующее для авторизации пользователя и получения AccessToken'а:

```csharp
vk.AccessToken = await vk.DirectAuth.Login("login", "pass", ScopeSettings.CanAccessWhatever);
```

# Вызов API методов

Все API методы перечислены <a href="https://vk.com/dev/methods">здесь</a>.

Возврат списка друзей пользователя на данный момент, вызывая <a href="https://vk.com/dev/friends.get">friends.get</a> API метод:

```csharp
var friends = await vk.Friends.Get();
```

<b>(Мертво из-за изменения возвратного значения на userId и userIds)</b> Возврат последовательности пользователей ВКонтакте, чьё ID <b>210700286</b>, в именительном падеже:

```csharp
var users = await vk.Users.Get(
  userIds: new[] { "210700286" },    
  fields: new[] { "photo_50", "city", "verified" },
  nameCase: "Nom"
);
```

Возврат последних 10 сообщений из переписки с пользователем, чьё ID <b>12345</b>.

```csharp
var messages = await vk.Messages.GetHistory(userId: "12345", count: 10);
```

Отправление сообщение пользователю. Возвращает 1, если отправлено успешно, 0 в ином случае.

```csharp
var ok = await vk.Messages.Send(userId: "12345", message: "Hey! What's up?");
```

## Вызов RequestAsync<TResponse>

Если вы найдёте API метод, не поддерживаемый VKLibrary (Хоть это и маловероятно, это не исключено), используйте метод <b>GetAsync</b>.

```csharp
var friends = await vk.RequestAsync<ApiItemsResponse<UserFull>>(
  "friends.get", new Dictionary<string, string> {
    { "userId", "1234567" },
    { "count", "10" }
  }
);
```

Код предоставленный выше эквивалентен следующему:

```csharp
var friends = await vk.Friends.Get(userId: 1234567, count: 10);
```

# Выполнение скриптов

<a href="https://vk.com/dev/execute">API</a> предоставляет возможность выполнения кода на серверах ВКонтакте. Такой код должен быть написан на <a href="https://vk.com/dev/execute">VkScript'е</a>, языке, подобному ActionScript или JavaScript, и закончен утвержением <b>return %выражение%</b>.

Если мы отправляем запрос на выполнение такого типа:

```csharp
var script = "return [API.users.isAppUser(), API.friends.get()];";
var result = await vk.Execute<JToken>(script);
```

Сервер ответит похожим ответом:

```json
[1, { 
"count": 5,
"items": [12345678, 87654321, 12345679, 97654321, 01012345]
}]
```

# Загрузка файлов

VkLibrary имеет секцию поддержки, содержащую методы для <a href="https://vk.com/dev/upload_files">загрузки фотографий, видео, аудиозаписей и документов</a>. Данная секция названа <b>UploadHelper</b>. Вот примеры использования этих помощников.

## Пример загрузки документа

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

## Пример загрузки фотографий для сообщений

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

# Общий PostAsync<T>

Если здесь нет POST методов в UploadHelper, удовлетворяющих вашему вкусу, используйте общие: <b>PostAsync<T></b> или <b>PostMultipleAsync<T></b>.

Загрузка несколких фотографий на сервера ВКонтакте, используя метод PostMultipleAsync:

```csharp
var response = await vk.UploadHelper.PostMultipleAsync<PhotoUploadResponse>(new Uri(url), files);  
```

Загрузка документа на сервера ВКонтакте, используя метод PostAsync.

```csharp
var response = await vk.UploadHelper.PostAsync<DocUploadResponse>(new Uri(url), bytes, "file", fileName);
```

# Обработка Captcha

Если какое-либо действие (например отправка сообщения) выполнено слишком часто за короткий промежуток времени, API запрос может вернуть ошибку "Captcha needed". После этого пользователю потребуется ввести код, изображенный на картинке и отправить запрос снова, на этот раз с Captcha кодом в параметрах запроса. 

<b>Error code:</b> 14 

<b>Error text:</b> Captcha needed

<a href="https://vk.com/dev/captcha_error">Обратитесь к официальной документации для более детальной информации</a>

## Понимание обработки исключений

<b>VkLibrary</b> предоставляет способность обрабатывать ошибки, вызванные Captcha. Когда сервер ВКонтакте возвращает ошибку Captcha, VkLibrary кидает <a href="VkApi.Wrapper/ApiException.cs">ApiException</a>. ApiException содержит <a href="VkApi.Wrapper/ApiException.cs">ApiError</a>, объект, содержащий такие поля как <b>Code</b> и <b>ErrorMessage</b>. Так что, когда такой тип исколючения кинут, нам следует поймать его и проверить код <b>ApiError</b>. Если оно равно <b>14</b>, тогда нам потребуется обработать Captcha.

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

## Больше обработки Captcha..

Чтобы обработать такой вид исключения, нам следует вызвать метод библиотеки <b>SetCaptchaForNextRequest</b> и ей пропустить <b>CaptchaSid</b> и ответ пользователя <b>CaptchaKey</b>. Так что нам нужно написать что-то похожее на это:

```csharp
// Показать капчу пользователю и передать значение в 'captchaKey' 
vk.SetCaptchaForNextRequest(captchaSid, captchaKey);
vk.SomeRequest.PerformAgain();
```

# Работаем с LongPoll Сервером

Длинный запрос (Long Poll) - технология, позволяющая получение информации о новых событиях с помощью "Длинных запросов" (простите за тавтологию). Сервер получает запрос, но не отправляет ответ сразу после его получения, а только после того, как произойдёт какой-то событие (например получение нового сообщения) или пройдёт определённый период ожидания. Узнать больше о LongPoll серверах ВКонтакте вы можете на <a href="https://vk.com/dev/using_longpoll">странице документации</a>.

VkLibrary предоставляет простой основанный на событиях враппер для более простой работы с LongPoll серверами. Этот враппер назван <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs">LongPollClient</a> и расположен в <a href="VkApi.Wrapper/LongPolling/User">пространстве имён VkLibrary.Core.LongPolling</a>. Давайте же узнаем как это работает.

## Запуск Long Poll клиента

Сперва нам необходимо получить новые <a href="VkApi.Wrapper/Objects/Messages/MessagesLongpollParams.cs">параметры long poll сервера</a> из API. Затем нам нужно запустить <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs">long poll клиент</a> с которым мы будем работать.

```csharp
var longPollParams = await vk.Messages.GetLongPollServer();
var longPollClient = vk.StartLongPollClient(
  longPollParams.Server, // Server received on previous step
  longPollParams.Key,    // Secret session key
  longPollParams.Ts,     // Event number
);
```

## Работаем с событиями

Наш long poll клиент сейчас готов уведомить нас, когда произойдёт новое событие. Подписка на события довольно проста и знакома. Давайте подпишимся на <b>FriendOnlineEvent</b>, чтобы знать когда друг запускает приложения ВКонтакте:

```csharp
longPollClient.FriendOnlineEvent += (sender, args) => Console.WriteLine(
  $"Friend with id {args.Item1} is now online! He uses {args.Item2} platform."
);
```

Список всех доступных событий с описаниями может быть найден <a href="VkApi.Wrapper/LongPolling/User/UserLongPollClient.cs#L97-L197">здесь</a>.

## Остановка и избавление от клиента

Если нам больше не нужен long poll клиент, нам стоит остановить его.

```csharp
longPollClient.Stop();
```

# Расширенные сценарии

VkLibrary также позволяет дополнительные расширенные конструкторы, используя их, вы можете персонализировать почти всё.

```csharp
var api = new Vkontakte(
  appId: 1234567, 
  appSecret: "fb4f44tbuyh5k",
  apiVersion: "5.63",
  requestMethod: RequestMethod.Get,
  parseJson: ParseJson.FromString
);
```

Опция <b>ParseJson</b> определяет как библиотека должна парсить JSON'ы полученные от серверов ВКонтакте.

- <i>ParseJson.FromString</i>: загружает JSON в строку, логирует её с помощью стандартного логгера и только после этого десериализирует. Используйте это только для тестирования, из-за потенциальных проблем с высокой тратой памяти и потерей производительности;
- <i>ParseJson.FromStream</i>: Для минимизации затрат памяти и количества строк, выделеных в памяти. JSON.NET поддерживает десериализацию объектов напрямую из потока. Используйте эту опцию в прокашене для более высокой производительности.

<b>RequestMethod</b> определяет какой метод запроса следует использовать при отправке запроса API ВКонтакте. Опция GET в основном хороша для тестирования и дебаггинга, т.к. GET запросы легки на глазах и понятны.Но при отправке больших объектов серверам API ВКонтакте лучше используйте опцию POST, иначе вы получите ошибку "414 URL Too Long".

Могут быть случаи, когда вам захочется персонализировать стандартную HttpService имплементацию. Чтобы сделать это, просто имплементируйте интерфейс <b>IHttpService</b> и пустите свой новый класс в VkLibrary.Core с помощью расширенного конструктора. То же можно сдделать и со стандартным логгером, вам понадобится интерфейс <b>ILogger</b>. По-умолчанию имплементациями ILogger и IHttpService являются <b>DefaultLogger</b> and <b>DefaultHttpService</b> соответственно.

```csharp
class CustomLogger : ILogger { /* implementation */ }
class CustomHttpService : IHttpService { /* implementation */ }
var api = new Vkontakte(1234567, string.Empty, new CustomHttpService(), new CustomLogger());
```

# Другие .NET языки

## Для F# разработчиков

VkLibrary может так же быть использована <a href="http://fsharp.org/">на  языке F#</a>! Используйте <a href="https://github.com/rspeele/TaskBuilder.fs">TaskBuilder.fs</a> чтобы улучшить качество вашего кода.

```fsharp
task {
  use lib = new Vkontakte(1234567, "your_secret_code")
  let! friends = lib.Friends.Get()
  let! users = lib.Users.Get()
}
```

F# даёт нам способность создавать анонимные имплементации интерфейсов! Используя эту особенность, вы можете написать код так и инъектировать логгер по выбору в VkLibrary.Core:

```fsharp
let logger = { new ILogger with member __.Log o = printfn "%A" o }
use api = new Vkontakte(1234567, "your_secret_code", logger = logger)
```

## For Visual Basic Developers

Использование VkLibrary с Visual Basic практически индентично тому, если бы вы её использовали на C#.

```vb
Dim vk = new Vkontakte(12345, String.Empty)
Dim response = Await vk.Friends.Get(userId := 12345, count := 10)
```
