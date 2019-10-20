using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Pages
    {
        private readonly Vkontakte _vkontakte;

        internal Pages(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Allows to clear the cache of particular 'external' pages which may be attached to VK posts.
        ///</summary>
        public Task<BaseOkResponse> ClearCache(String url = null)
        {
            var parameters = new Dictionary<string, string>();
            if (url != null)
                parameters.Add("url", url.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("pages.clearCache", parameters);
        }

        ///<summary>
        /// Returns information about a wiki page.
        ///</summary>
        public Task<PagesWikipageFull> Get(int? ownerId = null, int? pageId = null, Boolean? global = null, Boolean? sitePreview = null, String title = null, Boolean? needSource = null, Boolean? needHtml = null)
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
                parameters.Add("title", title.ToApiString());
            if (needSource != null)
                parameters.Add("need_source", needSource.ToApiString());
            if (needHtml != null)
                parameters.Add("need_html", needHtml.ToApiString());
            return _vkontakte.RequestAsync<PagesWikipageFull>("pages.get", parameters);
        }

        ///<summary>
        /// Returns a list of all previous versions of a wiki page.
        ///</summary>
        public Task<PagesWikipageHistory[]> GetHistory(int? pageId = null, int? groupId = null, int? userId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            return _vkontakte.RequestAsync<PagesWikipageHistory[]>("pages.getHistory", parameters);
        }

        ///<summary>
        /// Returns a list of wiki pages in a group.
        ///</summary>
        public Task<PagesWikipage[]> GetTitles(int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<PagesWikipage[]>("pages.getTitles", parameters);
        }

        ///<summary>
        /// Returns the text of one of the previous versions of a wiki page.
        ///</summary>
        public Task<PagesWikipageFull> GetVersion(int? versionId = null, int? groupId = null, int? userId = null, Boolean? needHtml = null)
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
            return _vkontakte.RequestAsync<PagesWikipageFull>("pages.getVersion", parameters);
        }

        ///<summary>
        /// Returns HTML representation of the wiki markup.
        ///</summary>
        public Task<String> ParseWiki(String text = null, int? groupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            return _vkontakte.RequestAsync<String>("pages.parseWiki", parameters);
        }

        ///<summary>
        /// Saves the text of a wiki page.
        ///</summary>
        public Task<int> Save(String text = null, int? pageId = null, int? groupId = null, int? userId = null, String title = null)
        {
            var parameters = new Dictionary<string, string>();
            if (text != null)
                parameters.Add("text", text.ToApiString());
            if (pageId != null)
                parameters.Add("page_id", pageId.ToApiString());
            if (groupId != null)
                parameters.Add("group_id", groupId.ToApiString());
            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (title != null)
                parameters.Add("title", title.ToApiString());
            return _vkontakte.RequestAsync<int>("pages.save", parameters);
        }

        ///<summary>
        /// Saves modified read and edit access settings for a wiki page.
        ///</summary>
        public Task<int> SaveAccess(int? pageId = null, int? groupId = null, int? userId = null, int? view = null, int? edit = null)
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
            return _vkontakte.RequestAsync<int>("pages.saveAccess", parameters);
        }
    }
}