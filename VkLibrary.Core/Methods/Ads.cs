using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Responses.Ads;
using VkLibrary.Core.Types.Ads;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Ads API section.
    /// </summary>
    public class Ads
    {
        private readonly Vkontakte _vkontakte;
        internal Ads(Vkontakte vkontakte) => _vkontakte = vkontakte;

        /// <summary>
        /// Returns a list of advertising accounts.
        /// Docs: <see href="https://vk.com/dev/ads.getAccounts">ads.getAccounts</see>
        /// </summary>
        public Task<IEnumerable<Types.Ads.Account>> GetAccounts()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<IEnumerable<Types.Ads.Account>>("ads.getAccounts", parameters);
        }

        /// <summary>
        /// Returns a list of advertising agency's clients.
        /// Docs: <see href="https://vk.com/dev/ads.getClients">ads.getClients</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        public Task<IEnumerable<Client>> GetClients(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<Client>>("ads.getClients", parameters);
        }

        /// <summary>
        /// Creates clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.createClients">ads.createClients</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe created campaigns. Description of
        /// 'client_specification' objects see below.
        /// </param>
        public Task<IEnumerable<int?>> CreateClients(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<IEnumerable<int?>>("ads.createClients", parameters);
        }

        /// <summary>
        /// Edits clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.updateClients">ads.updateClients</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe changes in clients. Description of 'client_mod'
        /// objects see below.
        /// </param>
        public Task<int?> UpdateClients(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<int?>("ads.updateClients", parameters);
        }

        /// <summary>
        /// Archives clients of an advertising agency.
        /// Docs: <see href="https://vk.com/dev/ads.deleteClients">ads.deleteClients</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted clients.</param>
        public Task<int?> DeleteClients(int? accountId = null, string ids = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids);

            return _vkontakte.RequestAsync<int?>("ads.deleteClients", parameters);
        }

        /// <summary>
        /// Returns a list of campaigns in an advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getCampaigns">ads.getCampaigns</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">'For advertising agencies'. ID of the client advertising campaigns are retrieved from.</param>
        /// <param name="includeDeleted">
        /// Flag that specifies whether archived ads shall be shown.; *0 — show only active
        /// campaigns;; *1 — show all campaigns.;
        /// </param>
        /// <param name="campaignIds">
        /// Filter of advertising campaigns to show. ; Serialized JSON array with campaign IDs. Only
        /// campaigns that exist in 'campaign_ids' and belong to the specified advertising account will be shown. If the
        /// parameter is null, all campaigns will be shown.;
        /// </param>
        public Task<IEnumerable<Campaign>> GetCampaigns(int? accountId = null, int? clientId = null,
            bool? includeDeleted = null, string campaignIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds);

            return _vkontakte.RequestAsync<IEnumerable<Campaign>>("ads.getCampaigns", parameters);
        }

        /// <summary>
        /// Creates advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.createCampaigns">ads.createCampaigns</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe created campaigns. Description of
        /// 'campaign_specification' objects see below.
        /// </param>
        public Task<IEnumerable<int?>> CreateCampaigns(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<IEnumerable<int?>>("ads.createCampaigns", parameters);
        }

        /// <summary>
        /// Edits advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.updateCampaigns">ads.updateCampaigns</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe changes in campaigns. Description of 'campaign_mod'
        /// objects see below.
        /// </param>
        public Task<int?> UpdateCampaigns(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<int?>("ads.updateCampaigns", parameters);
        }

        /// <summary>
        /// Archives advertising campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.deleteCampaigns">ads.deleteCampaigns</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted campaigns.</param>
        public Task<int?> DeleteCampaigns(int? accountId = null, string ids = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids);

            return _vkontakte.RequestAsync<int?>("ads.deleteCampaigns", parameters);
        }

        /// <summary>
        /// Returns number of ads.
        /// Docs: <see href="https://vk.com/dev/ads.getAds">ads.getAds</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">'Available and required for advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="includeDeleted">
        /// Flag that specifies whether archived ads shall be shown:; *0 — show only active ads;; *1
        /// — show all ads.;
        /// </param>
        /// <param name="campaignIds">
        /// Filter by advertising campaigns. ; Serialized JSON array with campaign IDs. If the parameter
        /// is null, ads of all campaigns will be shown.;
        /// </param>
        /// <param name="adIds">
        /// Filter by ads. ; Serialized JSON array with ad IDs. If the parameter is null, all ads will be
        /// shown.;
        /// </param>
        /// <param name="limit">
        /// Limit of number of returned ads. Used only if ad_ids parameter is null, and 'campaign_ids'
        /// parameter contains ID of only one campaign.
        /// </param>
        /// <param name="offset">Offset. Used in the same cases as 'limit' parameter.</param>
        public Task<IEnumerable<Ad>> GetAds(int? accountId = null, int? clientId = null,
            bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null,
            int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds);
            if (adIds != null)
                parameters.Add("ad_ids", adIds);
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<Ad>>("ads.getAds", parameters);
        }

        /// <summary>
        /// Returns descriptions of ad layouts.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsLayout">ads.getAdsLayout</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">'For advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="includeDeleted">
        /// Flag that specifies whether archived ads shall be shown.; *0 — show only active ads;; *1
        /// — show all ads.;
        /// </param>
        /// <param name="campaignIds">
        /// Filter by advertising campaigns.; Serialized JSON array with campaign IDs. If the parameter
        /// is null, ads of all campaigns will be shown.;
        /// </param>
        /// <param name="adIds">
        /// Filter by ads.; Serialized JSON array with ad IDs. If the parameter is null, all ads will be
        /// shown.;
        /// </param>
        /// <param name="limit">
        /// Limit of number of returned ads. Used only if 'ad_ids' parameter is null, and 'campaign_ids'
        /// parameter contains ID of only one campaign.
        /// </param>
        /// <param name="offset">Offset. Used in the same cases as 'limit' parameter.</param>
        public Task<IEnumerable<AdLayout>> GetAdsLayout(int? accountId = null, int? clientId = null,
            bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null,
            int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds);
            if (adIds != null)
                parameters.Add("ad_ids", adIds);
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<AdLayout>>("ads.getAdsLayout", parameters);
        }

        /// <summary>
        /// Returns ad targeting parameters.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsTargeting">ads.getAdsTargeting</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">'For advertising agencies.' ID of the client ads are retrieved from.</param>
        /// <param name="includeDeleted">
        /// flag that specifies whether archived ads shall be shown:; *0 — show only active ads;; *1
        /// — show all ads.
        /// </param>
        /// <param name="campaignIds">
        /// Filter by advertising campaigns.; Serialized JSON array with campaign IDs. If the parameter
        /// is null, ads of all campaigns will be shown.;
        /// </param>
        /// <param name="adIds">
        /// Filter by ads.; Serialized JSON array with ad IDs. If the parameter is null, all ads will be
        /// shown.
        /// </param>
        /// <param name="limit">
        /// Limit of number of returned ads. Used only if 'ad_ids' parameter is null, and 'campaign_ids'
        /// parameter contains ID of only one campaign.
        /// </param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        public Task<IEnumerable<TargSettings>> GetAdsTargeting(int? accountId = null, int? clientId = null,
            bool? includeDeleted = null, string campaignIds = null, string adIds = null, int? limit = null,
            int? offset = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds);
            if (adIds != null)
                parameters.Add("ad_ids", adIds);
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<TargSettings>>("ads.getAdsTargeting", parameters);
        }

        /// <summary>
        /// Creates ads.
        /// Docs: <see href="https://vk.com/dev/ads.createAds">ads.createAds</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe created ads. Description of 'ad_specification'
        /// objects see below.
        /// </param>
        public Task<IEnumerable<int?>> CreateAds(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<IEnumerable<int?>>("ads.createAds", parameters);
        }

        /// <summary>
        /// Edits ads.
        /// Docs: <see href="https://vk.com/dev/ads.updateAds">ads.updateAds</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe changes in ads. Description of
        /// 'ad_edit_specification' objects see below.
        /// </param>
        public Task<IEnumerable<int?>> UpdateAds(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<IEnumerable<int?>>("ads.updateAds", parameters);
        }

        /// <summary>
        /// Archives ads.
        /// Docs: <see href="https://vk.com/dev/ads.deleteAds">ads.deleteAds</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with ad IDs.</param>
        public Task<IEnumerable<int?>> DeleteAds(int? accountId = null, string ids = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids);

            return _vkontakte.RequestAsync<IEnumerable<int?>>("ads.deleteAds", parameters);
        }

        /// <summary>
        /// Allows to check the ad link.
        /// Docs: <see href="https://vk.com/dev/ads.checkLink">ads.checkLink</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="linkType">
        /// Object type:; *'community' — community;; *'post' — community post;; *'application' — VK
        /// application;; *'video' — video;; *'site' — external site.
        /// </param>
        /// <param name="linkUrl">Object URL.</param>
        /// <param name="campaignId">Campaign ID</param>
        public Task<LinkStatus> CheckLink(int? accountId = null, string linkType = null, string linkUrl = null,
            int? campaignId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (linkType != null)
                parameters.Add("link_type", linkType);
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl);
            if (campaignId != null)
                parameters.Add("campaign_id", campaignId.ToApiString());

            return _vkontakte.RequestAsync<LinkStatus>("ads.checkLink", parameters);
        }

        /// <summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        /// Docs: <see href="https://vk.com/dev/ads.getStatistics">ads.getStatistics</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="idsType">
        /// Type of requested objects listed in 'ids' parameter:; *ad — ads;; *campaign — campaigns;;
        /// *client — clients;; *office — account.;
        /// </param>
        /// <param name="ids">
        /// IDs requested ads, campaigns, clients or account, separated with a comma, depending on the value set
        /// in 'ids_type'. Maximum 2000 objects.
        /// </param>
        /// <param name="period">
        /// Data grouping by dates:; *day — statistics by days;; *month — statistics by months;; *overall —
        /// overall statistics.; 'date_from' and 'date_to' parameters set temporary limits.
        /// </param>
        /// <param name="dateFrom">
        /// Date to show statistics from. For different value of 'period' different date format is used:;
        /// *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — day it was created on;; *month: YYYY-MM, example:
        /// 2011-09 — September 2011; **0 — month it was created in;; *overall: 0.;
        /// </param>
        /// <param name="dateTo">
        /// Date to show statistics to. For different value of 'period' different date format is used:; *day:
        /// YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — current day;; *month: YYYY-MM, example: 2011-09 —
        /// September 2011; **0 — current month;; *overall: 0.
        /// </param>
        public Task<IEnumerable<Types.Ads.Stats>> GetStatistics(int? accountId = null, string idsType = null,
            string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (idsType != null)
                parameters.Add("ids_type", idsType);
            if (ids != null)
                parameters.Add("ids", ids);
            if (period != null)
                parameters.Add("period", period);
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom);
            if (dateTo != null)
                parameters.Add("date_to", dateTo);

            return _vkontakte.RequestAsync<IEnumerable<Types.Ads.Stats>>("ads.getStatistics", parameters);
        }

        /// <summary>
        /// Returns demographics for ads or campaigns.
        /// Docs: <see href="https://vk.com/dev/ads.getDemographics">ads.getDemographics</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="idsType">Type of requested objects listed in 'ids' parameter:; *ad — ads;; *campaign — campaigns.;</param>
        /// <param name="ids">
        /// IDs requested ads or campaigns, separated with a comma, depending on the value set in 'ids_type'.
        /// Maximum 2000 objects.
        /// </param>
        /// <param name="period">
        /// Data grouping by dates:; *day — statistics by days;; *month — statistics by months;; *overall —
        /// overall statistics.; 'date_from' and 'date_to' parameters set temporary limits.
        /// </param>
        /// <param name="dateFrom">
        /// Date to show statistics from. For different value of 'period' different date format is used:;
        /// *day: YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — day it was created on;; *month: YYYY-MM, example:
        /// 2011-09 — September 2011; **0 — month it was created in;; *overall: 0.
        /// </param>
        /// <param name="dateTo">
        /// Date to show statistics to. For different value of 'period' different date format is used:; *day:
        /// YYYY-MM-DD, example: 2011-09-27 — September 27, 2011; **0 — current day;; *month: YYYY-MM, example: 2011-09 —
        /// September 2011; **0 — current month;; *overall: 0.
        /// </param>
        public Task<IEnumerable<DemoStats>> GetDemographics(int? accountId = null, string idsType = null,
            string ids = null, string period = null, string dateFrom = null, string dateTo = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (idsType != null)
                parameters.Add("ids_type", idsType);
            if (ids != null)
                parameters.Add("ids", ids);
            if (period != null)
                parameters.Add("period", period);
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom);
            if (dateTo != null)
                parameters.Add("date_to", dateTo);

            return _vkontakte.RequestAsync<IEnumerable<DemoStats>>("ads.getDemographics", parameters);
        }

        /// <summary>
        /// Allows to get detailed information about the ad post reach.
        /// Docs: <see href="https://vk.com/dev/ads.getAdsPostsReach">ads.getAdsPostsReach</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="adsIds">Ads IDS separated by comma.</param>
        public Task<IEnumerable<PostStats>> GetAdsPostsReach(int? accountId = null, string adsIds = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adsIds != null)
                parameters.Add("ads_ids", adsIds);

            return _vkontakte.RequestAsync<IEnumerable<PostStats>>("ads.getAdsPostsReach", parameters);
        }

        /// <summary>
        /// Returns current budget of the advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getBudget">ads.getBudget</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        public Task<int?> GetBudget(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());

            return _vkontakte.RequestAsync<int?>("ads.getBudget", parameters);
        }

        /// <summary>
        /// Returns a list of managers and supervisors of advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.getOfficeUsers">ads.getOfficeUsers</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        public Task<IEnumerable<Types.Ads.Users>> GetOfficeUsers(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<Types.Ads.Users>>("ads.getOfficeUsers", parameters);
        }

        /// <summary>
        /// Adds managers and/or supervisors to advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.addOfficeUsers">ads.addOfficeUsers</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="data">
        /// Serialized JSON array of objects that describe added managers. Description of 'user_specification'
        /// objects see below.
        /// </param>
        public Task<bool?> AddOfficeUsers(int? accountId = null, string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data);

            return _vkontakte.RequestAsync<bool?>("ads.addOfficeUsers", parameters);
        }

        /// <summary>
        /// Removes managers and/or supervisors from advertising account.
        /// Docs: <see href="https://vk.com/dev/ads.removeOfficeUsers">ads.removeOfficeUsers</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="ids">Serialized JSON array with IDs of deleted managers.</param>
        public Task<bool?> RemoveOfficeUsers(int? accountId = null, string ids = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids);

            return _vkontakte.RequestAsync<bool?>("ads.removeOfficeUsers", parameters);
        }

        /// <summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        /// Docs: <see href="https://vk.com/dev/ads.getTargetingStats">ads.getTargetingStats</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="criteria">
        /// Serialized JSON object that describes targeting parameters. Description of 'criteria' object see
        /// below.
        /// </param>
        /// <param name="adId">ID of an ad which targeting parameters shall be analyzed.</param>
        /// <param name="adFormat">
        /// Ad format. Possible values:; *'1' — image and text;; *'2' — big image;; *'3' — exclusive
        /// format;; *'4' — community, square image;; *'7' — special app format;; *'8' — special community format;; *'9' — post
        /// in community;; *'10' — app board.
        /// </param>
        /// <param name="adPlatform">
        /// Platforms to use for ad showing. Possible values:; (for 'ad_format' = '1'); *'0' — VK and
        /// partner sites;; *'1' — VK only.; (for 'ad_format' = '9'); *'all' — all platforms;; *'desktop' — desktop version;;
        /// *'mobile' — mobile version and apps.
        /// </param>
        /// <param name="linkUrl">URL for the advertised object.</param>
        /// <param name="linkDomain">Domain of the advertised object.</param>
        public Task<TargStats> GetTargetingStats(int? accountId = null, string criteria = null,
            int? adId = null, int? adFormat = null, string adPlatform = null, string linkUrl = null,
            string linkDomain = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (criteria != null)
                parameters.Add("criteria", criteria);
            if (adId != null)
                parameters.Add("ad_id", adId.ToApiString());
            if (adFormat != null)
                parameters.Add("ad_format", adFormat.ToApiString());
            if (adPlatform != null)
                parameters.Add("ad_platform", adPlatform);
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl);
            if (linkDomain != null)
                parameters.Add("link_domain", linkDomain);

            return _vkontakte.RequestAsync<TargStats>("ads.getTargetingStats", parameters);
        }

        /// <summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        /// Docs: <see href="https://vk.com/dev/ads.getSuggestions">ads.getSuggestions</see>
        /// </summary>
        /// <param name="section">
        /// Section, suggestions are retrieved in. Available values:; *countries — request of a list of
        /// countries. If q is not set or blank, a short list of countries is shown. Otherwise, a full list of countries is
        /// shown.; *regions — requested list of regions. 'country' parameter is required.; *cities — requested list of cities.
        /// 'country' parameter is required.; *districts — requested list of districts. 'cities' parameter is required.;
        /// *stations — requested list of subway stations. 'cities' parameter is required.; *streets — requested list of
        /// streets. 'cities' parameter is required.; *schools — requested list of educational organizations. 'cities'
        /// parameter is required.; *interests — requested list of interests.; *positions — requested list of positions
        /// (professions).; *group_types — requested list of group types.; *religions — requested list of religious
        /// commitments.; *browsers — requested list of browsers and mobile devices.;
        /// </param>
        /// <param name="ids">
        /// Objects IDs separated by commas. If the parameter is passed, 'q, country, cities' should not be
        /// passed.
        /// </param>
        /// <param name="q">Filter-line of the request (for countries, regions, cities, streets, schools, interests, positions).</param>
        /// <param name="country">ID of the country objects are searched in.</param>
        /// <param name="cities">IDs of cities where objects are searched in, separated with a comma.</param>
        /// <param name="lang">
        /// Language of the returned string values. Supported languages:; *ru — Russian;; *ua — Ukrainian;; *en
        /// — English.;
        /// </param>
        public Task<IEnumerable<TargSuggestions>> GetSuggestions(string section = null, string ids = null,
            string q = null, int? country = null, string cities = null, string lang = null)
        {
            var parameters = new Dictionary<string, string>();

            if (section != null)
                parameters.Add("section", section);
            if (ids != null)
                parameters.Add("ids", ids);
            if (q != null)
                parameters.Add("q", q);
            if (country != null)
                parameters.Add("country", country.ToApiString());
            if (cities != null)
                parameters.Add("cities", cities);
            if (lang != null)
                parameters.Add("lang", lang);

            return _vkontakte.RequestAsync<IEnumerable<TargSuggestions>>("ads.getSuggestions", parameters);
        }

        /// <summary>
        /// Returns a list of possible ad categories.
        /// Docs: <see href="https://vk.com/dev/ads.getCategories">ads.getCategories</see>
        /// </summary>
        /// <param name="lang">Language. The full list of supported languages is here.</param>
        public Task<IEnumerable<Category>> GetCategories(string lang = null)
        {
            var parameters = new Dictionary<string, string>();

            if (lang != null)
                parameters.Add("lang", lang);

            return _vkontakte.RequestAsync<IEnumerable<Category>>("ads.getCategories", parameters);
        }

        /// <summary>
        /// Returns URL to upload an ad photo to.
        /// Docs: <see href="https://vk.com/dev/ads.getUploadURL">ads.getUploadURL</see>
        /// </summary>
        /// <param name="adFormat">
        /// Ad format:; *1 — image and text;; *2 — big image;; *3 — exclusive format;; *4 — community,
        /// square image;; *7 — special app format.
        /// </param>
        public Task<string> GetUploadUrl(int? adFormat = null)
        {
            var parameters = new Dictionary<string, string>();

            if (adFormat != null)
                parameters.Add("ad_format", adFormat.ToApiString());

            return _vkontakte.RequestAsync<string>("ads.getUploadURL", parameters);
        }

        /// <summary>
        /// Returns URL to upload an ad video to.
        /// Docs: <see href="https://vk.com/dev/ads.getVideoUploadURL">ads.getVideoUploadURL</see>
        /// </summary>
        public Task<string> GetVideoUploadUrl()
        {
            var parameters = new Dictionary<string, string>();


            return _vkontakte.RequestAsync<string>("ads.getVideoUploadURL", parameters);
        }

        /// <summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next
        /// counter nulling in seconds.
        /// Docs: <see href="https://vk.com/dev/ads.getFloodStats">ads.getFloodStats</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        public Task<FloodStats> GetFloodStats(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());

            return _vkontakte.RequestAsync<FloodStats>("ads.getFloodStats", parameters);
        }

        /// <summary>
        /// Returns a reason of ad rejection for pre-moderation.
        /// Docs: <see href="https://vk.com/dev/ads.getRejectionReason">ads.getRejectionReason</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="adId">Ad ID.</param>
        public Task<RejectReason> GetRejectionReason(int? accountId = null, int? adId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adId != null)
                parameters.Add("ad_id", adId.ToApiString());

            return _vkontakte.RequestAsync<RejectReason>("ads.getRejectionReason", parameters);
        }

        /// <summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product,
        /// registered, etc.).
        /// Docs: <see href="https://vk.com/dev/ads.createTargetGroup">ads.createTargetGroup</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">
        /// 'Only for advertising agencies.'; ID of the client with the advertising account where the group
        /// will be created.;
        /// </param>
        /// <param name="name">Name of the target group — a string up to 64 characters long.</param>
        /// <param name="domain">Domain of the site where user accounting code will be placed.</param>
        /// <param name="lifetime">
        /// 'For groups with auditory created with pixel code only.'; ; Number of days after that users will
        /// be automatically removed from the group. '0' — not to remove users.;
        /// </param>
        public Task<CreateTargetGroupResponse> CreateTargetGroup(int? accountId = null, int? clientId = null,
            string name = null, string domain = null, int? lifetime = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (domain != null)
                parameters.Add("domain", domain);
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToApiString());

            return _vkontakte.RequestAsync<CreateTargetGroupResponse>("ads.createTargetGroup", parameters);
        }

        /// <summary>
        /// Edits a retarget group.
        /// Docs: <see href="https://vk.com/dev/ads.updateTargetGroup">ads.updateTargetGroup</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">
        /// 'Only for advertising agencies.' ; ID of the client with the advertising account where the
        /// group will be created.;
        /// </param>
        /// <param name="targetGroupId">Group ID.</param>
        /// <param name="name">New name of the target group — a string up to 64 characters long.</param>
        /// <param name="domain">Domain of the site where user accounting code will be placed.</param>
        /// <param name="lifetime">
        /// 'Only for the groups that get audience from sites with user accounting code.'; Time in days when
        /// users added to a retarget group will be automatically excluded from it. ; '0' – automatic exclusion is off.
        /// </param>
        public Task<int> UpdateTargetGroup(int? accountId = null, int? clientId = null,
            int? targetGroupId = null, string name = null, string domain = null, int? lifetime = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());
            if (name != null)
                parameters.Add("name", name);
            if (domain != null)
                parameters.Add("domain", domain);
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToApiString());

            return _vkontakte.RequestAsync<int>("ads.updateTargetGroup", parameters);
        }

        /// <summary>
        /// Deletes a retarget group.
        /// Docs: <see href="https://vk.com/dev/ads.deleteTargetGroup">ads.deleteTargetGroup</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">
        /// 'Only for advertising agencies.' ; ID of the client with the advertising account where the
        /// group will be created.;
        /// </param>
        /// <param name="targetGroupId">Group ID.</param>
        public Task<int> DeleteTargetGroup(int? accountId = null, int? clientId = null,
            int? targetGroupId = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());

            return _vkontakte.RequestAsync<int>("ads.deleteTargetGroup", parameters);
        }

        /// <summary>
        /// Returns a list of target groups.
        /// Docs: <see href="https://vk.com/dev/ads.getTargetGroups">ads.getTargetGroups</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">
        /// 'Only for advertising agencies.'; ID of the client with the advertising account where the group
        /// will be created.;
        /// </param>
        /// <param name="extended">'1' — to return pixel code.</param>
        public Task<IEnumerable<TargetGroup>> GetTargetGroups(int? accountId = null, int? clientId = null,
            bool? extended = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());

            return _vkontakte.RequestAsync<IEnumerable<TargetGroup>>("ads.getTargetGroups", parameters);
        }

        /// <summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        /// Docs: <see href="https://vk.com/dev/ads.importTargetContacts">ads.importTargetContacts</see>
        /// </summary>
        /// <param name="accountId">Advertising account ID.</param>
        /// <param name="clientId">
        /// 'Only for advertising agencies.' ; ID of the client with the advertising account where the
        /// group will be created.;
        /// </param>
        /// <param name="targetGroupId">Target group ID.</param>
        /// <param name="contacts">List of phone numbers, emails or user IDs separated with a comma.</param>
        public Task<int?> ImportTargetContacts(int? accountId = null, int? clientId = null,
            int? targetGroupId = null, string contacts = null)
        {
            var parameters = new Dictionary<string, string>();

            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());
            if (contacts != null)
                parameters.Add("contacts", contacts);

            return _vkontakte.RequestAsync<int?>("ads.importTargetContacts", parameters);
        }
    }
}