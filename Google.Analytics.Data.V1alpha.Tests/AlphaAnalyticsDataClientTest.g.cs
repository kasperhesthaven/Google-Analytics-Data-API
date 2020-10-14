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

namespace Google.Analytics.Data.V1alpha.Tests
{
    using Google.Analytics.Data.V1Alpha;
    using apis = Google.Analytics.Data.V1alpha;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedAlphaAnalyticsDataClientTest
    {
        [Fact]
        public void RunReport()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            RunReportRequest request = new RunReportRequest();
            RunReportResponse expectedResponse = new RunReportResponse();
            mockGrpcClient.Setup(x => x.RunReport(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunReportResponse response = client.RunReport(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunReportAsync()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            RunReportRequest request = new RunReportRequest();
            RunReportResponse expectedResponse = new RunReportResponse();
            mockGrpcClient.Setup(x => x.RunReportAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RunReportResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunReportResponse response = await client.RunReportAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RunPivotReport()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            RunPivotReportRequest request = new RunPivotReportRequest();
            RunPivotReportResponse expectedResponse = new RunPivotReportResponse();
            mockGrpcClient.Setup(x => x.RunPivotReport(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunPivotReportResponse response = client.RunPivotReport(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RunPivotReportAsync()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            RunPivotReportRequest request = new RunPivotReportRequest();
            RunPivotReportResponse expectedResponse = new RunPivotReportResponse();
            mockGrpcClient.Setup(x => x.RunPivotReportAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RunPivotReportResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            RunPivotReportResponse response = await client.RunPivotReportAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchRunReports()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            BatchRunReportsRequest request = new BatchRunReportsRequest();
            BatchRunReportsResponse expectedResponse = new BatchRunReportsResponse();
            mockGrpcClient.Setup(x => x.BatchRunReports(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunReportsResponse response = client.BatchRunReports(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchRunReportsAsync()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            BatchRunReportsRequest request = new BatchRunReportsRequest();
            BatchRunReportsResponse expectedResponse = new BatchRunReportsResponse();
            mockGrpcClient.Setup(x => x.BatchRunReportsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchRunReportsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunReportsResponse response = await client.BatchRunReportsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BatchRunPivotReports()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest();
            BatchRunPivotReportsResponse expectedResponse = new BatchRunPivotReportsResponse();
            mockGrpcClient.Setup(x => x.BatchRunPivotReports(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunPivotReportsResponse response = client.BatchRunPivotReports(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchRunPivotReportsAsync()
        {
            Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient> mockGrpcClient = new Mock<AlphaAnalyticsData.AlphaAnalyticsDataClient>(MockBehavior.Strict);
            BatchRunPivotReportsRequest request = new BatchRunPivotReportsRequest();
            BatchRunPivotReportsResponse expectedResponse = new BatchRunPivotReportsResponse();
            mockGrpcClient.Setup(x => x.BatchRunPivotReportsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchRunPivotReportsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AlphaAnalyticsDataClient client = new AlphaAnalyticsDataClientImpl(mockGrpcClient.Object, null);
            BatchRunPivotReportsResponse response = await client.BatchRunPivotReportsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
