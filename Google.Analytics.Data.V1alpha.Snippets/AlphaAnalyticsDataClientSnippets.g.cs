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

namespace Google.Analytics.Data.V1alpha.Snippets
{
    using Google.Analytics.Data.V1Alpha;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedAlphaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportAsync_RequestObject()
        {
            // Snippet: RunReportAsync(RunReportRequest,CallSettings)
            // Additional: RunReportAsync(RunReportRequest,CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest();
            // Make the request
            RunReportResponse response = await alphaAnalyticsDataClient.RunReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunReport</summary>
        public void RunReport_RequestObject()
        {
            // Snippet: RunReport(RunReportRequest,CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest();
            // Make the request
            RunReportResponse response = alphaAnalyticsDataClient.RunReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReportAsync</summary>
        public async Task RunPivotReportAsync_RequestObject()
        {
            // Snippet: RunPivotReportAsync(RunPivotReportRequest,CallSettings)
            // Additional: RunPivotReportAsync(RunPivotReportRequest,CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest();
            // Make the request
            RunPivotReportResponse response = await alphaAnalyticsDataClient.RunPivotReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunPivotReport</summary>
        public void RunPivotReport_RequestObject()
        {
            // Snippet: RunPivotReport(RunPivotReportRequest,CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            RunPivotReportRequest request = new RunPivotReportRequest();
            // Make the request
            RunPivotReportResponse response = alphaAnalyticsDataClient.RunPivotReport(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReportsAsync</summary>
        public async Task BatchRunReportsAsync_RequestObject()
        {
            // Snippet: BatchRunReportsAsync(BatchRunReportsRequest,CallSettings)
            // Additional: BatchRunReportsAsync(BatchRunReportsRequest,CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest();
            // Make the request
            BatchRunReportsResponse response = await alphaAnalyticsDataClient.BatchRunReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunReports</summary>
        public void BatchRunReports_RequestObject()
        {
            // Snippet: BatchRunReports(BatchRunReportsRequest,CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunReportsRequest request = new BatchRunReportsRequest();
            // Make the request
            BatchRunReportsResponse response = alphaAnalyticsDataClient.BatchRunReports(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReportsAsync</summary>
        public async Task BatchRunPivotReportsAsync_RequestObject()
        {
            // Snippet: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest,CallSettings)
            // Additional: BatchRunPivotReportsAsync(BatchRunPivotReportsRequest,CancellationToken)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = await AlphaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest();
            // Make the request
            BatchRunPivotReportsResponse response = await alphaAnalyticsDataClient.BatchRunPivotReportsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRunPivotReports</summary>
        public void BatchRunPivotReports_RequestObject()
        {
            // Snippet: BatchRunPivotReports(BatchRunPivotReportsRequest,CallSettings)
            // Create client
            AlphaAnalyticsDataClient alphaAnalyticsDataClient = AlphaAnalyticsDataClient.Create();
            // Initialize request argument(s)
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest();
            // Make the request
            BatchRunPivotReportsResponse response = alphaAnalyticsDataClient.BatchRunPivotReports(request);
            // End snippet
        }

    }
}
