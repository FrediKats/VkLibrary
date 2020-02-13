using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Audio;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersUserFull
    {
        ///<summary>
        /// User nickname
        ///</summary>
        [JsonProperty("nickname")]
        public String Nickname { get; set; }

        ///<summary>
        /// User maiden name
        ///</summary>
        [JsonProperty("maiden_name")]
        public String MaidenName { get; set; }

        ///<summary>
        /// Domain name of the user's page
        ///</summary>
        [JsonProperty("domain")]
        public String Domain { get; set; }

        ///<summary>
        /// User's date of birth
        ///</summary>
        [JsonProperty("bdate")]
        public String Bdate { get; set; }
        [JsonProperty("city")]
        public BaseObject City { get; set; }
        [JsonProperty("country")]
        public BaseCountry Country { get; set; }

        ///<summary>
        /// User's timezone
        ///</summary>
        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        ///<summary>
        /// URL of square photo of the user with 200 pixels in width
        ///</summary>
        [JsonProperty("photo_200")]
        public String Photo200 { get; set; }

        ///<summary>
        /// URL of square photo of the user with maximum width
        ///</summary>
        [JsonProperty("photo_max")]
        public String PhotoMax { get; set; }

        ///<summary>
        /// URL of user's photo with 200 pixels in width
        ///</summary>
        [JsonProperty("photo_200_orig")]
        public String Photo200Orig { get; set; }

        ///<summary>
        /// URL of user's photo with 400 pixels in width
        ///</summary>
        [JsonProperty("photo_400_orig")]
        public String Photo400Orig { get; set; }

        ///<summary>
        /// URL of user's photo of maximum size
        ///</summary>
        [JsonProperty("photo_max_orig")]
        public String PhotoMaxOrig { get; set; }

        ///<summary>
        /// ID of the user's main photo
        ///</summary>
        [JsonProperty("photo_id")]
        public String PhotoId { get; set; }

        ///<summary>
        /// Information whether the user has main photo
        ///</summary>
        [JsonProperty("has_photo")]
        public int HasPhoto { get; set; }

        ///<summary>
        /// Information whether the user specified his phone number
        ///</summary>
        [JsonProperty("has_mobile")]
        public int HasMobile { get; set; }

        ///<summary>
        /// Information whether the user is a friend of current user
        ///</summary>
        [JsonProperty("is_friend")]
        public int IsFriend { get; set; }

        ///<summary>
        /// Information whether current user can comment wall posts
        ///</summary>
        [JsonProperty("wall_comments")]
        public int WallComments { get; set; }

        ///<summary>
        /// Information whether current user can post on the user's wall
        ///</summary>
        [JsonProperty("can_post")]
        public int CanPost { get; set; }

        ///<summary>
        /// Information whether current user can see other users' audio on the wall
        ///</summary>
        [JsonProperty("can_see_all_posts")]
        public int CanSeeAllPosts { get; set; }

        ///<summary>
        /// Information whether current user can see the user's audio
        ///</summary>
        [JsonProperty("can_see_audio")]
        public int CanSeeAudio { get; set; }

        ///<summary>
        /// Information whether current user can write private message
        ///</summary>
        [JsonProperty("can_write_private_message")]
        public int CanWritePrivateMessage { get; set; }

        ///<summary>
        /// Information whether current user can send a friend request
        ///</summary>
        [JsonProperty("can_send_friend_request")]
        public int CanSendFriendRequest { get; set; }

        ///<summary>
        /// Information whether current user can see
        ///</summary>
        [JsonProperty("mobile_phone")]
        public String MobilePhone { get; set; }

        ///<summary>
        /// User's mobile phone number
        ///</summary>
        [JsonProperty("home_phone")]
        public String HomePhone { get; set; }

        ///<summary>
        /// User's website
        ///</summary>
        [JsonProperty("site")]
        public String Site { get; set; }
        [JsonProperty("status_audio")]
        public AudioAudio StatusAudio { get; set; }

        ///<summary>
        /// User's status
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// User's status
        ///</summary>
        [JsonProperty("activity")]
        public String Activity { get; set; }
        [JsonProperty("last_seen")]
        public UsersLastSeen LastSeen { get; set; }
        [JsonProperty("exports")]
        public UsersExports Exports { get; set; }
        [JsonProperty("crop_photo")]
        public UsersCropPhoto CropPhoto { get; set; }

        ///<summary>
        /// Number of user's followers
        ///</summary>
        [JsonProperty("followers_count")]
        public int FollowersCount { get; set; }

        ///<summary>
        /// Information whether current user is in the requested user's blacklist.
        ///</summary>
        [JsonProperty("blacklisted")]
        public int Blacklisted { get; set; }

        ///<summary>
        /// Information whether the requested user is in current user's blacklist
        ///</summary>
        [JsonProperty("blacklisted_by_me")]
        public int BlacklistedByMe { get; set; }

        ///<summary>
        /// Information whether the requested user is in faves of current user
        ///</summary>
        [JsonProperty("is_favorite")]
        public int IsFavorite { get; set; }

        ///<summary>
        /// Information whether the requested user is hidden from current user's newsfeed
        ///</summary>
        [JsonProperty("is_hidden_from_feed")]
        public int IsHiddenFromFeed { get; set; }

        ///<summary>
        /// Number of common friends with current user
        ///</summary>
        [JsonProperty("common_count")]
        public int CommonCount { get; set; }
        [JsonProperty("occupation")]
        public UsersOccupation Occupation { get; set; }
        [JsonProperty("career")]
        public UsersCareer[] Career { get; set; }
        [JsonProperty("military")]
        public UsersMilitary[] Military { get; set; }

        ///<summary>
        /// University ID
        ///</summary>
        [JsonProperty("university")]
        public int University { get; set; }

        ///<summary>
        /// University name
        ///</summary>
        [JsonProperty("university_name")]
        public String UniversityName { get; set; }

        ///<summary>
        /// Faculty ID
        ///</summary>
        [JsonProperty("faculty")]
        public int Faculty { get; set; }

        ///<summary>
        /// Faculty name
        ///</summary>
        [JsonProperty("faculty_name")]
        public String FacultyName { get; set; }

        ///<summary>
        /// Graduation year
        ///</summary>
        [JsonProperty("graduation")]
        public int Graduation { get; set; }

        ///<summary>
        /// Education form
        ///</summary>
        [JsonProperty("education_form")]
        public String EducationForm { get; set; }

        ///<summary>
        /// User's education status
        ///</summary>
        [JsonProperty("education_status")]
        public String EducationStatus { get; set; }

        ///<summary>
        /// User hometown
        ///</summary>
        [JsonProperty("home_town")]
        public String HomeTown { get; set; }

        ///<summary>
        /// User relationship status
        ///</summary>
        [JsonProperty("relation")]
        public UsersUserRelation Relation { get; set; }
        [JsonProperty("relation_partner")]
        public UsersUserMin RelationPartner { get; set; }
        [JsonProperty("personal")]
        public UsersPersonal Personal { get; set; }
        [JsonProperty("universities")]
        public UsersUniversity[] Universities { get; set; }
        [JsonProperty("schools")]
        public UsersSchool[] Schools { get; set; }
        [JsonProperty("relatives")]
        public UsersRelative[] Relatives { get; set; }

        ///<summary>
        /// Information whether current user is subscribed to podcasts
        ///</summary>
        [JsonProperty("is_subscribed_podcasts")]
        public Boolean IsSubscribedPodcasts { get; set; }

        ///<summary>
        /// Owner in whitelist or not
        ///</summary>
        [JsonProperty("can_subscribe_podcasts")]
        public Boolean CanSubscribePodcasts { get; set; }

        ///<summary>
        /// Can subscribe to wall
        ///</summary>
        [JsonProperty("can_subscribe_posts")]
        public Boolean CanSubscribePosts { get; set; }
    }
}