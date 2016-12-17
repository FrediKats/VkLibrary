using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Ads API section.
    /// </summary>
    public class Ads
    {
        private Vkontakte _vkontakte;

        internal Ads(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of advertising accounts.
        /// Docs: <see href="https://vk.com/dev/ads.getAccounts">ads.getAccounts</see>
        /// </summary>
        public async Task<object> GetAccounts()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<object>("ads.getAccounts", parameters);
        }

        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// Docs: <see href="https://vk.com/dev/ads.getClients">ads.getClients</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        public async Task<object> GetClients(int? account_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.getClients", parameters);
        }

        /// <summary>
        /// Creates clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.createClients">ads.createClients</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe created campaigns. Description of 'client_specification' objects see below.</param>
        public async Task<object> CreateClients(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.createClients", parameters);
        }

        /// <summary>
        /// Edits clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.updateClients">ads.updateClients</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe changes in clients. Description of 'client_mod' objects see below.</param>
        public async Task<object> UpdateClients(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.updateClients", parameters);
        }

        /// <summary>
        /// Archives clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.deleteClients">ads.deleteClients</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted clients.</param>
        public async Task<object> DeleteClients(int? account_id = null, string ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids != null)
                parameters.Add("ids", ids);

            return await _vkontakte.GetAsync<object>("ads.deleteClients", parameters);
        }

        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getCampaigns">ads.getCampaigns</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'For advertising agencies'. ID of the client advertising campaigns are retrieved from.</param>
        /// <param name="include_deleted">Flag that specifies whether archived ads shall be shown.; *0 — show only active campaigns;; *1 — show all campaigns.;</param>
        /// <param name="campaign_ids">Filter of advertising campaigns to show. ; Serialized JSON array with campaign IDs. Only campaigns that exist in 'campaign_ids' and belong to the specified advertising account will be shown. If the parameter is null, all campaigns will be shown.;</param>
        public async Task<object> GetCampaigns(int? account_id = null, int? client_id = null, bool? include_deleted = null, string campaign_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (include_deleted != null)
                parameters.Add("include_deleted", include_deleted.ToString());
            if (campaign_ids != null)
                parameters.Add("campaign_ids", campaign_ids);

            return await _vkontakte.GetAsync<object>("ads.getCampaigns", parameters);
        }

        /// <summary>
        /// Creates advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.createCampaigns">ads.createCampaigns</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe created campaigns. Description of 'campaign_specification' objects see below.</param>
        public async Task<object> CreateCampaigns(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.createCampaigns", parameters);
        }

        /// <summary>
        /// Edits advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.updateCampaigns">ads.updateCampaigns</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe changes in campaigns. Description of 'campaign_mod' objects see below.</param>
        public async Task<object> UpdateCampaigns(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.updateCampaigns", parameters);
        }

        /// <summary>
        /// Archives advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.deleteCampaigns">ads.deleteCampaigns</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted campaigns.</param>
        public async Task<object> DeleteCampaigns(int? account_id = null, string ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids != null)
                parameters.Add("ids", ids);

            return await _vkontakte.GetAsync<object>("ads.deleteCampaigns", parameters);
        }

        /// <summary>
        /// Returns number of ads.
        /// Docs: <see href="https://vk.com/dev/ads.getAds">ads.getAds</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Available and required for advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="include_deleted">Flag that specifies whether archived ads shall be shown:; *0 — show only active ads;; *1 — show all ads.;</param>
        /// <param name="campaign_ids">Filter by advertising campaigns. ; Serialized JSON array with campaign IDs. If the parameter is null, ads of all campaigns will be shown.;</param>
        /// <param name="ad_ids">Filter by ads. ; Serialized JSON array with ad IDs. If the parameter is null, all ads will be shown.;</param>
        /// <param name="limit">Limit of number of returned ads. Used only if ad_ids parameter is null, and 'campaign_ids' parameter contains ID of only one campaign.</param>
        /// <param name="offset">Offset. Used in the same cases as 'limit' parameter.</param>
        public async Task<object> GetAds(int? account_id = null, int? client_id = null, bool? include_deleted = null, string campaign_ids = null, string ad_ids = null, int? limit = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (include_deleted != null)
                parameters.Add("include_deleted", include_deleted.ToString());
            if (campaign_ids != null)
                parameters.Add("campaign_ids", campaign_ids);
            if (ad_ids != null)
                parameters.Add("ad_ids", ad_ids);
            if (limit != null)
                parameters.Add("limit", limit.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());

            return await _vkontakte.GetAsync<object>("ads.getAds", parameters);
        }

        /// <summary>
        /// Returns descriptions of ad layouts.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsLayout">ads.getAdsLayout</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'For advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="include_deleted">Flag that specifies whether archived ads shall be shown.; *0 — show only active ads;; *1 — show all ads.;</param>
        /// <param name="campaign_ids">Filter by advertising campaigns.; Serialized JSON array with campaign IDs. If the parameter is null, ads of all campaigns will be shown.;</param>
        /// <param name="ad_ids">Filter by ads.; Serialized JSON array with ad IDs. If the parameter is null, all ads will be shown.;</param>
        /// <param name="limit">Limit of number of returned ads. Used only if 'ad_ids' parameter is null, and 'campaign_ids' parameter contains ID of only one campaign.</param>
        /// <param name="offset">Offset. Used in the same cases as 'limit' parameter.</param>
        public async Task<object> GetAdsLayout(int? account_id = null, int? client_id = null, bool? include_deleted = null, string campaign_ids = null, string ad_ids = null, int? limit = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (include_deleted != null)
                parameters.Add("include_deleted", include_deleted.ToString());
            if (campaign_ids != null)
                parameters.Add("campaign_ids", campaign_ids);
            if (ad_ids != null)
                parameters.Add("ad_ids", ad_ids);
            if (limit != null)
                parameters.Add("limit", limit.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());

            return await _vkontakte.GetAsync<object>("ads.getAdsLayout", parameters);
        }

        /// <summary>
        /// Returns ad targeting parameters.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsTargeting">ads.getAdsTargeting</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'For advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="include_deleted">flag that specifies whether archived ads shall be shown:; *0 — show only active ads;; *1 — show all ads.</param>
        /// <param name="campaign_ids">Filter by advertising campaigns.; Serialized JSON array with campaign IDs. If the parameter is null, ads of all campaigns will be shown.;</param>
        /// <param name="ad_ids">Filter by ads.; Serialized JSON array with ad IDs. If the parameter is null, all ads will be shown.</param>
        /// <param name="limit">Limit of number of returned ads. Used only if 'ad_ids' parameter is null, and 'campaign_ids' parameter contains ID of only one campaign.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public async Task<object> GetAdsTargeting(int? account_id = null, int? client_id = null, bool? include_deleted = null, string campaign_ids = null, string ad_ids = null, int? limit = null, int? offset = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (include_deleted != null)
                parameters.Add("include_deleted", include_deleted.ToString());
            if (campaign_ids != null)
                parameters.Add("campaign_ids", campaign_ids);
            if (ad_ids != null)
                parameters.Add("ad_ids", ad_ids);
            if (limit != null)
                parameters.Add("limit", limit.ToString());
            if (offset != null)
                parameters.Add("offset", offset.ToString());

            return await _vkontakte.GetAsync<object>("ads.getAdsTargeting", parameters);
        }

        /// <summary>
        /// Creates ads.
        /// Docs: <see href="https://vk.com/dev/ads.createAds">ads.createAds</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe created ads. Description of 'ad_specification' objects see below.</param>
        public async Task<object> CreateAds(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.createAds", parameters);
        }

        /// <summary>
        /// Edits ads.
        /// Docs: <see href="https://vk.com/dev/ads.updateAds">ads.updateAds</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe changes in ads. Description of 'ad_edit_specification' objects see below.</param>
        public async Task<object> UpdateAds(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.updateAds", parameters);
        }

        /// <summary>
        /// Archives ads.
        /// Docs: <see href="https://vk.com/dev/ads.deleteAds">ads.deleteAds</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with ad IDs.</param>
        public async Task<object> DeleteAds(int? account_id = null, string ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids != null)
                parameters.Add("ids", ids);

            return await _vkontakte.GetAsync<object>("ads.deleteAds", parameters);
        }

        /// <summary>
        /// Allows to check the ad link.
        /// Docs: <see href="https://vk.com/dev/ads.checkLink">ads.checkLink</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="link_type">Object type:; *'community' — community;; *'post' — community post;; *'application' — VK application;; *'video' — video;; *'site' — external site.</param>
        /// <param name="link_url">Object URL.</param>
        /// <param name="campaign_id">Campaign ID</param>
        public async Task<object> CheckLink(int? account_id = null, string link_type = null, string link_url = null, int? campaign_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (link_type != null)
                parameters.Add("link_type", link_type);
            if (link_url != null)
                parameters.Add("link_url", link_url);
            if (campaign_id != null)
                parameters.Add("campaign_id", campaign_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.checkLink", parameters);
        }

        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// Docs: <see href="https://vk.com/dev/ads.getStatistics">ads.getStatistics</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids_type">Type of requested objects listed in 'ids' parameter:; *ad — ads;; *campaign — campaigns;; *client — clients;; *office — account.;</param>
        /// <param name="ids">IDs requested ads, campaigns, clients or account, separated with a comma, depending on the value set in 'ids_type'. Maximum 2000 objects.</param>
        /// <param name="period">Data grouping by dates:; *day — statistics by days;; *month — statistics by months;; *overall — overall statistics.; 'date_from' and 'date_to' parameters set temporary limits.</param>
        /// <param name="date_from">Date to show statistics from. For different value of 'period' different date format is used:; *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — day it was created on;; *month: YYYY-MM, example: 2011-09 — September 2011; **0 — month it was created in;; *overall: 0.;</param>
        /// <param name="date_to">Date to show statistics to. For different value of 'period' different date format is used:; *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — current day;; *month: YYYY-MM, example: 2011-09 — September 2011; **0 — current month;; *overall: 0.</param>
        public async Task<object> GetStatistics(int? account_id = null, string ids_type = null, string ids = null, string period = null, string date_from = null, string date_to = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids_type != null)
                parameters.Add("ids_type", ids_type);
            if (ids != null)
                parameters.Add("ids", ids);
            if (period != null)
                parameters.Add("period", period);
            if (date_from != null)
                parameters.Add("date_from", date_from);
            if (date_to != null)
                parameters.Add("date_to", date_to);

            return await _vkontakte.GetAsync<object>("ads.getStatistics", parameters);
        }

        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.getDemographics">ads.getDemographics</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids_type">Type of requested objects listed in 'ids' parameter:; *ad — ads;; *campaign — campaigns.;</param>
        /// <param name="ids">IDs requested ads or campaigns, separated with a comma, depending on the value set in 'ids_type'. Maximum 2000 objects.</param>
        /// <param name="period">Data grouping by dates:; *day — statistics by days;; *month — statistics by months;; *overall — overall statistics.; 'date_from' and 'date_to' parameters set temporary limits.</param>
        /// <param name="date_from">Date to show statistics from. For different value of 'period' different date format is used:; *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — day it was created on;; *month: YYYY-MM, example: 2011-09 — September 2011; **0 — month it was created in;; *overall: 0.</param>
        /// <param name="date_to">Date to show statistics to. For different value of 'period' different date format is used:; *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — current day;; *month: YYYY-MM, example: 2011-09 — September 2011; **0 — current month;; *overall: 0.</param>
        public async Task<object> GetDemographics(int? account_id = null, string ids_type = null, string ids = null, string period = null, string date_from = null, string date_to = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids_type != null)
                parameters.Add("ids_type", ids_type);
            if (ids != null)
                parameters.Add("ids", ids);
            if (period != null)
                parameters.Add("period", period);
            if (date_from != null)
                parameters.Add("date_from", date_from);
            if (date_to != null)
                parameters.Add("date_to", date_to);

            return await _vkontakte.GetAsync<object>("ads.getDemographics", parameters);
        }

        /// <summary>
        /// Allows to get detailed information about the ad post reach.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsPostsReach">ads.getAdsPostsReach</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ads_ids">Ads IDS separated by comma.</param>
        public async Task<object> GetAdsPostsReach(int? account_id = null, string ads_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ads_ids != null)
                parameters.Add("ads_ids", ads_ids);

            return await _vkontakte.GetAsync<object>("ads.getAdsPostsReach", parameters);
        }

        /// <summary>
        /// Returns current budget of the advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getBudget">ads.getBudget</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        public async Task<object> GetBudget(int? account_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.getBudget", parameters);
        }

        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getOfficeUsers">ads.getOfficeUsers</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        public async Task<object> GetOfficeUsers(int? account_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.getOfficeUsers", parameters);
        }

        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.addOfficeUsers">ads.addOfficeUsers</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="data">Serialized JSON array of objects that describe added managers. Description of 'user_specification' objects see below.</param>
        public async Task<object> AddOfficeUsers(int? account_id = null, string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<object>("ads.addOfficeUsers", parameters);
        }

        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.removeOfficeUsers">ads.removeOfficeUsers</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted managers.</param>
        public async Task<object> RemoveOfficeUsers(int? account_id = null, string ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ids != null)
                parameters.Add("ids", ids);

            return await _vkontakte.GetAsync<object>("ads.removeOfficeUsers", parameters);
        }

        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// Docs: <see href="https://vk.com/dev/ads.getTargetingStats">ads.getTargetingStats</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="criteria">Serialized JSON object that describes targeting parameters. Description of 'criteria' object see below.</param>
        /// <param name="ad_id">ID of an ad which targeting parameters shall be analyzed.</param>
        /// <param name="ad_format">Ad format. Possible values:; *'1' — image and text;; *'2' — big image;; *'3' — exclusive format;; *'4' — community, square image;; *'7' — special app format;; *'8' — special community format;; *'9' — post in community;; *'10' — app board.</param>
        /// <param name="ad_platform">Platforms to use for ad showing. Possible values:; (for 'ad_format' = '1'); *'0' — VK and partner sites;; *'1' — VK only.; (for 'ad_format' = '9'); *'all' — all platforms;; *'desktop' — desktop version;; *'mobile' — mobile version and apps.</param>
        /// <param name="link_url">URL for the advertised object.</param>
        /// <param name="link_domain">Domain of the advertised object.</param>
        public async Task<object> GetTargetingStats(int? account_id = null, string criteria = null, int? ad_id = null, int? ad_format = null, string ad_platform = null, string link_url = null, string link_domain = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (criteria != null)
                parameters.Add("criteria", criteria);
            if (ad_id != null)
                parameters.Add("ad_id", ad_id.ToString());
            if (ad_format != null)
                parameters.Add("ad_format", ad_format.ToString());
            if (ad_platform != null)
                parameters.Add("ad_platform", ad_platform);
            if (link_url != null)
                parameters.Add("link_url", link_url);
            if (link_domain != null)
                parameters.Add("link_domain", link_domain);

            return await _vkontakte.GetAsync<object>("ads.getTargetingStats", parameters);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// Docs: <see href="https://vk.com/dev/ads.getSuggestions">ads.getSuggestions</see>
        /// </summary>
        /// <param name="section">Section, suggestions are retrieved in. Available values:; *countries — request of a list of countries. If q is not set or blank, a short list of countries is shown. Otherwise, a full list of countries is shown.; *regions — requested list of regions. 'country' parameter is required.; *cities — requested list of cities. 'country' parameter is required.; *districts — requested list of districts. 'cities' parameter is required.; *stations — requested list of subway stations. 'cities' parameter is required.; *streets — requested list of streets. 'cities' parameter is required.; *schools — requested list of educational organizations. 'cities' parameter is required.; *interests — requested list of interests.; *positions — requested list of positions (professions).; *group_types — requested list of group types.; *religions — requested list of religious commitments.; *browsers — requested list of browsers and mobile devices.;</param>
        /// <param name="ids">Objects IDs separated by commas. If the parameter is passed, 'q, country, cities' should not be passed.</param>
        /// <param name="q">Filter-line of the request (for countries, regions, cities, streets, schools, interests, positions).</param>
        /// <param name="country">ID of the country objects are searched in.</param>
        /// <param name="cities">IDs of cities where objects are searched in, separated with a comma.</param>
        /// <param name="lang">Language of the returned string values. Supported languages:; *ru — Russian;; *ua — Ukrainian;; *en — English.;</param>
        public async Task<object> GetSuggestions(string section = null, string ids = null, string q = null, int? country = null, string cities = null, string lang = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (section != null)
                parameters.Add("section", section);
            if (ids != null)
                parameters.Add("ids", ids);
            if (q != null)
                parameters.Add("q", q);
            if (country != null)
                parameters.Add("country", country.ToString());
            if (cities != null)
                parameters.Add("cities", cities);
            if (lang != null)
                parameters.Add("lang", lang);

            return await _vkontakte.GetAsync<object>("ads.getSuggestions", parameters);
        }

        /// <summary>
        /// Returns a list of possible ad categories.
        /// Docs: <see href="https://vk.com/dev/ads.getCategories">ads.getCategories</see>
        /// </summary>
        /// <param name="lang">Language. The full list of supported languages is [vk.com/dev/api_requests|here].</param>
        public async Task<object> GetCategories(string lang = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (lang != null)
                parameters.Add("lang", lang);

            return await _vkontakte.GetAsync<object>("ads.getCategories", parameters);
        }

        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// Docs: <see href="https://vk.com/dev/ads.getUploadURL">ads.getUploadURL</see>
        /// </summary>
        /// <param name="ad_format">Ad format:; *1 — image and text;; *2 — big image;; *3 — exclusive format;; *4 — community, square image;; *7 — special app format.</param>
        public async Task<object> GetUploadURL(int? ad_format = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (ad_format != null)
                parameters.Add("ad_format", ad_format.ToString());

            return await _vkontakte.GetAsync<object>("ads.getUploadURL", parameters);
        }

        /// <summary>
        /// Returns URL to upload an ad video to.
        /// Docs: <see href="https://vk.com/dev/ads.getVideoUploadURL">ads.getVideoUploadURL</see>
        /// </summary>
        public async Task<object> GetVideoUploadURL()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            return await _vkontakte.GetAsync<object>("ads.getVideoUploadURL", parameters);
        }

        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        /// Docs: <see href="https://vk.com/dev/ads.getFloodStats">ads.getFloodStats</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        public async Task<object> GetFloodStats(int? account_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.getFloodStats", parameters);
        }

        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// Docs: <see href="https://vk.com/dev/ads.getRejectionReason">ads.getRejectionReason</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="ad_id">Ad ID.</param>
        public async Task<object> GetRejectionReason(int? account_id = null, int? ad_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (ad_id != null)
                parameters.Add("ad_id", ad_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.getRejectionReason", parameters);
        }

        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        /// Docs: <see href="https://vk.com/dev/ads.createTargetGroup">ads.createTargetGroup</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Only for advertising agencies.'; ID of the client with the advertising account where the group will be created.;</param>
        /// <param name="name">Name of the target group — a string up to 64 characters long.</param>
        /// <param name="domain">Domain of the site where user accounting code will be placed.</param>
        /// <param name="lifetime">'For groups with auditory created with pixel code only.'; ; Number of days after that users will be automatically removed from the group. '0' — not to remove users.;</param>
        public async Task<object> CreateTargetGroup(int? account_id = null, int? client_id = null, string name = null, string domain = null, int? lifetime = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (name != null)
                parameters.Add("name", name);
            if (domain != null)
                parameters.Add("domain", domain);
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToString());

            return await _vkontakte.GetAsync<object>("ads.createTargetGroup", parameters);
        }

        /// <summary>
        /// Edits a retarget group.
        /// Docs: <see href="https://vk.com/dev/ads.updateTargetGroup">ads.updateTargetGroup</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Only for advertising agencies.' ; ID of the client with the advertising account where the group will be created.;</param>
        /// <param name="target_group_id">Group ID.</param>
        /// <param name="name">New name of the target group — a string up to 64 characters long.</param>
        /// <param name="domain">Domain of the site where user accounting code will be placed.</param>
        /// <param name="lifetime">'Only for the groups that get audience from sites with user accounting code.'; Time in days when users added to a retarget group will be automatically excluded from it. ; '0' – automatic exclusion is off.</param>
        public async Task<object> UpdateTargetGroup(int? account_id = null, int? client_id = null, int? target_group_id = null, string name = null, string domain = null, int? lifetime = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (target_group_id != null)
                parameters.Add("target_group_id", target_group_id.ToString());
            if (name != null)
                parameters.Add("name", name);
            if (domain != null)
                parameters.Add("domain", domain);
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToString());

            return await _vkontakte.GetAsync<object>("ads.updateTargetGroup", parameters);
        }

        /// <summary>
        /// Deletes a retarget group.
        /// Docs: <see href="https://vk.com/dev/ads.deleteTargetGroup">ads.deleteTargetGroup</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Only for advertising agencies.' ; ID of the client with the advertising account where the group will be created.;</param>
        /// <param name="target_group_id">Group ID.</param>
        public async Task<object> DeleteTargetGroup(int? account_id = null, int? client_id = null, int? target_group_id = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (target_group_id != null)
                parameters.Add("target_group_id", target_group_id.ToString());

            return await _vkontakte.GetAsync<object>("ads.deleteTargetGroup", parameters);
        }

        /// <summary>
        /// Returns a list of target groups.
        /// Docs: <see href="https://vk.com/dev/ads.getTargetGroups">ads.getTargetGroups</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Only for advertising agencies.'; ID of the client with the advertising account where the group will be created.;</param>
        /// <param name="extended">'1' — to return pixel code.</param>
        public async Task<object> GetTargetGroups(int? account_id = null, int? client_id = null, bool? extended = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (extended != null)
                parameters.Add("extended", extended.ToString());

            return await _vkontakte.GetAsync<object>("ads.getTargetGroups", parameters);
        }

        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// Docs: <see href="https://vk.com/dev/ads.importTargetContacts">ads.importTargetContacts</see>
        /// </summary>
        /// <param name="account_id">Advertising account ID.</param>
        /// <param name="client_id">'Only for advertising agencies.' ; ID of the client with the advertising account where the group will be created.;</param>
        /// <param name="target_group_id">Target group ID.</param>
        /// <param name="contacts">List of phone numbers, emails or user IDs separated with a comma.</param>
        public async Task<object> ImportTargetContacts(int? account_id = null, int? client_id = null, int? target_group_id = null, string contacts = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (account_id != null)
                parameters.Add("account_id", account_id.ToString());
            if (client_id != null)
                parameters.Add("client_id", client_id.ToString());
            if (target_group_id != null)
                parameters.Add("target_group_id", target_group_id.ToString());
            if (contacts != null)
                parameters.Add("contacts", contacts);

            return await _vkontakte.GetAsync<object>("ads.importTargetContacts", parameters);
        }

    }
}
