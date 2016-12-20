using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Pages API section.
    /// </summary>
    public class Pages
    {
        private Vkontakte _vkontakte;

        internal Pages(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns information about a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.get">pages.get</see>
        /// </summary>
        /// <param name="owner_id">Page owner ID.</param>
        /// <param name="page_id">Wiki page ID.</param>
        /// <param name="global">'1' — to return information about a global wiki page</param>
        /// <param name="site_preview">'1' — resulting wiki page is a preview for the attached link</param>
        /// <param name="title">Wiki page title.</param>
        /// <param name="need_source"></param>
        /// <param name="need_html">'1' — to return the page as HTML;</param>
        public async Task<VkLib.Types.Pages.WikipageFull> Get(int? owner_id = null, int? page_id = null, bool? global = null, bool? site_preview = null, string title = null, bool? need_source = null, bool? need_html = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (page_id != null)
                parameters.Add("page_id", page_id.ToString());
            if (global != null)
                parameters.Add("global", global.ToString());
            if (site_preview != null)
                parameters.Add("site_preview", site_preview.ToString());
            if (title != null)
                parameters.Add("title", title);
            if (need_source != null)
                parameters.Add("need_source", need_source.ToString());
            if (need_html != null)
                parameters.Add("need_html", need_html.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Pages.WikipageFull>("pages.get", parameters);
        }

        /// <summary>
        /// Saves the text of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.save">pages.save</see>
        /// </summary>
        /// <param name="text">Text of the wiki page in wiki-format.</param>
        /// <param name="page_id">Wiki page ID. The 'title' parameter can be passed instead of 'pid'.</param>
        /// <param name="group_id">ID of the community that owns the wiki page.</param>
        /// <param name="user_id"></param>
        /// <param name="title">Wiki page title.</param>
        public async Task<int?> Save(string text = null, int? page_id = null, int? group_id = null, int? user_id = null, string title = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (page_id != null)
                parameters.Add("page_id", page_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (title != null)
                parameters.Add("title", title);

            return await _vkontakte.GetAsync<int?>("pages.save", parameters);
        }

        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.saveAccess">pages.saveAccess</see>
        /// </summary>
        /// <param name="page_id">Wiki page ID.</param>
        /// <param name="group_id">ID of the community that owns the wiki page.</param>
        /// <param name="user_id"></param>
        /// <param name="view">Who can view the wiki page:; '1' — only community members; '2' — all users can view the page; '0' — only community managers</param>
        /// <param name="edit">Who can edit the wiki page:; '1' — only community members; '2' — all users can edit the page; '0' — only community managers</param>
        public async Task<int?> SaveAccess(int? page_id = null, int? group_id = null, int? user_id = null, int? view = null, int? edit = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (page_id != null)
                parameters.Add("page_id", page_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (view != null)
                parameters.Add("view", view.ToString());
            if (edit != null)
                parameters.Add("edit", edit.ToString());

            return await _vkontakte.GetAsync<int?>("pages.saveAccess", parameters);
        }

        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.getHistory">pages.getHistory</see>
        /// </summary>
        /// <param name="page_id">Wiki page ID.</param>
        /// <param name="group_id">ID of the community that owns the wiki page.</param>
        /// <param name="user_id"></param>
        public async Task<IEnumerable<VkLib.Types.Pages.WikipageVersion>> GetHistory(int? page_id = null, int? group_id = null, int? user_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (page_id != null)
                parameters.Add("page_id", page_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Pages.WikipageVersion>>("pages.getHistory", parameters);
        }

        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// Docs: <see href="https://vk.com/dev/pages.getTitles">pages.getTitles</see>
        /// </summary>
        /// <param name="group_id">ID of the community that owns the wiki page.</param>
        public async Task<IEnumerable<VkLib.Types.Pages.Wikipage>> GetTitles(int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Pages.Wikipage>>("pages.getTitles", parameters);
        }

        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.getVersion">pages.getVersion</see>
        /// </summary>
        /// <param name="version_id"></param>
        /// <param name="group_id">ID of the community that owns the wiki page.</param>
        /// <param name="user_id"></param>
        /// <param name="need_html">'1' — to return the page as HTML</param>
        public async Task<VkLib.Types.Pages.WikipageFull> GetVersion(int? version_id = null, int? group_id = null, int? user_id = null, bool? need_html = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (version_id != null)
                parameters.Add("version_id", version_id.ToString());
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());
            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (need_html != null)
                parameters.Add("need_html", need_html.ToString());

            return await _vkontakte.GetAsync<VkLib.Types.Pages.WikipageFull>("pages.getVersion", parameters);
        }

        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// Docs: <see href="https://vk.com/dev/pages.parseWiki">pages.parseWiki</see>
        /// </summary>
        /// <param name="text">Text of the wiki page.</param>
        /// <param name="group_id">ID of the group in the context of which this markup is interpreted.;</param>
        public async Task<string> ParseWiki(string text = null, int? group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (group_id != null)
                parameters.Add("group_id", group_id.ToString());

            return await _vkontakte.GetAsync<string>("pages.parseWiki", parameters);
        }

        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// Docs: <see href="https://vk.com/dev/pages.clearCache">pages.clearCache</see>
        /// </summary>
        /// <param name="url">Address of the page where you need to refesh the cached version</param>
        public async Task<int> ClearCache(string url = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (url != null)
                parameters.Add("url", url);

            return await _vkontakte.GetAsync<int>("pages.clearCache", parameters);
        }

    }
}
