using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Orders
{
    public class OrdersSubscription
    {
        ///<summary>
        /// Cancel reason
        ///</summary>
        [JsonProperty("cancel_reason")]
        public String CancelReason { get; set; }

        ///<summary>
        /// Date of creation in Unixtime
        ///</summary>
        [JsonProperty("create_time")]
        public int CreateTime { get; set; }

        ///<summary>
        /// Subscription ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Subscription order item
        ///</summary>
        [JsonProperty("item_id")]
        public String ItemId { get; set; }

        ///<summary>
        /// Date of next bill in Unixtime
        ///</summary>
        [JsonProperty("next_bill_time")]
        public int NextBillTime { get; set; }

        ///<summary>
        /// Pending cancel state
        ///</summary>
        [JsonProperty("pending_cancel")]
        public Boolean PendingCancel { get; set; }

        ///<summary>
        /// Subscription period
        ///</summary>
        [JsonProperty("period")]
        public int Period { get; set; }

        ///<summary>
        /// Date of last period start in Unixtime
        ///</summary>
        [JsonProperty("period_start_time")]
        public int PeriodStartTime { get; set; }

        ///<summary>
        /// Subscription price
        ///</summary>
        [JsonProperty("price")]
        public int Price { get; set; }

        ///<summary>
        /// Subscription status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// Is test subscription
        ///</summary>
        [JsonProperty("test_mode")]
        public Boolean TestMode { get; set; }

        ///<summary>
        /// Date of trial expire in Unixtime
        ///</summary>
        [JsonProperty("trial_expire_time")]
        public int TrialExpireTime { get; set; }

        ///<summary>
        /// Date of last change in Unixtime
        ///</summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
    }
}