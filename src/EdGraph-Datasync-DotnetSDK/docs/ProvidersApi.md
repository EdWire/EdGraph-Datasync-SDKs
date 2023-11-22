# EdGraph.Datasync.Client.Api.ProvidersApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTenantDataSyncProviders**](ProvidersApi.md#getalltenantdatasyncproviders) | **GET** /tenants/{tenantId}/datasync/providers | Retrieves a list of DataSync providers |
| [**GetTenantDataSyncProviderProfileById**](ProvidersApi.md#gettenantdatasyncproviderprofilebyid) | **GET** /tenants/{tenantId}/datasync/providers/{providerId} | Retrieves a specific DataSync provider using its primary key |

<a id="getalltenantdatasyncproviders"></a>
# **GetAllTenantDataSyncProviders**
> DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel GetAllTenantDataSyncProviders (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync providers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetAllTenantDataSyncProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync providers
                DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantDataSyncProviders(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetAllTenantDataSyncProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantDataSyncProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync providers
    ApiResponse<DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantDataSyncProvidersWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetAllTenantDataSyncProvidersWithHttpInfo: " + e.Message);
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

[**DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel**](DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of DataSync providers returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of DataSync providers right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncproviderprofilebyid"></a>
# **GetTenantDataSyncProviderProfileById**
> DataSyncApiProviderV1ProviderProfileResponse GetTenantDataSyncProviderProfileById (string tenantId, string providerId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific DataSync provider using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncProviderProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvidersApi(config);
            var tenantId = "tenantId_example";  // string | 
            var providerId = "providerId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific DataSync provider using its primary key
                DataSyncApiProviderV1ProviderProfileResponse result = apiInstance.GetTenantDataSyncProviderProfileById(tenantId, providerId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvidersApi.GetTenantDataSyncProviderProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncProviderProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific DataSync provider using its primary key
    ApiResponse<DataSyncApiProviderV1ProviderProfileResponse> response = apiInstance.GetTenantDataSyncProviderProfileByIdWithHttpInfo(tenantId, providerId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvidersApi.GetTenantDataSyncProviderProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **providerId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ProviderProfileResponse**](DataSyncApiProviderV1ProviderProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DataSync provider returned |  -  |
| **404** | DataSync provider not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your DataSync provider right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

