/*
 * DataSync Api
 *
 * DataSync Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Api;
// uncomment below to import models
//using EdGraph.Datasync.Client.Model;

namespace EdGraph.Datasync.Client.Test.Api
{
    /// <summary>
    ///  Class for testing ConnectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConnectionsApiTests : IDisposable
    {
        private ConnectionsApi instance;

        public ConnectionsApiTests()
        {
            instance = new ConnectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConnectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConnectionsApi
            //Assert.IsType<ConnectionsApi>(instance);
        }

        /// <summary>
        /// Test CreateTenantDataSyncConnection
        /// </summary>
        [Fact]
        public void CreateTenantDataSyncConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiConnectionV1CreateConnectionRequest? dataSyncApiConnectionV1CreateConnectionRequest = null;
            //instance.CreateTenantDataSyncConnection(tenantId, apiVersion, xVersion, dataSyncApiConnectionV1CreateConnectionRequest);
        }

        /// <summary>
        /// Test DeleteTenantDataSyncConnection
        /// </summary>
        [Fact]
        public void DeleteTenantDataSyncConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string connectionId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiConnectionV1DeleteConnectionRequest? dataSyncApiConnectionV1DeleteConnectionRequest = null;
            //instance.DeleteTenantDataSyncConnection(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1DeleteConnectionRequest);
        }

        /// <summary>
        /// Test GetAllTenantDataSyncConnections
        /// </summary>
        [Fact]
        public void GetAllTenantDataSyncConnectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllTenantDataSyncConnections(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetTenantDataSyncConnectionProfileById
        /// </summary>
        [Fact]
        public void GetTenantDataSyncConnectionProfileByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string connectionId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetTenantDataSyncConnectionProfileById(tenantId, connectionId, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiConnectionV1ConnectionProfileResponse>(response);
        }

        /// <summary>
        /// Test UpdateTenantDataSyncConnection
        /// </summary>
        [Fact]
        public void UpdateTenantDataSyncConnectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tenantId = null;
            //string connectionId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiConnectionV1UpdateConnectionRequest? dataSyncApiConnectionV1UpdateConnectionRequest = null;
            //instance.UpdateTenantDataSyncConnection(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1UpdateConnectionRequest);
        }
    }
}
