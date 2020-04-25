using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallWallpostAttachment
    {
        ///<summary>
        /// Access key for the audio
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }
        [JsonProperty("album")]
        public PhotosPhotoAlbum Album { get; set; }
        [JsonProperty("app")]
        public WallAppPost App { get; set; }
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }
        [JsonProperty("doc")]
        public DocsDoc Doc { get; set; }
        [JsonProperty("event")]
        public EventsEventAttach Event { get; set; }
        [JsonProperty("group")]
        public GroupsGroupAttach Group { get; set; }
        [JsonProperty("graffiti")]
        public WallGraffiti Graffiti { get; set; }
        [JsonProperty("link")]
        public BaseLink Link { get; set; }
        [JsonProperty("market")]
        public MarketMarketItem Market { get; set; }
        [JsonProperty("market_album")]
        public MarketMarketAlbum MarketAlbum { get; set; }
        [JsonProperty("note")]
        public WallAttachedNote Note { get; set; }
        [JsonProperty("page")]
        public PagesWikipageFull Page { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("photos_list")]
        public String[] PhotosList { get; set; }
        [JsonProperty("poll")]
        public PollsPoll Poll { get; set; }
        [JsonProperty("posted_photo")]
        public WallPostedPhoto PostedPhoto { get; set; }
        [JsonProperty("type")]
        public WallWallpostAttachmentType Type { get; set; }
        [JsonProperty("video")]
        public VideoVideo Video { get; set; }
    }
}