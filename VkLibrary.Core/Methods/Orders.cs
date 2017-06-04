using System.Collections.Generic;
using System.Threading.Tasks;
using VkLibrary.Core.Types.Orders;

namespace VkLibrary.Core.Methods
{
    /// <summary>
    /// Orders API section.
    /// </summary>
    public class Orders
    {
        private readonly VkLibrary _vkontakte;

        internal Orders(VkLibrary vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of orders.
        /// Docs: <see href="https://vk.com/dev/orders.get">orders.get</see>
        /// </summary>
        /// <param name="count">number of returned orders.</param>
        /// <param name="testMode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<IEnumerable<Order>> Get(int? count = null, bool? testMode = null)
        {
            var parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<Order>>("orders.get", parameters);
        }

        /// <summary>
        /// Returns information about orders by their IDs.
        /// Docs: <see href="https://vk.com/dev/orders.getById">orders.getById</see>
        /// </summary>
        /// <param name="orderId">order ID.</param>
        /// <param name="orderIds">order IDs (when information about several orders is requested).</param>
        /// <param name="testMode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<IEnumerable<Order>> GetById(int? orderId = null, IEnumerable<int?> orderIds = null,
            bool? testMode = null)
        {
            var parameters = new Dictionary<string, string>();

            if (orderId != null)
                parameters.Add("order_id", orderId.ToApiString());
            if (orderIds != null)
                parameters.Add("order_ids", orderIds.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());

            return await _vkontakte.GetAsync<IEnumerable<Order>>("orders.getById", parameters);
        }

        /// <summary>
        /// Changes order status.
        /// Docs: <see href="https://vk.com/dev/orders.changeState">orders.changeState</see>
        /// </summary>
        /// <param name="orderId">order ID.</param>
        /// <param name="action">
        /// action to be done with the order. ; ; Available actions:; *cancel — to cancel unconfirmed order.;
        /// *charge — to confirm unconfirmed order. Applies only if processing of
        /// [vk.com/dev/payments_status|order_change_state] notification failed.; *refund — to cancel confirmed order.;
        /// </param>
        /// <param name="appOrderId">internal ID of the order in the application.</param>
        /// <param name="testMode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<string> ChangeState(int? orderId = null, string action = null, int? appOrderId = null,
            bool? testMode = null)
        {
            var parameters = new Dictionary<string, string>();

            if (orderId != null)
                parameters.Add("order_id", orderId.ToApiString());
            if (action != null)
                parameters.Add("action", action);
            if (appOrderId != null)
                parameters.Add("app_order_id", appOrderId.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());

            return await _vkontakte.GetAsync<string>("orders.changeState", parameters);
        }

        /// <summary>
        /// Docs: <see href="https://vk.com/dev/orders.getAmount">orders.getAmount</see>
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="votes"></param>
        public async Task<Amount> GetAmount(int? userId = null, IEnumerable<string> votes = null)
        {
            var parameters = new Dictionary<string, string>();

            if (userId != null)
                parameters.Add("user_id", userId.ToApiString());
            if (votes != null)
                parameters.Add("votes", votes.ToApiString());

            return await _vkontakte.GetAsync<Amount>("orders.getAmount", parameters);
        }
    }
}