using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Unity.Services.Leaderboards.Internal.Models;
using Unity.Services.Leaderboards.Internal.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.Leaderboards.Internal.Leaderboards;
using UnityEngine;

namespace Unity.Services.Leaderboards.Internal.Apis.Leaderboards
{
    /// <summary>
    /// Interface for the LeaderboardsApiClient
    /// </summary>
    internal interface IInternalLeaderboardsApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Add Leaderboard Player Score.
            /// </summary>
            /// <param name="request">Request object for AddLeaderboardPlayerScore.</param>
            /// <param name="operationConfiguration">Configuration for AddLeaderboardPlayerScore.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardEntry object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardEntry>> AddLeaderboardPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.AddLeaderboardPlayerScoreRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Player Range.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardPlayerRange.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardPlayerRange.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScores object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardScores>> GetLeaderboardPlayerRangeAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardPlayerRangeRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Leaderboard Player Score.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardPlayerScore.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardPlayerScore.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardEntry object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardEntry>> GetLeaderboardPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardPlayerScoreRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Scores By PlayerIds.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardScoresByPlayerIds.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByPlayerIds.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScores object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardScoresWithNotFoundPlayerIds>> GetLeaderboardScoresByPlayerIdsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresByPlayerIdsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Leaderboard Scores By Tier.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardScoresByTier.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByTier.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardTierScoresPage object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardTierScoresPage>> GetLeaderboardScoresByTierAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresByTierRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Leaderboard Scores.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardScores.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardScores.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScoresPage object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardScoresPage>> GetLeaderboardScoresAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Player Range for Archived Leaderboard.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardVersionPlayerRange.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionPlayerRange.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScores object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersionScores>> GetLeaderboardVersionPlayerRangeAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionPlayerRangeRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Archived Leaderboard Version Player Score.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardVersionPlayerScore.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionPlayerScore.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionEntry object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersionEntry>> GetLeaderboardVersionPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionPlayerScoreRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Archived Leaderboard Version Scores.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardVersionScores.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionScores.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScoresPage object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersionScoresPage>> GetLeaderboardVersionScoresAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Scores By PlayerIds for Archived Leaderboard.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardScoresByPlayerIdsArchiveVersion.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByPlayerIdsArchiveVersion.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScoresByPlayerIds object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersionScoresWithNotFoundPlayerIds>> GetLeaderboardVersionScoresByPlayerIdsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresByPlayerIdsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Archived Leaderboard Version Scores By Tier.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardVersionScoresByTier.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionScoresByTier.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionTierScoresPage object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersionTierScoresPage>> GetLeaderboardVersionScoresByTierAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresByTierRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get Archived Leaderboard Versions.
            /// </summary>
            /// <param name="request">Request object for GetLeaderboardVersions.</param>
            /// <param name="operationConfiguration">Configuration for GetLeaderboardVersions.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersions object.</returns>
            /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.LeaderboardVersions>> GetLeaderboardVersionsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionsRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="ILeaderboardsApiClient"/>
    internal class InternalLeaderboardsApiClient : BaseApiClient, IInternalLeaderboardsApiClient
    {
        private IAccessToken _accessToken;
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration("https://leaderboards.services.api.unity.com", 10, 4, null);
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// LeaderboardsApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for LeaderboardsApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> LeaderboardsApiClient Configuration object.</param>
        public InternalLeaderboardsApiClient(IHttpClient httpClient,
            IAccessToken accessToken,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            _accessToken = accessToken;
        }


        /// <summary>
        /// Async Operation.
        /// Add Leaderboard Player Score.
        /// </summary>
        /// <param name="request">Request object for AddLeaderboardPlayerScore.</param>
        /// <param name="operationConfiguration">Configuration for AddLeaderboardPlayerScore.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardEntry object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardEntry>> AddLeaderboardPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.AddLeaderboardPlayerScoreRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardEntry)   },{"204",  null },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse =
                ResponseHandler.HandleAsyncResponse<Models.LeaderboardEntry>(response, statusCodeToTypeMap);

            return new Response<Models.LeaderboardEntry>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Player Range.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardPlayerRange.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardPlayerRange.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScores object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardScores>> GetLeaderboardPlayerRangeAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardPlayerRangeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardScores)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardScores>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardScores>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Leaderboard Player Score.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardPlayerScore.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardPlayerScore.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardEntry object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardEntry>> GetLeaderboardPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardPlayerScoreRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardEntry)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardEntry>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardEntry>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Scores By PlayerIds.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardScoresByPlayerIds.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByPlayerIds.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScores object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardScoresWithNotFoundPlayerIds>> GetLeaderboardScoresByPlayerIdsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresByPlayerIdsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardScores)   },{"401", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardScoresWithNotFoundPlayerIds>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardScoresWithNotFoundPlayerIds>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Leaderboard Scores By Tier.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardScoresByTier.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByTier.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardTierScoresPage object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardTierScoresPage>> GetLeaderboardScoresByTierAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresByTierRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardTierScoresPage)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardTierScoresPage>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardTierScoresPage>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Leaderboard Scores.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardScores.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardScores.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardScoresPage object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardScoresPage>> GetLeaderboardScoresAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardScoresRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardScoresPage)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardScoresPage>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardScoresPage>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Archived Leaderboard Version Player Score.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardVersionPlayerScore.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionPlayerScore.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionEntry object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersionEntry>> GetLeaderboardVersionPlayerScoreAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionPlayerScoreRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersionEntry)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersionEntry>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersionEntry>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Archived Leaderboard Version Scores.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardVersionScores.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionScores.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScoresPage object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersionScoresPage>> GetLeaderboardVersionScoresAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersionScoresPage)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersionScoresPage>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersionScoresPage>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Player Range for Archived Leaderboard.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardVersionPlayerRange.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionPlayerRange.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScores object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersionScores>> GetLeaderboardVersionPlayerRangeAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionPlayerRangeRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersionScores)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersionScores>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersionScores>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Archived Leaderboard Version Scores By Tier.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardVersionScoresByTier.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardVersionScoresByTier.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionTierScoresPage object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersionTierScoresPage>> GetLeaderboardVersionScoresByTierAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresByTierRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersionTierScoresPage)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersionTierScoresPage>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersionTierScoresPage>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Scores By PlayerIds for Archived Leaderboard.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardScoresByPlayerIdsArchiveVersion.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardScoresByPlayerIdsArchiveVersion.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersionScoresByPlayerIds object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersionScoresWithNotFoundPlayerIds>> GetLeaderboardVersionScoresByPlayerIdsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionScoresByPlayerIdsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersionScoresWithNotFoundPlayerIds)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersionScoresWithNotFoundPlayerIds>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersionScoresWithNotFoundPlayerIds>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get Archived Leaderboard Versions.
        /// </summary>
        /// <param name="request">Request object for GetLeaderboardVersions.</param>
        /// <param name="operationConfiguration">Configuration for GetLeaderboardVersions.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.LeaderboardVersions object.</returns>
        /// <exception cref="Unity.Services.Leaderboards.Internal.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.LeaderboardVersions>> GetLeaderboardVersionsAsync(Unity.Services.Leaderboards.Internal.Leaderboards.GetLeaderboardVersionsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.LeaderboardVersions)   },{"400", typeof(GetLeaderboardScores400OneOf)   },{"401", typeof(Models.BasicErrorResponse)   },{"403", typeof(Models.BasicErrorResponse)   },{"404", typeof(Models.BasicErrorResponse)   },{"429", typeof(Models.BasicErrorResponse)   },{"500", typeof(Models.BasicErrorResponse)   },{"503", typeof(Models.BasicErrorResponse)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.LeaderboardVersions>(response, statusCodeToTypeMap);
            return new Response<Models.LeaderboardVersions>(response, handledResponse);
        }

    }
}
