using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Types.Base
{
    public class ViewsInfo
    {
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}
