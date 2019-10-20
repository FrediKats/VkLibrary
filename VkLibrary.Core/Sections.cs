using VkLibrary.Core.Auth;
using VkLibrary.Core.Methods;

namespace VkLibrary.Core
{
    public partial class Vkontakte
    {
        /// <summary>
        /// API part related to direct auth.
        /// </summary>
        public DirectAuth DirectAuth => new DirectAuth(this);

        /// <summary>
        /// API files upload helper. Contains upload methods.
        /// </summary>
        public UploadHelper UploadHelper => new UploadHelper(this);

        /// <summary>
        /// OAuth helpers API section.
        /// </summary>
        public OAuth OAuth => new OAuth(this);

        /// <summary>
        /// Account API section.
        /// </summary>
        public Account Account => new Account(this);

        /// <summary>
        /// Ads API section.
        /// </summary>
        public Ads Ads => new Ads(this);

        /// <summary>
        /// Apps API section.
        /// </summary>
        public Apps Apps => new Apps(this);

        /// <summary>
        /// Board API section.
        /// </summary>
        public Board Board => new Board(this);

        /// <summary>
        /// Database API section.
        /// </summary>
        public Database Database => new Database(this);

        /// <summary>
        /// Docs API section.
        /// </summary>
        public Docs Docs => new Docs(this);

        /// <summary>
        /// Fave API section.
        /// </summary>
        public Fave Fave => new Fave(this);

        /// <summary>
        /// Friends API section.
        /// </summary>
        public Friends Friends => new Friends(this);

        /// <summary>
        /// Gifts API section.
        /// </summary>
        public Gifts Gifts => new Gifts(this);

        /// <summary>
        /// Groups API section.
        /// </summary>
        public Groups Groups => new Groups(this);

        /// <summary>
        /// Leads API section.
        /// </summary>
        public Leads Leads => new Leads(this);

        /// <summary>
        /// Likes API section.
        /// </summary>
        public Likes Likes => new Likes(this);

        /// <summary>
        /// Market API section.
        /// </summary>
        public Market Market => new Market(this);

        /// <summary>
        /// Messages API section.
        /// </summary>
        public Messages Messages => new Messages(this);

        /// <summary>
        /// Newsfeed API section.
        /// </summary>
        public Newsfeed Newsfeed => new Newsfeed(this);

        /// <summary>
        /// Notes API section.
        /// </summary>
        public Notes Notes => new Notes(this);

        /// <summary>
        /// Notifications API section.
        /// </summary>
        public Notifications Notifications => new Notifications(this);

        /// <summary>
        /// Orders API section.
        /// </summary>
        public Orders Orders => new Orders(this);

        /// <summary>
        /// Pages API section.
        /// </summary>
        public Pages Pages => new Pages(this);

        /// <summary>
        /// Photos API section.
        /// </summary>
        public Photos Photos => new Photos(this);

        /// <summary>
        /// Polls API section.
        /// </summary>
        public Polls Polls => new Polls(this);

        /// <summary>
        /// Search API section.
        /// </summary>
        public Search Search => new Search(this);

        /// <summary>
        /// Secure API section.
        /// </summary>
        public Secure Secure => new Secure(this);

        /// <summary>
        /// Stats API section.
        /// </summary>
        public Stats Stats => new Stats(this);

        /// <summary>
        /// Status API section.
        /// </summary>
        public Status Status => new Status(this);

        /// <summary>
        /// Storage API section.
        /// </summary>
        public Storage Storage => new Storage(this);

        /// <summary>
        /// Users API section.
        /// </summary>
        public Users Users => new Users(this);

        /// <summary>
        /// Utils API section.
        /// </summary>
        public Utils Utils => new Utils(this);

        /// <summary>
        /// Video API section.
        /// </summary>
        public Video Video => new Video(this);

        /// <summary>
        /// Wall API section.
        /// </summary>
        public Wall Wall => new Wall(this);

        /// <summary>
        /// Widgets API section.
        /// </summary>
        public Widgets Widgets => new Widgets(this);
    }
}