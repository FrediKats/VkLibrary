using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Ads
    {
        private readonly Vkontakte _vkontakte;

        internal Ads(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Adds managers and/or supervisors to advertising account.
        ///</summary>
        public Task<Boolean> AddOfficeUsers(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<Boolean>("ads.addOfficeUsers", parameters);
        }

        ///<summary>
        /// Allows to check the ad link.
        ///</summary>
        public Task<AdsLinkStatus> CheckLink(int? accountId = null, String linkType = null, String linkUrl = null, int? campaignId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (linkType != null)
                parameters.Add("link_type", linkType.ToApiString());
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl.ToApiString());
            if (campaignId != null)
                parameters.Add("campaign_id", campaignId.ToApiString());
            return _vkontakte.RequestAsync<AdsLinkStatus>("ads.checkLink", parameters);
        }

        ///<summary>
        /// Creates ads.
        ///</summary>
        public Task<int[]> CreateAds(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int[]>("ads.createAds", parameters);
        }

        ///<summary>
        /// Creates advertising campaigns.
        ///</summary>
        public Task<int[]> CreateCampaigns(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int[]>("ads.createCampaigns", parameters);
        }

        ///<summary>
        /// Creates clients of an advertising agency.
        ///</summary>
        public Task<int[]> CreateClients(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int[]>("ads.createClients", parameters);
        }

        ///<summary>
        /// Creates a group to re-target ads for users who visited advertiser's site (viewed information about the product, registered, etc.).
        ///</summary>
        public Task<AdsCreateTargetGroupResponse> CreateTargetGroup(int? accountId = null, int? clientId = null, String name = null, int? lifetime = null, int? targetPixelId = null, String targetPixelRules = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToApiString());
            if (targetPixelId != null)
                parameters.Add("target_pixel_id", targetPixelId.ToApiString());
            if (targetPixelRules != null)
                parameters.Add("target_pixel_rules", targetPixelRules.ToApiString());
            return _vkontakte.RequestAsync<AdsCreateTargetGroupResponse>("ads.createTargetGroup", parameters);
        }

        ///<summary>
        /// Archives ads.
        ///</summary>
        public Task<int[]> DeleteAds(int? accountId = null, String ids = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            return _vkontakte.RequestAsync<int[]>("ads.deleteAds", parameters);
        }

        ///<summary>
        /// Archives advertising campaigns.
        ///</summary>
        public Task<int> DeleteCampaigns(int? accountId = null, String ids = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.deleteCampaigns", parameters);
        }

        ///<summary>
        /// Archives clients of an advertising agency.
        ///</summary>
        public Task<int> DeleteClients(int? accountId = null, String ids = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.deleteClients", parameters);
        }

        ///<summary>
        /// Deletes a retarget group.
        ///</summary>
        public Task<BaseOkResponse> DeleteTargetGroup(int? accountId = null, int? clientId = null, int? targetGroupId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("ads.deleteTargetGroup", parameters);
        }

        ///<summary>
        /// Returns a list of advertising accounts.
        ///</summary>
        public Task<AdsAccount[]> GetAccounts()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<AdsAccount[]>("ads.getAccounts", parameters);
        }

        ///<summary>
        /// Returns number of ads.
        ///</summary>
        public Task<AdsAd[]> GetAds(int? accountId = null, String adIds = null, String campaignIds = null, int? clientId = null, Boolean? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adIds != null)
                parameters.Add("ad_ids", adIds.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<AdsAd[]>("ads.getAds", parameters);
        }

        ///<summary>
        /// Returns descriptions of ad layouts.
        ///</summary>
        public Task<AdsAdLayout[]> GetAdsLayout(int? accountId = null, String adIds = null, String campaignIds = null, int? clientId = null, Boolean? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adIds != null)
                parameters.Add("ad_ids", adIds.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<AdsAdLayout[]>("ads.getAdsLayout", parameters);
        }

        ///<summary>
        /// Returns ad targeting parameters.
        ///</summary>
        public Task<AdsTargSettings[]> GetAdsTargeting(int? accountId = null, String adIds = null, String campaignIds = null, int? clientId = null, Boolean? includeDeleted = null, int? limit = null, int? offset = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adIds != null)
                parameters.Add("ad_ids", adIds.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (limit != null)
                parameters.Add("limit", limit.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            return _vkontakte.RequestAsync<AdsTargSettings[]>("ads.getAdsTargeting", parameters);
        }

        ///<summary>
        /// Returns current budget of the advertising account.
        ///</summary>
        public Task<int> GetBudget(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.getBudget", parameters);
        }

        ///<summary>
        /// Returns a list of campaigns in an advertising account.
        ///</summary>
        public Task<AdsCampaign[]> GetCampaigns(int? accountId = null, int? clientId = null, Boolean? includeDeleted = null, String campaignIds = null, String[] fields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (includeDeleted != null)
                parameters.Add("include_deleted", includeDeleted.ToApiString());
            if (campaignIds != null)
                parameters.Add("campaign_ids", campaignIds.ToApiString());
            if (fields != null)
                parameters.Add("fields", fields.ToApiString());
            return _vkontakte.RequestAsync<AdsCampaign[]>("ads.getCampaigns", parameters);
        }

        ///<summary>
        /// Returns a list of possible ad categories.
        ///</summary>
        public Task<AdsGetCategoriesResponse> GetCategories(String lang = null)
        {
            var parameters = new Dictionary<string, string>();
            if (lang != null)
                parameters.Add("lang", lang.ToApiString());
            return _vkontakte.RequestAsync<AdsGetCategoriesResponse>("ads.getCategories", parameters);
        }

        ///<summary>
        /// Returns a list of advertising agency's clients.
        ///</summary>
        public Task<AdsClient[]> GetClients(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            return _vkontakte.RequestAsync<AdsClient[]>("ads.getClients", parameters);
        }

        ///<summary>
        /// Returns demographics for ads or campaigns.
        ///</summary>
        public Task<AdsDemoStats[]> GetDemographics(int? accountId = null, String idsType = null, String ids = null, String period = null, String dateFrom = null, String dateTo = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (idsType != null)
                parameters.Add("ids_type", idsType.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            if (period != null)
                parameters.Add("period", period.ToApiString());
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom.ToApiString());
            if (dateTo != null)
                parameters.Add("date_to", dateTo.ToApiString());
            return _vkontakte.RequestAsync<AdsDemoStats[]>("ads.getDemographics", parameters);
        }

        ///<summary>
        /// Returns information about current state of a counter — number of remaining runs of methods and time to the next counter nulling in seconds.
        ///</summary>
        public Task<AdsFloodStats> GetFloodStats(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            return _vkontakte.RequestAsync<AdsFloodStats>("ads.getFloodStats", parameters);
        }

        ///<summary>
        /// Returns a list of managers and supervisors of advertising account.
        ///</summary>
        public Task<AdsUsers[]> GetOfficeUsers(int? accountId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            return _vkontakte.RequestAsync<AdsUsers[]>("ads.getOfficeUsers", parameters);
        }

        ///<summary>
        /// Returns detailed statistics of promoted posts reach from campaigns and ads.
        ///</summary>
        public Task<AdsPromotedPostReach[]> GetPostsReach(int? accountId = null, String idsType = null, String ids = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (idsType != null)
                parameters.Add("ids_type", idsType.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            return _vkontakte.RequestAsync<AdsPromotedPostReach[]>("ads.getPostsReach", parameters);
        }

        ///<summary>
        /// Returns a reason of ad rejection for pre-moderation.
        ///</summary>
        public Task<AdsRejectReason> GetRejectionReason(int? accountId = null, int? adId = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (adId != null)
                parameters.Add("ad_id", adId.ToApiString());
            return _vkontakte.RequestAsync<AdsRejectReason>("ads.getRejectionReason", parameters);
        }

        ///<summary>
        /// Returns statistics of performance indicators for ads, campaigns, clients or the whole account.
        ///</summary>
        public Task<AdsStats[]> GetStatistics(int? accountId = null, String idsType = null, String ids = null, String period = null, String dateFrom = null, String dateTo = null, String[] statsFields = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (idsType != null)
                parameters.Add("ids_type", idsType.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            if (period != null)
                parameters.Add("period", period.ToApiString());
            if (dateFrom != null)
                parameters.Add("date_from", dateFrom.ToApiString());
            if (dateTo != null)
                parameters.Add("date_to", dateTo.ToApiString());
            if (statsFields != null)
                parameters.Add("stats_fields", statsFields.ToApiString());
            return _vkontakte.RequestAsync<AdsStats[]>("ads.getStatistics", parameters);
        }

        ///<summary>
        /// Returns a set of auto-suggestions for various targeting parameters.
        ///</summary>
        public Task<AdsTargSuggestions[]> GetSuggestions(String section = null, String ids = null, String q = null, int? country = null, String cities = null, String lang = null)
        {
            var parameters = new Dictionary<string, string>();
            if (section != null)
                parameters.Add("section", section.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            if (q != null)
                parameters.Add("q", q.ToApiString());
            if (country != null)
                parameters.Add("country", country.ToApiString());
            if (cities != null)
                parameters.Add("cities", cities.ToApiString());
            if (lang != null)
                parameters.Add("lang", lang.ToApiString());
            return _vkontakte.RequestAsync<AdsTargSuggestions[]>("ads.getSuggestions", parameters);
        }

        ///<summary>
        /// Returns a list of target groups.
        ///</summary>
        public Task<AdsTargetGroup[]> GetTargetGroups(int? accountId = null, int? clientId = null, Boolean? extended = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (extended != null)
                parameters.Add("extended", extended.ToApiString());
            return _vkontakte.RequestAsync<AdsTargetGroup[]>("ads.getTargetGroups", parameters);
        }

        ///<summary>
        /// Returns the size of targeting audience, and also recommended values for CPC and CPM.
        ///</summary>
        public Task<AdsTargStats> GetTargetingStats(int? accountId = null, int? clientId = null, String criteria = null, int? adId = null, int? adFormat = null, String adPlatform = null, String adPlatformNoWall = null, String adPlatformNoAdNetwork = null, String linkUrl = null, String linkDomain = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (criteria != null)
                parameters.Add("criteria", criteria.ToApiString());
            if (adId != null)
                parameters.Add("ad_id", adId.ToApiString());
            if (adFormat != null)
                parameters.Add("ad_format", adFormat.ToApiString());
            if (adPlatform != null)
                parameters.Add("ad_platform", adPlatform.ToApiString());
            if (adPlatformNoWall != null)
                parameters.Add("ad_platform_no_wall", adPlatformNoWall.ToApiString());
            if (adPlatformNoAdNetwork != null)
                parameters.Add("ad_platform_no_ad_network", adPlatformNoAdNetwork.ToApiString());
            if (linkUrl != null)
                parameters.Add("link_url", linkUrl.ToApiString());
            if (linkDomain != null)
                parameters.Add("link_domain", linkDomain.ToApiString());
            return _vkontakte.RequestAsync<AdsTargStats>("ads.getTargetingStats", parameters);
        }

        ///<summary>
        /// Returns URL to upload an ad photo to.
        ///</summary>
        public Task<String> GetUploadURL(int? adFormat = null, int? icon = null)
        {
            var parameters = new Dictionary<string, string>();
            if (adFormat != null)
                parameters.Add("ad_format", adFormat.ToApiString());
            if (icon != null)
                parameters.Add("icon", icon.ToApiString());
            return _vkontakte.RequestAsync<String>("ads.getUploadURL", parameters);
        }

        ///<summary>
        /// Returns URL to upload an ad video to.
        ///</summary>
        public Task<String> GetVideoUploadURL()
        {
            var parameters = new Dictionary<string, string>();
            return _vkontakte.RequestAsync<String>("ads.getVideoUploadURL", parameters);
        }

        ///<summary>
        /// Imports a list of advertiser's contacts to count VK registered users against the target group.
        ///</summary>
        public Task<int> ImportTargetContacts(int? accountId = null, int? clientId = null, int? targetGroupId = null, String contacts = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());
            if (contacts != null)
                parameters.Add("contacts", contacts.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.importTargetContacts", parameters);
        }

        ///<summary>
        /// Removes managers and/or supervisors from advertising account.
        ///</summary>
        public Task<Boolean> RemoveOfficeUsers(int? accountId = null, String ids = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (ids != null)
                parameters.Add("ids", ids.ToApiString());
            return _vkontakte.RequestAsync<Boolean>("ads.removeOfficeUsers", parameters);
        }

        ///<summary>
        /// Edits ads.
        ///</summary>
        public Task<int[]> UpdateAds(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int[]>("ads.updateAds", parameters);
        }

        ///<summary>
        /// Edits advertising campaigns.
        ///</summary>
        public Task<int> UpdateCampaigns(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.updateCampaigns", parameters);
        }

        ///<summary>
        /// Edits clients of an advertising agency.
        ///</summary>
        public Task<int> UpdateClients(int? accountId = null, String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<int>("ads.updateClients", parameters);
        }

        ///<summary>
        /// Edits a retarget group.
        ///</summary>
        public Task<BaseOkResponse> UpdateTargetGroup(int? accountId = null, int? clientId = null, int? targetGroupId = null, String name = null, String domain = null, int? lifetime = null, int? targetPixelId = null, String targetPixelRules = null)
        {
            var parameters = new Dictionary<string, string>();
            if (accountId != null)
                parameters.Add("account_id", accountId.ToApiString());
            if (clientId != null)
                parameters.Add("client_id", clientId.ToApiString());
            if (targetGroupId != null)
                parameters.Add("target_group_id", targetGroupId.ToApiString());
            if (name != null)
                parameters.Add("name", name.ToApiString());
            if (domain != null)
                parameters.Add("domain", domain.ToApiString());
            if (lifetime != null)
                parameters.Add("lifetime", lifetime.ToApiString());
            if (targetPixelId != null)
                parameters.Add("target_pixel_id", targetPixelId.ToApiString());
            if (targetPixelRules != null)
                parameters.Add("target_pixel_rules", targetPixelRules.ToApiString());
            return _vkontakte.RequestAsync<BaseOkResponse>("ads.updateTargetGroup", parameters);
        }
    }
}