
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine.Scripting;
using Unity.Services.Authentication.Shared;

namespace Unity.Services.Authentication.Generated
{
    /// <summary>
    /// The body that is returned for any failing request.  We are using the [RFC 7807 Error Format](https://www.rfc-editor.org/rfc/rfc7807.html#section-3.1).
    /// </summary>
    [DataContract(Name = "ErrorStatus")]
    [Preserve]
    internal partial class ErrorStatus
    {
        /// <summary>
        /// The HTTP status code of the response.
        /// </summary>
        /// <value>The HTTP status code of the response.</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public int Status { get; set; }

        /// <summary>
        /// A short, human-readable summary of the problem type.  It does not change between occurrences of the problem, except for purposes of localization.
        /// </summary>
        /// <value>A short, human-readable summary of the problem type.  It does not change between occurrences of the problem, except for purposes of localization.</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public string Title { get; set; }

        /// <summary>
        /// A human-readable explanation specific to this occurrence of the problem.
        /// </summary>
        /// <value>A human-readable explanation specific to this occurrence of the problem.</value>
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public string Detail { get; set; }

        /// <summary>
        /// An integer that uniquely identifies an error type.  This can be used to programmatically identify the type of error.
        /// </summary>
        /// <value>An integer that uniquely identifies an error type.  This can be used to programmatically identify the type of error.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        [Preserve]
        public int Code { get; set; }

        /// <summary>
        /// A list of additional details about specific errors.
        /// </summary>
        /// <value>A list of additional details about specific errors.</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        [Preserve]
        public List<Detail> Details { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorStatus" /> class.
        /// </summary>
        /// <param name="status">The HTTP status code of the response. (required).</param>
        /// <param name="title">A short, human-readable summary of the problem type.  It does not change between occurrences of the problem, except for purposes of localization. (required).</param>
        /// <param name="detail">A human-readable explanation specific to this occurrence of the problem. (required).</param>
        /// <param name="code">An integer that uniquely identifies an error type.  This can be used to programmatically identify the type of error. (required).</param>
        /// <param name="details">A list of additional details about specific errors..</param>
        [Preserve]
        public ErrorStatus(int status = default(int), string title = default(string), string detail = default(string), int code = default(int), List<Detail> details = default(List<Detail>))
        {
            this.Status = status;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for ErrorStatus and cannot be null");
            }
            this.Title = title;
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new ArgumentNullException("detail is a required property for ErrorStatus and cannot be null");
            }
            this.Detail = detail;
            this.Code = code;
            this.Details = details;
        }
    }

}