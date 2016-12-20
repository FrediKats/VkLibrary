using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class UserFull : VkLib.Types.Users.User
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("relatives")]
        public IEnumerable<VkLib.Types.Users.Relative> Relatives { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("military")]
        public IEnumerable<VkLib.Types.Users.Military> Military { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("crop_photo")]
        public VkLib.Types.Users.CropPhoto CropPhoto { get; set; }

        /// <summary>
        /// Information whether current user is in the requested user's blacklist.
        /// </summary>
        [JsonProperty("blacklisted")]
        public int? Blacklisted { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("schools")]
        public IEnumerable<VkLib.Types.Users.School> Schools { get; set; }

        /// <summary>
        /// ID of the user's main photo
        /// </summary>
        [JsonProperty("photo_id")]
        public string PhotoId { get; set; }

        /// <summary>
        /// URL of user's photo of maximum size
        /// </summary>
        [JsonProperty("photo_max_orig")]
        public string PhotoMaxOrig { get; set; }

        /// <summary>
        /// Information whether the user is a friend of current user
        /// </summary>
        [JsonProperty("is_friend")]
        public int? IsFriend { get; set; }

        /// <summary>
        /// Number of common friends with current user
        /// </summary>
        [JsonProperty("common_count")]
        public int? CommonCount { get; set; }

        /// <summary>
        /// University ID
        /// </summary>
        [JsonProperty("university")]
        public int? University { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("status_audio")]
        public VkLib.Types.Audio.AudioFull StatusAudio { get; set; }

        /// <summary>
        /// User's favorite games
        /// </summary>
        [JsonProperty("games")]
        public string Games { get; set; }

        /// <summary>
        /// Information whether the user has main photo
        /// </summary>
        [JsonProperty("has_photo")]
        public int? HasPhoto { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("relation_partner")]
        public VkLib.Types.Users.UserMin RelationPartner { get; set; }

        /// <summary>
        /// Information whether current user can see the user's audio
        /// </summary>
        [JsonProperty("can_see_audio")]
        public int? CanSeeAudio { get; set; }

        /// <summary>
        /// User's Skype nickname
        /// </summary>
        [JsonProperty("skype")]
        public string Skype { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("last_seen")]
        public VkLib.Types.Users.LastSeen LastSeen { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("city")]
        public VkLib.Types.Base.Object City { get; set; }

        /// <summary>
        /// University name
        /// </summary>
        [JsonProperty("university_name")]
        public string UniversityName { get; set; }

        /// <summary>
        /// User's status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// URL of square photo of the user with 200 pixels in width
        /// </summary>
        [JsonProperty("photo_200")]
        public string Photo200 { get; set; }

        /// <summary>
        /// User relationship status
        /// </summary>
        [JsonProperty("relation")]
        public int? Relation { get; set; }

        /// <summary>
        /// User's timezone
        /// </summary>
        [JsonProperty("timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// User's Instagram account
        /// </summary>
        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("exports")]
        public VkLib.Types.Users.Exports Exports { get; set; }

        /// <summary>
        /// User maiden name
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// User's favorite music
        /// </summary>
        [JsonProperty("music")]
        public string Music { get; set; }

        /// <summary>
        /// About me field
        /// </summary>
        [JsonProperty("about")]
        public string About { get; set; }

        /// <summary>
        /// User's date of birth
        /// </summary>
        [JsonProperty("bdate")]
        public string Bdate { get; set; }

        /// <summary>
        /// Information whether current user can comment wall posts
        /// </summary>
        [JsonProperty("wall_comments")]
        public int? WallComments { get; set; }

        /// <summary>
        /// Information whether the requested user is in current user's blacklist
        /// </summary>
        [JsonProperty("blacklisted_by_me")]
        public int? BlacklistedByMe { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("universities")]
        public IEnumerable<VkLib.Types.Users.University> Universities { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("career")]
        public IEnumerable<VkLib.Types.Users.Career> Career { get; set; }

        /// <summary>
        /// User hometown
        /// </summary>
        [JsonProperty("home_town")]
        public string HomeTown { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("personal")]
        public VkLib.Types.Users.Personal Personal { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("occupation")]
        public VkLib.Types.Users.Occupation Occupation { get; set; }

        /// <summary>
        /// Information whether the requested user is in faves of current user
        /// </summary>
        [JsonProperty("is_favorite")]
        public int? IsFavorite { get; set; }

        /// <summary>
        /// Domain name of the user's page
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// URL of user's photo with 200 pixels in width
        /// </summary>
        [JsonProperty("photo_200_orig")]
        public string Photo200Orig { get; set; }

        /// <summary>
        /// Information whether the requested user is hidden from current user's newsfeed
        /// </summary>
        [JsonProperty("is_hidden_from_feed")]
        public int? IsHiddenFromFeed { get; set; }

        /// <summary>
        /// Education form
        /// </summary>
        [JsonProperty("education_form")]
        public string EducationForm { get; set; }

        /// <summary>
        /// User's favorite movies
        /// </summary>
        [JsonProperty("movies")]
        public string Movies { get; set; }

        /// <summary>
        /// Information whether current user can post on the user's wall
        /// </summary>
        [JsonProperty("can_post")]
        public int? CanPost { get; set; }

        /// <summary>
        /// User's Livejournal account
        /// </summary>
        [JsonProperty("livejournal")]
        public string Livejournal { get; set; }

        /// <summary>
        /// URL of square photo of the user with maximum width
        /// </summary>
        [JsonProperty("photo_max")]
        public string PhotoMax { get; set; }

        /// <summary>
        /// Friend status for current user
        /// </summary>
        [JsonProperty("friend_status")]
        public int? FriendStatus { get; set; }

        /// <summary>
        /// Information whether current user can see
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Faculty name
        /// </summary>
        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// User's education status
        /// </summary>
        [JsonProperty("education_status")]
        public string EducationStatus { get; set; }

        /// <summary>
        /// URL of user's photo with 400 pixels in width
        /// </summary>
        [JsonProperty("photo_400_orig")]
        public string Photo400Orig { get; set; }

        /// <summary>
        /// User's favorite books
        /// </summary>
        [JsonProperty("books")]
        public string Books { get; set; }

        /// <summary>
        /// Number of user's followers
        /// </summary>
        [JsonProperty("followers_count")]
        public int? FollowersCount { get; set; }

        /// <summary>
        /// Graduation year
        /// </summary>
        [JsonProperty("graduation")]
        public int? Graduation { get; set; }

        /// <summary>
        /// Information whether current user can send a friend request
        /// </summary>
        [JsonProperty("can_send_friend_request")]
        public int? CanSendFriendRequest { get; set; }

        /// <summary>
        /// User's Facebook account
        /// </summary>
        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        /// <summary>
        /// Information whether current user can see other users' audio on the wall
        /// </summary>
        [JsonProperty("can_see_all_posts")]
        public int? CanSeeAllPosts { get; set; }

        /// <summary>
        /// Information whether the user specified his phone number
        /// </summary>
        [JsonProperty("has_mobile")]
        public int? HasMobile { get; set; }

        /// <summary>
        /// User's Twitter account
        /// </summary>
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        /// <summary>
        /// User's mobile phone number
        /// </summary>
        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Information whether current user can write private message
        /// </summary>
        [JsonProperty("can_write_private_message")]
        public int? CanWritePrivateMessage { get; set; }

        /// <summary>
        /// Faculty ID
        /// </summary>
        [JsonProperty("faculty")]
        public int? Faculty { get; set; }

        /// <summary>
        /// User nickname
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Information whether the user is verified
        /// </summary>
        [JsonProperty("verified")]
        public int? Verified { get; set; }

        /// <summary>
        /// User's activities
        /// </summary>
        [JsonProperty("activities")]
        public string Activities { get; set; }

        /// <summary>
        /// Favorite quotes
        /// </summary>
        [JsonProperty("quotes")]
        public string Quotes { get; set; }

        /// <summary>
        /// User's Facebook name
        /// </summary>
        [JsonProperty("facebook_name")]
        public string FacebookName { get; set; }

        /// <summary>
        /// User's website
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// User's status
        /// </summary>
        [JsonProperty("activity")]
        public string Activity { get; set; }

        /// <summary>
        /// User's favorite tv shows
        /// </summary>
        [JsonProperty("tv")]
        public string Tv { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("country")]
        public VkLib.Types.Base.Country Country { get; set; }

        /// <summary>
        /// User's interests
        /// </summary>
        [JsonProperty("interests")]
        public string Interests { get; set; }

    }
}
