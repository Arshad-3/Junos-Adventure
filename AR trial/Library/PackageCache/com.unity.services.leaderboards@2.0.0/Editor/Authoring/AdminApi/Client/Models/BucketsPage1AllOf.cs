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
    /// BucketsPage1AllOf model
    /// </summary>
    [Preserve]
    [DataContract(Name = "BucketsPage_1_allOf")]
    internal class BucketsPage1AllOf
    {
        /// <summary>
        /// Creates an instance of BucketsPage1AllOf.
        /// </summary>
        /// <param name="results">results param</param>
        [Preserve]
        public BucketsPage1AllOf(List<string> results = default)
        {
            Results = results;
        }

        /// <summary>
        /// Parameter results of BucketsPage1AllOf
        /// </summary>
        [Preserve]
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<string> Results{ get; }
    
        /// <summary>
        /// Formats a BucketsPage1AllOf into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Results != null)
            {
                serializedModel += "results," + Results.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a BucketsPage1AllOf as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Results != null)
            {
                var resultsStringValue = Results.ToString();
                dictionary.Add("results", resultsStringValue);
            }
            
            return dictionary;
        }
    }
}