using System.Runtime.Serialization;

namespace VkLibrary.Core.Objects
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