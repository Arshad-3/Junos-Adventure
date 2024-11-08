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
    /// LeaderboardVersionWrapper model
    /// </summary>
    [Preserve]
    [DataContract(Name = "LeaderboardVersionWrapper")]
    internal class LeaderboardVersionWrapper
    {
        /// <summary>
        /// Creates an instance of LeaderboardVersionWrapper.
        /// </summary>
        /// <param name="version">version param</param>
        [Preserve]
        public LeaderboardVersionWrapper(LeaderboardVersion version = default)
        {
            Version = version;
        }

        /// <summary>
        /// Parameter version of LeaderboardVersionWrapper
        /// </summary>
        [Preserve]
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public LeaderboardVersion Version{ get; }

        /// <summary>
        /// Formats a LeaderboardVersionWrapper into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Version != null)
            {
                serializedModel += "version," + Version.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a LeaderboardVersionWrapper as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
