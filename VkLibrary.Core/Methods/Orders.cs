using VkLibrary.Core.Objects;
using VkLibrary.Core.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VkLibrary.Core.Methods
{
    public class Orders
    {
        private readonly Vkontakte _vkontakte;

        internal Orders(Vkontakte vkontakte) => _vkontakte = vkontakte;

        ///<summary>
        /// Changes order status.
        ///</summary>
        public Task<String> ChangeState(int? orderId = null, String action = null, int? appOrderId = null, Boolean? testMode = null)
        {
            var parameters = new Dictionary<string, string>();
            if (orderId != null)
                parameters.Add("order_id", orderId.ToApiString());
            if (action != null)
                parameters.Add("action", action.ToApiString());
            if (appOrderId != null)
                parameters.Add("app_order_id", appOrderId.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            return _vkontakte.RequestAsync<String>("orders.changeState", parameters);
        }

        ///<summary>
        /// Returns a list of orders.
        ///</summary>
        public Task<OrdersOrder[]> Get(int? offset = null, int? count = null, Boolean? testMode = null)
        {
            var parameters = new Dictionary<string, string>();
            if (offset != null)
                parameters.Add("offset", offset.ToApiString());
            if (count != null)
                parameters.Add("count", count.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            return _vkontakte.RequestAsync<OrdersOrder[]>("orders.get", parameters);
        }

        ///<summary>
        /// Returns information about orders by their IDs.
        ///</summary>
        public Task<OrdersOrder[]> GetById(int? orderId = null, int[] orderIds = null, Boolean? testMode = null)
        {
            var parameters = new Dictionary<string, string>();
            if (orderId != null)
                parameters.Add("order_id", orderId.ToApiString());
            if (orderIds != null)
                parameters.Add("order_ids", orderIds.ToApiString());
            if (testMode != null)
                parameters.Add("test_mode", testMode.ToApiString());
            return _vkontakte.RequestAsync<OrdersOrder[]>("orders.getById", parameters);
        }
    }
}