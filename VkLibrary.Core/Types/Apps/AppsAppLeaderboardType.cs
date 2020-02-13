using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Apps
{
    ///<summary>
    /// Leaderboard type
    ///</summary>
    public enum AppsAppLeaderboardType
    {
        [EnumMember(Value = "not supported")]
        NotSupported = 0,
        [EnumMember(Value = "levels")]
        Levels = 1,
        [EnumMember(Value = "points")]
        Points = 2
    }
}