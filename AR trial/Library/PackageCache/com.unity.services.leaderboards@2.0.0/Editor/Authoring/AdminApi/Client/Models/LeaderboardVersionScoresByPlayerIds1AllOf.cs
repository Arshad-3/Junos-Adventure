//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Leaderboards.Authoring.Client.Http;



namespace Unity.Services.Leaderboards.Authoring.Client.Models
{
    /// <summary>
    /// LeaderboardVersionScoresByPlayerIds1AllOf model
    /// </summary>
    [Preserve]
    [DataContract(Name = "LeaderboardVersionScoresByPlayerIds_1_allOf")]
    internal class LeaderboardVersionScoresByPlayerIds1AllOf
    {
        /// <summary>
        /// Creates an instance of LeaderboardVersionScoresByPlayerIds1AllOf.
        /// </summary>
        /// <param name="version">version param</param>
        [Preserve]
        public LeaderboardVersionScoresByPlayerIds1AllOf(LeaderboardVersion1 version = default)
        {
            Version = version;
        }

        /// <summary>
        /// Parameter version of LeaderboardVersionScoresByPlayerIds1AllOf
        /// </summary>
        [Preserve]
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public LeaderboardVersion1 Version{ get; }
    
        /// <summary>
        /// Formats a LeaderboardVersionScoresByPlayerIds1AllOf into a string of key-value pairs for use as a path parameter.
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
        /// Returns a LeaderboardVersionScoresByPlayerIds1AllOf as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
