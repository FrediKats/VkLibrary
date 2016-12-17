using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{
    public class Users
    {
        private Vkontakte _vkontakte;

        internal Users(Vkontakte vkontakte)
        {
            _vkontakte = vkontakte;
        }

        /// <summary>
        /// Adds an item to one or multiple collections.
        /// Docs: <see href="https://vk.com/dev/market.addToAlbum">market.addToAlbum</see>
        /// </summary>
        /// <param name="owner_id">ID of an item owner community.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="album_ids">Collections IDs to add item to.</param>
        public async Task<string> AddToAlbum(int? owner_id = null, int? item_id = null, IEnumerable<int?> album_ids = null)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (owner_id != null)
                parameters.Add("owner_id", owner_id.ToString());
            if (item_id != null)
                parameters.Add("item_id", item_id.ToString());
            if (album_ids != null)
                parameters.Add("album_ids", string.Join(",", album_ids));
            return await _vkontakte.GetAsync("market.addToAlbum", parameters);
        }

    }
}
