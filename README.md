# VkLibrary
.NET library that tries to cover all <a href="https://vk.com/dev">VKCOM API methods</a>. Huge parts of it were generated using <a href="https://github.com/VKCOM/vk-api-schema">Json Schema</a> and <a href="https://github.com/Worldbeater/VkLibrary/blob/master/parser.py">parser.py</a>. Some features are not currently working and library may contain tons of bugs, but work is in progress.

### Initializing
Firstly, initialize the library. Use your vk app's ID and Secret code.
```c#
Vkontakte vk = new Vkontakte(
    appId: "1234567",                 
    clientSecret: "Hfsbdjw364hbjf2",  
    apiVersion: "5.60"                
  );
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

### Authentication
Work in progress, come back later!

### Roadmap
- Add OAuth support
- Add methods for video/audio/photo uploading
- Add vk script support
- Try to fix bugs
