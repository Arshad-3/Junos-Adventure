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
    /// LeaderboardTierScoresPage1AllOf model
    /// </summary>
    [Preserve]
    [DataContract(Name = "LeaderboardTierScoresPage_1_allOf")]
    internal class LeaderboardTierScoresPage1AllOf
    {
        /// <summary>
        /// Creates an instance of LeaderboardTierScoresPage1AllOf.
        /// </summary>
        /// <param name="tier">tier param</param>
        [Preserve]
        public LeaderboardTierScoresPage1AllOf(string tier = default)
        {
            Tier = tier;
        }

        /// <summary>
        /// Parameter tier of LeaderboardTierScoresPage1AllOf
        /// </summary>
        [Preserve]
        [DataMember(Name = "tier", EmitDefaultValue = false)]
        public string Tier{ get; }
    
        /// <summary>
        /// Formats a LeaderboardTierScoresPage1AllOf into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Tier != null)
            {
                serializedModel += "tier," + Tier;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a LeaderboardTierScoresPage1AllOf as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Tier != null)
            {
                var tierStringValue = Tier.ToString();
                dictionary.Add("tier", tierStringValue);
            }
            
            return dictionary;
        }
    }
}