# EdGraph.Datasync.Client.Api.ConnectionsEdFiApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTenantDataSyncConnectionEdFiDistricts**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfidistricts) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/districts | Retrieves a list of districts from an Ed-Fi API using the DataSync connection metadata |
| [**GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptors**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfieducationorganizationiddescriptors) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/educationorganizationidentificationsystemdescriptors | Retrieves a list of education organization identification system descriptors from an Ed-Fi API using the DataSync connection metadata |
| [**GetTenantDataSyncConnectionEdFiSchoolYears**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfischoolyears) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/schoolyears | Retrieves a list of school years from an Ed-Fi API using the DataSync connection metadata |
| [**GetTenantDataSyncConnectionEdFiStaffIdDescriptors**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfistaffiddescriptors) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/staffidentificationsystemdescriptors | Retrieves a list of staff identification system descriptors from an Ed-Fi API using the DataSync connection metadata |
| [**GetTenantDataSyncConnectionEdFiStudentIdDescriptors**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfistudentiddescriptors) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/studentidentificationsystemdescriptors | Retrieves a list of student identification system descriptors from an Ed-Fi API using the DataSync connection metadata |
| [**GetTenantDataSyncConnectionEdFiTermDescriptors**](ConnectionsEdFiApi.md#gettenantdatasyncconnectionedfitermdescriptors) | **GET** /tenants/{tenantId}/datasync/connections/{connectionId}/edfi/termdescriptors | Retrieves a list of term descriptors from an Ed-Fi API using the DataSync connection metadata |

<a id="gettenantdatasyncconnectionedfidistricts"></a>
# **GetTenantDataSyncConnectionEdFiDistricts**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiDistricts (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of districts from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiDistrictsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of districts from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiDistricts(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiDistricts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiDistrictsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of districts from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiDistrictsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiDistrictsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of districts returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your districts right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionedfieducationorganizationiddescriptors"></a>
# **GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptors**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptors (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of education organization identification system descriptors from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of education organization identification system descriptors from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptors(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of education organization identification system descriptors from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptorsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiEducationOrganizationIdDescriptorsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of student identification system descriptors returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your student identification system descriptors right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionedfischoolyears"></a>
# **GetTenantDataSyncConnectionEdFiSchoolYears**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiSchoolYears (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of school years from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiSchoolYearsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of school years from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiSchoolYears(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiSchoolYears: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiSchoolYearsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of school years from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiSchoolYearsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiSchoolYearsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of school years returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your school years right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionedfistaffiddescriptors"></a>
# **GetTenantDataSyncConnectionEdFiStaffIdDescriptors**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiStaffIdDescriptors (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of staff identification system descriptors from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiStaffIdDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of staff identification system descriptors from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiStaffIdDescriptors(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiStaffIdDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiStaffIdDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of staff identification system descriptors from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiStaffIdDescriptorsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiStaffIdDescriptorsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of student identification system descriptors returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your student identification system descriptors right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionedfistudentiddescriptors"></a>
# **GetTenantDataSyncConnectionEdFiStudentIdDescriptors**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiStudentIdDescriptors (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of student identification system descriptors from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiStudentIdDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of student identification system descriptors from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiStudentIdDescriptors(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiStudentIdDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiStudentIdDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of student identification system descriptors from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiStudentIdDescriptorsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiStudentIdDescriptorsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of student identification system descriptors returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your student identification system descriptors right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncconnectionedfitermdescriptors"></a>
# **GetTenantDataSyncConnectionEdFiTermDescriptors**
> List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt; GetTenantDataSyncConnectionEdFiTermDescriptors (string tenantId, string connectionId, string? apiVersion = null, string? xVersion = null)

Retrieves a list of term descriptors from an Ed-Fi API using the DataSync connection metadata

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncConnectionEdFiTermDescriptorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConnectionsEdFiApi(config);
            var tenantId = "tenantId_example";  // string | 
            var connectionId = "connectionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of term descriptors from an Ed-Fi API using the DataSync connection metadata
                List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse> result = apiInstance.GetTenantDataSyncConnectionEdFiTermDescriptors(tenantId, connectionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiTermDescriptors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncConnectionEdFiTermDescriptorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of term descriptors from an Ed-Fi API using the DataSync connection metadata
    ApiResponse<List<EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse>> response = apiInstance.GetTenantDataSyncConnectionEdFiTermDescriptorsWithHttpInfo(tenantId, connectionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConnectionsEdFiApi.GetTenantDataSyncConnectionEdFiTermDescriptorsWithHttpInfo: " + e.Message);
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

[**List&lt;EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse&gt;**](EdGraphPlatformHttpAggregatorsTenantApiControllersV1ViewModelsResponsesConnectionEdFiResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of term descriptors returned |  -  |
| **404** | DataSync connection not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your term descriptors right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

