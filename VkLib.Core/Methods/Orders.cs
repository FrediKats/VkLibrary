using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    /// <summary>
    /// Orders API section.
    /// </summary>
    public class Orders
    {
        private Vkontakte _vkontakte;

        internal Orders(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Returns a list of orders.
        /// Docs: <see href="https://vk.com/dev/orders.get">orders.get</see>
        /// </summary>
        /// <param name="count">number of returned orders.</param>
        /// <param name="test_mode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<IEnumerable<VkLib.Types.Orders.Order>> Get(int? count = null, bool? test_mode = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (count != null)
                parameters.Add("count", count.ToString());
            if (test_mode != null)
                parameters.Add("test_mode", test_mode.ToString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Orders.Order>>("orders.get", parameters);
        }

        /// <summary>
        /// Returns information about orders by their IDs.
        /// Docs: <see href="https://vk.com/dev/orders.getById">orders.getById</see>
        /// </summary>
        /// <param name="order_id">order ID.</param>
        /// <param name="order_ids">order IDs (when information about several orders is requested).</param>
        /// <param name="test_mode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<IEnumerable<VkLib.Types.Orders.Order>> GetById(int? order_id = null, IEnumerable<int?> order_ids = null, bool? test_mode = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (order_id != null)
                parameters.Add("order_id", order_id.ToString());
            if (order_ids != null)
                parameters.Add("order_ids", string.Join(",", order_ids));
            if (test_mode != null)
                parameters.Add("test_mode", test_mode.ToString());

            return await _vkontakte.GetAsync<IEnumerable<VkLib.Types.Orders.Order>>("orders.getById", parameters);
        }

        /// <summary>
        /// Changes order status.
        /// Docs: <see href="https://vk.com/dev/orders.changeState">orders.changeState</see>
        /// </summary>
        /// <param name="order_id">order ID.</param>
        /// <param name="action">action to be done with the order. ; ; Available actions:; *cancel — to cancel unconfirmed order.; *charge — to confirm unconfirmed order. Applies only if processing of [vk.com/dev/payments_status|order_change_state] notification failed.; *refund — to cancel confirmed order.;</param>
        /// <param name="app_order_id">internal ID of the order in the application.</param>
        /// <param name="test_mode">if this parameter is set to 1, this method returns a list of test mode orders. By default — 0.</param>
        public async Task<string> ChangeState(int? order_id = null, string action = null, int? app_order_id = null, bool? test_mode = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (order_id != null)
                parameters.Add("order_id", order_id.ToString());
            if (action != null)
                parameters.Add("action", action);
            if (app_order_id != null)
                parameters.Add("app_order_id", app_order_id.ToString());
            if (test_mode != null)
                parameters.Add("test_mode", test_mode.ToString());

            return await _vkontakte.GetAsync<string>("orders.changeState", parameters);
        }

        /// <summary>
        /// 
        /// Docs: <see href="https://vk.com/dev/orders.getAmount">orders.getAmount</see>
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="votes"></param>
        public async Task<VkLib.Types.Orders.Amount> GetAmount(int? user_id = null, IEnumerable<string> votes = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (user_id != null)
                parameters.Add("user_id", user_id.ToString());
            if (votes != null)
                parameters.Add("votes", string.Join(",", votes));

            return await _vkontakte.GetAsync<VkLib.Types.Orders.Amount>("orders.getAmount", parameters);
        }

    }
}
