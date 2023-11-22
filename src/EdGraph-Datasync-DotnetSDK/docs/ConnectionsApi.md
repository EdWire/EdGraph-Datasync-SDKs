# EdGraph.Datasync.Client.Api.ConnectionsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTenantDataSyncConnection**](ConnectionsApi.md#createtenantdatasyncconnection) | **POST** /tenants/{tenantId}/datasync/connections/create | Creates a new DataSync connection |
| [**DeleteTenantDataSyncConnection**](ConnectionsApi.md#deletetenantdatasyncconnection) | **POST** /tenants/{tenantId}/datasync/connections/{connectionId}/delete | Delete a DataSync connection matching the primary key |
| [**GetAllTenantDataSyncConnections**](ConnectionsApi.md#getalltenantdatasyncconnections) | **GET** /tenants/{tenantId}/datasync/connections | Retrieves a list of DataSync Connections |
| [**GetTenantDataSyncConnectionProfileById**](ConnectionsApi.md#gettenantdatasyncconnectionprofilebyid) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId} | Retrieves a specific DataSync connection using its primary key |
| [**UpdateTenantDataSyncConnection**](ConnectionsApi.md#updatetenantdatasyncconnection) | **POST** /tenants/{tenantId}/datasync/connections/{connectionId}/update | Updates a DataSync connection matching the primary key |

<a id="createtenantdatasyncconnection"></a>
# **CreateTenantDataSyncConnection**
> void CreateTenantDataSyncConnection (string tenantId, string? apiVersion = null, string? xVersion = null, DataSyncApiConnectionV1CreateConnectionRequest? dataSyncApiConnectionV1CreateConnectionRequest = null)

Creates a new DataSync connection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class CreateTenantDataSyncConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiConnectionV1CreateConnectionRequest = new DataSyncApiConnectionV1CreateConnectionRequest?(); // DataSyncApiConnectionV1CreateConnectionRequest? |  (optional) 

            try
            {
                // Creates a new DataSync connection
                apiInstance.CreateTenantDataSyncConnection(tenantId, apiVersion, xVersion, dataSyncApiConnectionV1CreateConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.CreateTenantDataSyncConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantDataSyncConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new DataSync connection
    apiInstance.CreateTenantDataSyncConnectionWithHttpInfo(tenantId, apiVersion, xVersion, dataSyncApiConnectionV1CreateConnectionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.CreateTenantDataSyncConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiConnectionV1CreateConnectionRequest** | [**DataSyncApiConnectionV1CreateConnectionRequest?**](DataSyncApiConnectionV1CreateConnectionRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | DataSync connection created |  -  |
| **400** | DataSync connection has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create your DataSync connection right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantdatasyncconnection"></a>
# **DeleteTenantDataSyncConnection**
> void DeleteTenantDataSyncConnection (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null, DataSyncApiConnectionV1DeleteConnectionRequest? dataSyncApiConnectionV1DeleteConnectionRequest = null)

Delete a DataSync connection matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class DeleteTenantDataSyncConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiConnectionV1DeleteConnectionRequest = new DataSyncApiConnectionV1DeleteConnectionRequest?(); // DataSyncApiConnectionV1DeleteConnectionRequest? |  (optional) 

            try
            {
                // Delete a DataSync connection matching the primary key
                apiInstance.DeleteTenantDataSyncConnection(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1DeleteConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.DeleteTenantDataSyncConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantDataSyncConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DataSync connection matching the primary key
    apiInstance.DeleteTenantDataSyncConnectionWithHttpInfo(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1DeleteConnectionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.DeleteTenantDataSyncConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **connectionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiConnectionV1DeleteConnectionRequest** | [**DataSyncApiConnectionV1DeleteConnectionRequest?**](DataSyncApiConnectionV1DeleteConnectionRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | DataSync connection deleted |  -  |
| **400** | DataSync connection has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t delete your DataSync connection right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantdatasyncconnections"></a>
# **GetAllTenantDataSyncConnections**
> DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel GetAllTenantDataSyncConnections (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync Connections

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetAllTenantDataSyncConnectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync Connections
                DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantDataSyncConnections(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetAllTenantDataSyncConnections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantDataSyncConnectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync Connections
    ApiResponse<DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantDataSyncConnectionsWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetAllTenantDataSyncConnectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel**](DataSyncApiConnectionV1ConnectionListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of DataSync connections returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of DataSync connections right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionprofilebyid"></a>
# **GetTenantDataSyncConnectionProfileById**
> DataSyncApiConnectionV1ConnectionProfileResponse GetTenantDataSyncConnectionProfileById (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific DataSync connection using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific DataSync connection using its primary key
                DataSyncApiConnectionV1ConnectionProfileResponse result = apiInstance.GetTenantDataSyncConnectionProfileById(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.GetTenantDataSyncConnectionProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific DataSync connection using its primary key
    ApiResponse<DataSyncApiConnectionV1ConnectionProfileResponse> response = apiInstance.GetTenantDataSyncConnectionProfileByIdWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.GetTenantDataSyncConnectionProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **connectionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiConnectionV1ConnectionProfileResponse**](DataSyncApiConnectionV1ConnectionProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DataSync connection returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your DataSync connection right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantdatasyncconnection"></a>
# **UpdateTenantDataSyncConnection**
> void UpdateTenantDataSyncConnection (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null, DataSyncApiConnectionV1UpdateConnectionRequest? dataSyncApiConnectionV1UpdateConnectionRequest = null)

Updates a DataSync connection matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class UpdateTenantDataSyncConnectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiConnectionV1UpdateConnectionRequest = new DataSyncApiConnectionV1UpdateConnectionRequest?(); // DataSyncApiConnectionV1UpdateConnectionRequest? |  (optional) 

            try
            {
                // Updates a DataSync connection matching the primary key
                apiInstance.UpdateTenantDataSyncConnection(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1UpdateConnectionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsApi.UpdateTenantDataSyncConnection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantDataSyncConnectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a DataSync connection matching the primary key
    apiInstance.UpdateTenantDataSyncConnectionWithHttpInfo(tenantId, connectionId, apiVersion, xVersion, dataSyncApiConnectionV1UpdateConnectionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsApi.UpdateTenantDataSyncConnectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **connectionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiConnectionV1UpdateConnectionRequest** | [**DataSyncApiConnectionV1UpdateConnectionRequest?**](DataSyncApiConnectionV1UpdateConnectionRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | DataSync connection updated |  -  |
| **400** | DataSync connection has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t update your DataSync connection right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

