using System;
using Unity.Services.Leaderboards.Internal.Scheduler;

namespace Unity.Services.Leaderboards.Internal.Http
{
    /// <summary>
    /// Base Api Client.
    /// </summary>
    internal abstract class BaseApiClient
    {
        /// <summary>Instance of HttpClient.</summary>
        protected readonly IHttpClient HttpClient;

        /// <summary>Constructor.</summary>
        /// <param name="httpClient">BaseApiClient.</param>
        public BaseApiClient(IHttpClient httpClient)
        {
            HttpClient = httpClient ?? new HttpClient();
        }
    }
}
