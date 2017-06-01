using System.Collections.Generic;
using System.Threading.Tasks;
using VkLib.Responses.Leads;
using VkLib.Types.Leads;

namespace VkLib.Methods
{
    /// <summary>
    ///     Leads API section.
    /// </summary>
    public class Leads
    {
        private readonly Vkontakte _vkontakte;

        internal Leads(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        ///     Completes the lead started by user.
        ///     Docs: <see href="https://vk.com/dev/leads.complete">leads.complete</see>
        /// </summary>
        /// <param name="vkSid">Session obtained as GET parameter when session started.</param>
        /// <param name="secret">Secret key from the lead testing interface.</param>
        /// <param name="comment">Comment text.</param>
        public async Task<Complete> Complete(string vkSid = null, string secret = null, string comment = null)
        {
            var parameters = new Dictionary<string, string>();

            if (vkSid != null)
                parameters.Add("vk_sid", vkSid);
            if (secret != null)
                parameters.Add("secret", secret);
            if (comment != null)
                parameters.Add("comment", comment);

            return await _vkontakte.GetAsync<Complete>("leads.complete", parameters);
        }

        /// <summary>
        ///     Creates new session for the user passing the offer.
        ///     Docs: <see href="https://vk.com/dev/leads.start">leads.start</see>
        /// </summary>
        /// <param name="leadId">Lead ID.</param>
        /// <param name="secret">Secret key from the lead testing interface.</param>
        public async Task<Start> Start(int? leadId = null, string secret = null)
        {
            var parameters = new Dictionary<string, string>();

            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret);

            return await _vkontakte.GetAsync<Start>("leads.start", parameters);
        }

        /// <summary>
        ///     Returns lead stats data.
        ///     Docs: <see href="https://vk.com/dev/leads.getStats">leads.getStats</see>
        /// </summary>
        /// <param name="leadId">Lead ID.</param>
        /// <param name="secret">Secret key obtained from the lead testing interface.</param>
        /// <param name="dateStart">Day to start stats from (YYYY_MM_DD, e.g.2011-09-17).</param>
        /// <param name="dateEnd">Day to finish stats (YYYY_MM_DD, e.g.2011-09-17).</param>
        public async Task<Lead> GetStats(int? leadId = null, string secret = null, string dateStart = null,
            string dateEnd = null)
        {
            var parameters = new Dictionary<string, string>();

            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (secret != null)
                parameters.Add("secret", secret);
            if (dateStart != null)
                parameters.Add("date_start", dateStart);
            if (dateEnd != null)
                parameters.Add("date_end", dateEnd);

            return await _vkontakte.GetAsync<Lead>("leads.getStats", parameters);
        }

        /// <summary>
        ///     Returns a list of last user actions for the offer.
        ///     Docs: <see href="https://vk.com/dev/leads.getUsers">leads.getUsers</see>
        /// </summary>
        /// <param name="offerId">Offer ID.</param>
        /// <param name="secret">Secret key obtained in the lead testing interface.</param>
        /// <param name="offset">Offset needed to return a specific subset of results.</param>
        /// <param name="count">Number of results to return.</param>
        /// <param name="status">
        ///     Action type. Possible values:; *'0' — start;; *'1' — finish;; *'2' — blocking users;; *'3' — start
        ///     in a test mode;; *'4' — finish in a test mode.;
        /// </param>
        /// <param name="reverse">Sort order. Possible values:; *'1' — chronological;; *'0' — reverse chronological.</param>
        public async Task<IEnumerable<Entry>> GetUsers(int? offerId = null, string secret = null, int? offset = null,
            int? count = null, int? status = null, bool? reverse = null)
        {
            var parameters = new Dictionary<string, string>();

            if (offerId != null)
                parameters.Add("offer_id", offerId.ToApiString());
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

            return await _vkontakte.GetAsync<IEnumerable<Entry>>("leads.getUsers", parameters);
        }

        /// <summary>
        ///     Checks if the user can start the lead.
        ///     Docs: <see href="https://vk.com/dev/leads.checkUser">leads.checkUser</see>
        /// </summary>
        /// <param name="leadId">Lead ID.</param>
        /// <param name="testResult">Value to be return in 'result' field when test mode is used.</param>
        /// <param name="age">User age.</param>
        /// <param name="country">User country code.</param>
        public async Task<Checked> CheckUser(int? leadId = null, int? testResult = null, int? age = null,
            string country = null)
        {
            var parameters = new Dictionary<string, string>();

            if (leadId != null)
                parameters.Add("lead_id", leadId.ToApiString());
            if (testResult != null)
                parameters.Add("test_result", testResult.ToApiString());
            if (age != null)
                parameters.Add("age", age.ToApiString());
            if (country != null)
                parameters.Add("country", country);

            return await _vkontakte.GetAsync<Checked>("leads.checkUser", parameters);
        }

        /// <summary>
        ///     Counts the metric event.
        ///     Docs: <see href="https://vk.com/dev/leads.metricHit">leads.metricHit</see>
        /// </summary>
        /// <param name="data">Metric data obtained in the lead interface.</param>
        public async Task<MetricHitResponse> MetricHit(string data = null)
        {
            var parameters = new Dictionary<string, string>();

            if (data != null)
                parameters.Add("data", data);

            return await _vkontakte.GetAsync<MetricHitResponse>("leads.metricHit", parameters);
        }
    }
}