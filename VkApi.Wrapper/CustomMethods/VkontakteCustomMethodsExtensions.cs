using VkApi.Wrapper.CustomMethods;

namespace VkApi.Wrapper
{
    public partial class Vkontakte
    {
        public Store Store => new Store(this);
    }
}