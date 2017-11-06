using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Pages;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Pages API section.
    /// </summary>
    public class Pages
    {
        private readonly Vkontakte _vkontakte;
        internal Pages(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns information about a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.get">pages.get</see>
        /// </summary>
        /// <param name="ownerId">Page owner ID.</param>
        /// <param name="pageId">Wiki page ID.</param>
        /// <param name="global">'1' — to return information about a global wiki page</param>
        /// <param name="sitePreview">'1' — resulting wiki page is a preview for the attached link</param>
        /// <param name="title">Wiki page title.</param>
        /// <param name="needSource"></param>
        /// <param name="needHtml">'1' — to return the page as HTML;</param>
        public Task<WikipageFull> Get(int? ownerId = null, int? pageId = null, bool? global = null,
            bool? sitePreview = null, string title = null, bool? needSource = null, bool? needHtml = null)
        {
            var parameters = new Dictionary<string, string>();

            if (ownerId != null)
                parameters.Add("owner_id", ownerId.ToApiString());
            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (global != null)
                parameters.Add("global", global.ToApiString());
            if (sitePreview != null)
                parameters.Add("site_preview", sitePreview.ToApiString());
            if (title != null)
                parameters.Add("title", title);
            if (needSource != null)
                parameters.Add("need_source", needSource.ToApiString());
            if (needHtml != null)
                parameters.Add("need_html", needHtml.ToApiString());

            return _vkontakte.RequestAsync<WikipageFull>("pages.get", parameters);
        }

        /// <summary>
        /// Saves the text of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.save">pages.save</see>
        /// </summary>
        /// <param name="text">Text of the wiki page in wiki-format.</param>
        /// <param name="pageId">Wiki page ID. The 'title' parameter can be passed instead of 'pid'.</param>
        /// <param name="groupId">ID of the community that owns the wiki page.</param>
        /// <param name="userId"></param>
        /// <param name="title">Wiki page title.</param>
        public Task<int?> Save(string text = null, int? pageId = null, int? groupId = null, int? userId = null,
            string title = null)
        {
            var parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (title != null)
                parameters.Add("title", title);

            return _vkontakte.RequestAsync<int?>("pages.save", parameters);
        }

        /// <summary>
        /// Saves modified read and edit access settings for a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.saveAccess">pages.saveAccess</see>
        /// </summary>
        /// <param name="pageId">Wiki page ID.</param>
        /// <param name="groupId">ID of the community that owns the wiki page.</param>
        /// <param name="userId"></param>
        /// <param name="view">
        /// Who can view the wiki page:; '1' — only community members; '2' — all users can view the page; '0' —
        /// only community managers
        /// </param>
        /// <param name="edit">
        /// Who can edit the wiki page:; '1' — only community members; '2' — all users can edit the page; '0' —
        /// only community managers
        /// </param>
        public Task<int?> SaveAccess(int? pageId = null, int? groupId = null, int? userId = null,
            int? view = null, int? edit = null)
        {
            var parameters = new Dictionary<string, string>();

            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (view != null)
                parameters.Add("view", view.ToApiString());
            if (edit != null)
                parameters.Add("edit", edit.ToApiString());

            return _vkontakte.RequestAsync<int?>("pages.saveAccess", parameters);
        }

        /// <summary>
        /// Returns a list of all previous versions of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.getHistory">pages.getHistory</see>
        /// </summary>
        /// <param name="pageId">Wiki page ID.</param>
        /// <param name="groupId">ID of the community that owns the wiki page.</param>
        /// <param name="userId"></param>
        public Task<IEnumerable<WikipageVersion>> GetHistory(int? pageId = null, int? groupId = null,
            int? userId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<WikipageVersion>>("pages.getHistory", parameters);
        }

        /// <summary>
        /// Returns a list of wiki pages in a group.
        /// Docs: <see href="https://vk.com/dev/pages.getTitles">pages.getTitles</see>
        /// </summary>
        /// <param name="groupId">ID of the community that owns the wiki page.</param>
        public Task<IEnumerable<Wikipage>> GetTitles(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<Wikipage>>("pages.getTitles", parameters);
        }

        /// <summary>
        /// Returns the text of one of the previous versions of a wiki page.
        /// Docs: <see href="https://vk.com/dev/pages.getVersion">pages.getVersion</see>
        /// </summary>
        /// <param name="versionId"></param>
        /// <param name="groupId">ID of the community that owns the wiki page.</param>
        /// <param name="userId"></param>
        /// <param name="needHtml">'1' — to return the page as HTML</param>
        public Task<WikipageFull> GetVersion(int? versionId = null, int? groupId = null, int? userId = null,
            bool? needHtml = null)
        {
            var parameters = new Dictionary<string, string>();

            if (versionId != null)
                parameters.Add("version_id", versionId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (needHtml != null)
                parameters.Add("need_html", needHtml.ToApiString());

            return _vkontakte.RequestAsync<WikipageFull>("pages.getVersion", parameters);
        }

        /// <summary>
        /// Returns HTML representation of the wiki markup.
        /// Docs: <see href="https://vk.com/dev/pages.parseWiki">pages.parseWiki</see>
        /// </summary>
        /// <param name="text">Text of the wiki page.</param>
        /// <param name="groupId">ID of the group in the context of which this markup is interpreted.;</param>
        public Task<string> ParseWiki(string text = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (text != null)
                parameters.Add("text", text);
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());

            return _vkontakte.RequestAsync<string>("pages.parseWiki", parameters);
        }

        /// <summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        /// Docs: <see href="https://vk.com/dev/pages.clearCache">pages.clearCache</see>
        /// </summary>
        /// <param name="url">Address of the page where you need to refesh the cached version</param>
        public Task<int> ClearCache(string url = null)
        {
            var parameters = new Dictionary<string, string>();

            if (url != null)
                parameters.Add("url", url);

            return _vkontakte.RequestAsync<int>("pages.clearCache", parameters);
        }
    }
}