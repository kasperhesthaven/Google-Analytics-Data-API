// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gadv = Google.Analytics.Data.V1Alpha;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Analytics.Data.V1alpha
{
    /// <summary>
    /// Settings for a <see cref="AlphaAnalyticsDataClient"/>.
    /// </summary>
    public sealed partial class AlphaAnalyticsDataSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AlphaAnalyticsDataSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AlphaAnalyticsDataSettings"/>.
        /// </returns>
        public static AlphaAnalyticsDataSettings GetDefault() => new AlphaAnalyticsDataSettings();

        /// <summary>
        /// Constructs a new <see cref="AlphaAnalyticsDataSettings"/> object with default settings.
        /// </summary>
        public AlphaAnalyticsDataSettings() { }

        private AlphaAnalyticsDataSettings(AlphaAnalyticsDataSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunReportSettings = existing.RunReportSettings;
            RunPivotReportSettings = existing.RunPivotReportSettings;
            BatchRunReportsSettings = existing.BatchRunReportsSettings;
            BatchRunPivotReportsSettings = existing.BatchRunPivotReportsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlphaAnalyticsDataSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AlphaAnalyticsDataClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.RunReport</c> and <c>AlphaAnalyticsDataClient.RunReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlphaAnalyticsDataClient.RunReport</c> and
        /// <c>AlphaAnalyticsDataClient.RunReportAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RunReportSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.RunPivotReport</c> and <c>AlphaAnalyticsDataClient.RunPivotReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlphaAnalyticsDataClient.RunPivotReport</c> and
        /// <c>AlphaAnalyticsDataClient.RunPivotReportAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RunPivotReportSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.BatchRunReports</c> and <c>AlphaAnalyticsDataClient.BatchRunReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlphaAnalyticsDataClient.BatchRunReports</c> and
        /// <c>AlphaAnalyticsDataClient.BatchRunReportsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunReportsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlphaAnalyticsDataClient.BatchRunPivotReports</c> and <c>AlphaAnalyticsDataClient.BatchRunPivotReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlphaAnalyticsDataClient.BatchRunPivotReports</c> and
        /// <c>AlphaAnalyticsDataClient.BatchRunPivotReportsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunPivotReportsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AlphaAnalyticsDataSettings"/> object.</returns>
        public AlphaAnalyticsDataSettings Clone() => new AlphaAnalyticsDataSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlphaAnalyticsDataClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AlphaAnalyticsDataClientBuilder : gaxgrpc::ClientBuilderBase<AlphaAnalyticsDataClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public AlphaAnalyticsDataSettings Settings { get; set; }

        /// <inheritdoc/>
        public override AlphaAnalyticsDataClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlphaAnalyticsDataClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<AlphaAnalyticsDataClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlphaAnalyticsDataClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => AlphaAnalyticsDataClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AlphaAnalyticsDataClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlphaAnalyticsDataClient.ChannelPool;
    }

    /// <summary>
    /// AlphaAnalyticsData client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AlphaAnalyticsDataClient
    {
        /// <summary>
        /// The default endpoint for the AlphaAnalyticsData service, which is a host of "analyticsdata.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("analyticsdata.googleapis.com", 443);

        /// <summary>
        /// The default AlphaAnalyticsData scopes.
        /// </summary>
        /// <remarks>
        /// The default AlphaAnalyticsData scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/analytics"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/analytics.readonly"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/analytics",
            "https://www.googleapis.com/auth/analytics.readonly",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="AlphaAnalyticsDataClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Analytics.Data.V1alpha;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AlphaAnalyticsDataClient client = await AlphaAnalyticsDataClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Analytics.Data.V1alpha;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AlphaAnalyticsDataClient.DefaultEndpoint.Host, AlphaAnalyticsDataClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AlphaAnalyticsDataClient client = AlphaAnalyticsDataClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlphaAnalyticsDataSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static async stt::Task<AlphaAnalyticsDataClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AlphaAnalyticsDataSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AlphaAnalyticsDataClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Analytics.Data.V1alpha;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AlphaAnalyticsDataClient client = AlphaAnalyticsDataClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Analytics.Data.V1alpha;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AlphaAnalyticsDataClient.DefaultEndpoint.Host, AlphaAnalyticsDataClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AlphaAnalyticsDataClient client = AlphaAnalyticsDataClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlphaAnalyticsDataSettings"/>.</param>
        /// <returns>The created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static AlphaAnalyticsDataClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AlphaAnalyticsDataSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AlphaAnalyticsDataClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AlphaAnalyticsDataSettings"/>.</param>
        /// <returns>The created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static AlphaAnalyticsDataClient Create(grpccore::Channel channel, AlphaAnalyticsDataSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AlphaAnalyticsDataClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AlphaAnalyticsDataSettings"/>.</param>
        /// <returns>The created <see cref="AlphaAnalyticsDataClient"/>.</returns>
        public static AlphaAnalyticsDataClient Create(grpccore::CallInvoker callInvoker, AlphaAnalyticsDataSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient = new AlphaAnalyticsData.AlphaAnalyticsDataClient(callInvoker);
            return new AlphaAnalyticsDataClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AlphaAnalyticsDataSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AlphaAnalyticsDataSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AlphaAnalyticsDataSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AlphaAnalyticsDataSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AlphaAnalyticsData client.
        /// </summary>
        public virtual AlphaAnalyticsData.AlphaAnalyticsDataClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::RunReportResponse> RunReportAsync(
            gadv::RunReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::RunReportResponse> RunReportAsync(
            gadv::RunReportRequest request,
            st::CancellationToken cancellationToken) => RunReportAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gadv::RunReportResponse RunReport(
            gadv::RunReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::RunPivotReportResponse> RunPivotReportAsync(
            gadv::RunPivotReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::RunPivotReportResponse> RunPivotReportAsync(
            gadv::RunPivotReportRequest request,
            st::CancellationToken cancellationToken) => RunPivotReportAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gadv::RunPivotReportResponse RunPivotReport(
            gadv::RunPivotReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::BatchRunReportsResponse> BatchRunReportsAsync(
            gadv::BatchRunReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::BatchRunReportsResponse> BatchRunReportsAsync(
            gadv::BatchRunReportsRequest request,
            st::CancellationToken cancellationToken) => BatchRunReportsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gadv::BatchRunReportsResponse BatchRunReports(
            gadv::BatchRunReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(
            gadv::BatchRunPivotReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gadv::BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(
            gadv::BatchRunPivotReportsRequest request,
            st::CancellationToken cancellationToken) => BatchRunPivotReportsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gadv::BatchRunPivotReportsResponse BatchRunPivotReports(
            gadv::BatchRunPivotReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// AlphaAnalyticsData client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AlphaAnalyticsDataClientImpl : AlphaAnalyticsDataClient
    {
        private readonly gaxgrpc::ApiCall<gadv::RunReportRequest, gadv::RunReportResponse> _callRunReport;
        private readonly gaxgrpc::ApiCall<gadv::RunPivotReportRequest, gadv::RunPivotReportResponse> _callRunPivotReport;
        private readonly gaxgrpc::ApiCall<gadv::BatchRunReportsRequest, gadv::BatchRunReportsResponse> _callBatchRunReports;
        private readonly gaxgrpc::ApiCall<gadv::BatchRunPivotReportsRequest, gadv::BatchRunPivotReportsResponse> _callBatchRunPivotReports;

        /// <summary>
        /// Constructs a client wrapper for the AlphaAnalyticsData service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlphaAnalyticsDataSettings"/> used within this client </param>
        public AlphaAnalyticsDataClientImpl(AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient, AlphaAnalyticsDataSettings settings)
        {
            GrpcClient = grpcClient;
            AlphaAnalyticsDataSettings effectiveSettings = settings ?? AlphaAnalyticsDataSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRunReport = clientHelper.BuildApiCall<gadv::RunReportRequest, gadv::RunReportResponse>(
                GrpcClient.RunReportAsync, GrpcClient.RunReport, effectiveSettings.RunReportSettings);
            _callRunPivotReport = clientHelper.BuildApiCall<gadv::RunPivotReportRequest, gadv::RunPivotReportResponse>(
                GrpcClient.RunPivotReportAsync, GrpcClient.RunPivotReport, effectiveSettings.RunPivotReportSettings);
            _callBatchRunReports = clientHelper.BuildApiCall<gadv::BatchRunReportsRequest, gadv::BatchRunReportsResponse>(
                GrpcClient.BatchRunReportsAsync, GrpcClient.BatchRunReports, effectiveSettings.BatchRunReportsSettings);
            _callBatchRunPivotReports = clientHelper.BuildApiCall<gadv::BatchRunPivotReportsRequest, gadv::BatchRunPivotReportsResponse>(
                GrpcClient.BatchRunPivotReportsAsync, GrpcClient.BatchRunPivotReports, effectiveSettings.BatchRunPivotReportsSettings);
            Modify_ApiCall(ref _callRunReport);
            Modify_RunReportApiCall(ref _callRunReport);
            Modify_ApiCall(ref _callRunPivotReport);
            Modify_RunPivotReportApiCall(ref _callRunPivotReport);
            Modify_ApiCall(ref _callBatchRunReports);
            Modify_BatchRunReportsApiCall(ref _callBatchRunReports);
            Modify_ApiCall(ref _callBatchRunPivotReports);
            Modify_BatchRunPivotReportsApiCall(ref _callBatchRunPivotReports);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_RunReportApiCall(ref gaxgrpc::ApiCall<gadv::RunReportRequest, gadv::RunReportResponse> call);
        partial void Modify_RunPivotReportApiCall(ref gaxgrpc::ApiCall<gadv::RunPivotReportRequest, gadv::RunPivotReportResponse> call);
        partial void Modify_BatchRunReportsApiCall(ref gaxgrpc::ApiCall<gadv::BatchRunReportsRequest, gadv::BatchRunReportsResponse> call);
        partial void Modify_BatchRunPivotReportsApiCall(ref gaxgrpc::ApiCall<gadv::BatchRunPivotReportsRequest, gadv::BatchRunPivotReportsResponse> call);
        partial void OnConstruction(AlphaAnalyticsData.AlphaAnalyticsDataClient grpcClient, AlphaAnalyticsDataSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AlphaAnalyticsData client.
        /// </summary>
        public override AlphaAnalyticsData.AlphaAnalyticsDataClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_RunReportRequest(ref gadv::RunReportRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunPivotReportRequest(ref gadv::RunPivotReportRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchRunReportsRequest(ref gadv::BatchRunReportsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchRunPivotReportsRequest(ref gadv::BatchRunPivotReportsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gadv::RunReportResponse> RunReportAsync(
            gadv::RunReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized report of your Google Analytics event data. Reports
        /// contain statistics derived from data collected by the Google Analytics
        /// tracking code. The data returned from the API is as a table with columns
        /// for the requested dimensions and metrics. Metrics are individual
        /// measurements of user activity on your property, such as active users or
        /// event count. Dimensions break down metrics across some common criteria,
        /// such as country or event name.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gadv::RunReportResponse RunReport(
            gadv::RunReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunReportRequest(ref request, ref callSettings);
            return _callRunReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gadv::RunPivotReportResponse> RunPivotReportAsync(
            gadv::RunPivotReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a customized pivot report of your Google Analytics event data.
        /// Pivot reports are more advanced and expressive formats than regular
        /// reports. In a pivot report, dimensions are only visible if they are
        /// included in a pivot. Multiple pivots can be specified to further dissect
        /// your data.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gadv::RunPivotReportResponse RunPivotReport(
            gadv::RunPivotReportRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunPivotReportRequest(ref request, ref callSettings);
            return _callRunPivotReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gadv::BatchRunReportsResponse> BatchRunReportsAsync(
            gadv::BatchRunReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gadv::BatchRunReportsResponse BatchRunReports(
            gadv::BatchRunReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunReportsRequest(ref request, ref callSettings);
            return _callBatchRunReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gadv::BatchRunPivotReportsResponse> BatchRunPivotReportsAsync(
            gadv::BatchRunPivotReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Async(request, callSettings);
        }

        /// <summary>
        /// Returns multiple pivot reports in a batch. All reports must be for the same
        /// Entity.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gadv::BatchRunPivotReportsResponse BatchRunPivotReports(
            gadv::BatchRunPivotReportsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunPivotReportsRequest(ref request, ref callSettings);
            return _callBatchRunPivotReports.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
