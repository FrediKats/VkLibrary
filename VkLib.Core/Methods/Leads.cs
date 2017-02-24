using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Leads API section.
    /// </summary>
    public class Leads
    {
        private Vkontakte _vkontakte;

        internal Leads(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Completes the lead started by user.
        /// Docs: <see href="https://vk.com/dev/leads.complete">leads.complete</see>
        /// </summary>
        /// <param name="vk_sid">Session obtained as GET parameter when session started.</param>
        /// <param name="secret">Secret key from the lead testing interface.</param>
        /// <param name="comment">Comment text.</param>
        public async Task<VkLib.Types.Leads.Complete> Complete(string vk_sid = null, string secret = null, string comment = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (vk_sid != null)
                parameters.Add("vk_sid", vk_sid);
            if (secret != null)
                parameters.Add("secret", secret);
            if (comment != null)
                parameters.Add("comment", comment);

            return await _vkontakte.GetAsync<VkLib.Types.Leads.Complete>("leads.complete", parameters);
        }

        /// <summary>
        /// Creates new session for the user passing the offer.
        /// Docs: <see href="https://vk.com/dev/leads.start">leads.start</see>
        /// </summary>
        /// <param name="lead_id">Lead ID.</param>
        /// <param name="secret">Secret key from the lead testing interface.</param>
        public async Task<VkLib.Types.Leads.Start> Start(int? lead_id = null, string secret = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (lead_id != null)
                parameters.Add("lead_id", lead_id.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret);

            return await _vkontakte.GetAsync<VkLib.Types.Leads.Start>("leads.start", parameters);
        }

        /// <summary>
        /// Returns lead stats data.
        /// Docs: <see href="https://vk.com/dev/leads.getStats">leads.getStats</see>
        /// </summary>
        /// <param name="lead_id">Lead ID.</param>
        /// <param name="secret">Secret key obtained from the lead testing interface.</param>
        /// <param name="date_start">Day to start stats from (YYYY_MM_DD, e.g.2011-09-17).</param>
        /// <param name="date_end">Day to finish stats (YYYY_MM_DD, e.g.2011-09-17).</param>
        public async Task<VkLib.Types.Leads.Lead> GetStats(int? lead_id = null, string secret = null, string date_start = null, string date_end = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (lead_id != null)
                parameters.Add("lead_id", lead_id.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret);
            if (date_start != null)
                parameters.Add("date_start", date_start);
            if (date_end != null)
                parameters.Add("date_end", date_end);

            return await _vkontakte.GetAsync<VkLib.Types.Leads.Lead>("leads.getStats", parameters);
        }

        /// <summary>
        /// Returns a list of last user actions for the offer.
        /// Docs: <see href="https://vk.com/dev/leads.getUsers">leads.getUsers</see>
        /// </summary>
        /// <param name="offer_id">Offer ID.</param>
        /// <param name="secret">Secret key obtained in the lead testing interface.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="status">Action type. Possible values:; *'0' — start;; *'1' — finish;; *'2' — blocking users;; *'3' — start in a test mode;; *'4' — finish in a test mode.;</param>
        /// <param name="reverse">Sort order. Possible values:; *'1' — chronological;; *'0' — reverse chronological.</param>
        public async Task<IEnumerable<VkLib.Types.Leads.Entry>> GetUsers(int? offer_id = null, string secret = null, int? offset = null, int? count = null, int? status = null, bool? reverse = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (offer_id != null)
                parameters.Add("offer_id", offer_id.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret);
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (status != null)
                parameters.Add("status", status.ToApiString());
            if (reverse != null)
                parameters.Add("reverse", reverse.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Leads.Entry>>("leads.getUsers", parameters);
        }

        /// <summary>
        /// Checks if the user can start the lead.
        /// Docs: <see href="https://vk.com/dev/leads.checkUser">leads.checkUser</see>
        /// </summary>
        /// <param name="lead_id">Lead ID.</param>
        /// <param name="test_result">Value to be return in 'result' field when test mode is used.</param>
        /// <param name="age">User age.</param>
        /// <param name="country">User country code.</param>
        public async Task<VkLib.Types.Leads.Checked> CheckUser(int? lead_id = null, int? test_result = null, int? age = null, string country = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (lead_id != null)
                parameters.Add("lead_id", lead_id.ToApiString());
            if (test_result != null)
                parameters.Add("test_result", test_result.ToApiString());
            if (age != null)
                parameters.Add("age", age.ToApiString());
            if (country != null)
                parameters.Add("country", country);

            return await _vkontakte.GetAsync<VkLib.Types.Leads.Checked>("leads.checkUser", parameters);
        }

        /// <summary>
        /// Counts the metric event.
        /// Docs: <see href="https://vk.com/dev/leads.metricHit">leads.metricHit</see>
        /// </summary>
        /// <param name="data">Metric data obtained in the lead interface.</param>
        public async Task<VkLib.Responses.Leads.MetricHitResponse> MetricHit(string data = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<VkLib.Responses.Leads.MetricHitResponse>("leads.metricHit", parameters);
        }

    }
}
