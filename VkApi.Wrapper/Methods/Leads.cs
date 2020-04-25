using VkApi.Wrapper.Objects;
using VkApi.Wrapper.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Methods
{
    public class Leads
    {
        private readonly Vkontakte _vkontakte;

        internal Leads(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Checks if the user can start the lead.
        ///</summary>
        public Task<LeadsChecked> CheckUser(int? leadId = null, int? testResult = null, Boolean? testMode = null, Boolean? autoStart = null, int? age = null, String country = null)
        {
            var parameters = new Dictionary<string, string>();
            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (testResult != null)
                parameters.Add("test_result", testResult.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            if (autoStart != null)
                parameters.Add("auto_start", autoStart.ToApiString());
            if (age != null)
                parameters.Add("age", age.ToApiString());
            if (country != null)
                parameters.Add("country", country.ToApiString());
            return _vkontakte.RequestAsync<LeadsChecked>("leads.checkUser", parameters);
        }

        ///<summary>
        /// Completes the lead started by user.
        ///</summary>
        public Task<LeadsComplete> Complete(String vkSid = null, String secret = null, String comment = null)
        {
            var parameters = new Dictionary<string, string>();
            if (vkSid != null)
                parameters.Add("vk_sid", vkSid.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret.ToApiString());
            if (comment != null)
                parameters.Add("comment", comment.ToApiString());
            return _vkontakte.RequestAsync<LeadsComplete>("leads.complete", parameters);
        }

        ///<summary>
        /// Returns lead stats data.
        ///</summary>
        public Task<LeadsLead> GetStats(int? leadId = null, String secret = null, String dateStart = null, String dateEnd = null)
        {
            var parameters = new Dictionary<string, string>();
            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret.ToApiString());
            if (dateStart != null)
                parameters.Add("date_start", dateStart.ToApiString());
            if (dateEnd != null)
                parameters.Add("date_end", dateEnd.ToApiString());
            return _vkontakte.RequestAsync<LeadsLead>("leads.getStats", parameters);
        }

        ///<summary>
        /// Returns a list of last user actions for the offer.
        ///</summary>
        public Task<LeadsEntry[]> GetUsers(int? offerId = null, String secret = null, int? offset = null, int? count = null, int? status = null, Boolean? reverse = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offerId != null)
                parameters.Add("offer_id", offerId.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret.ToApiString());
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (status != null)
                parameters.Add("status", status.ToApiString());
            if (reverse != null)
                parameters.Add("reverse", reverse.ToApiString());
            return _vkontakte.RequestAsync<LeadsEntry[]>("leads.getUsers", parameters);
        }

        ///<summary>
        /// Counts the metric event.
        ///</summary>
        public Task<LeadsMetricHitResponse> MetricHit(String data = null)
        {
            var parameters = new Dictionary<string, string>();
            if (data != null)
                parameters.Add("data", data.ToApiString());
            return _vkontakte.RequestAsync<LeadsMetricHitResponse>("leads.metricHit", parameters);
        }

        ///<summary>
        /// Creates new session for the user passing the offer.
        ///</summary>
        public Task<LeadsStart> Start(int? leadId = null, String secret = null, int? uid = null, int? aid = null, Boolean? testMode = null, Boolean? force = null)
        {
            var parameters = new Dictionary<string, string>();
            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret.ToApiString());
            if (uid != null)
                parameters.Add("uid", uid.ToApiString());
            if (aid != null)
                parameters.Add("aid", aid.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            if (force != null)
                parameters.Add("force", force.ToApiString());
            return _vkontakte.RequestAsync<LeadsStart>("leads.start", parameters);
        }
    }
}