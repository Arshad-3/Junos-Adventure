using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Leaderboards.Internal.Http;



namespace Unity.Services.Leaderboards.Internal.Models
{
    /// <summary>
    /// LeaderboardScores model
    /// </summary>
    [Preserve]
    [DataContract(Name = "LeaderboardVersionScores")]
    internal class LeaderboardVersionScores
    {
        /// <summary>
        /// Creates an instance of LeaderboardScores.
        /// </summary>
        /// <param name="results">results param</param>
        [Preserve]
        public LeaderboardVersionScores(LeaderboardVersion version = default, List<LeaderboardEntry> results = default)
        {
            Version = version;
            Results = results;
        }

        /// <summary>
        /// Parameter version of LeaderboardVersionScoresPage
        /// </summary>
        [Preserve]
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public LeaderboardVersion Version{ get; }

        /// <summary>
        /// Parameter results of LeaderboardScores
        /// </summary>
        [Preserve]
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<LeaderboardEntry> Results{ get; }

        /// <summary>
        /// Formats a LeaderboardScores into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";
            if (Version != null)
            {
                serializedModel += "version," + Version.ToString() + ",";
            }

            if (Results != null)
            {
                serializedModel += "results," + Results.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a LeaderboardScores as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
