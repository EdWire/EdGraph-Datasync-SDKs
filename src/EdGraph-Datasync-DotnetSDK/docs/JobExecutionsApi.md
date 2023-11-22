# EdGraph.Datasync.Client.Api.JobExecutionsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTenantDataSyncJobExecutions**](JobExecutionsApi.md#getalltenantdatasyncjobexecutions) | **GET** /tenants/{tenantId}/datasync/jobs/{jobId}/executions | Retrieves a list of DataSync Job Executions |

<a id="getalltenantdatasyncjobexecutions"></a>
# **GetAllTenantDataSyncJobExecutions**
> DataSyncApiJobExecutionV1JobExecutionListResponsePaginatedItemsViewModel GetAllTenantDataSyncJobExecutions (string tenantId, string jobId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync Job Executions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetAllTenantDataSyncJobExecutionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobExecutionsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync Job Executions
                DataSyncApiJobExecutionV1JobExecutionListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantDataSyncJobExecutions(tenantId, jobId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobExecutionsApi.GetAllTenantDataSyncJobExecutions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantDataSyncJobExecutionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync Job Executions
    ApiResponse<DataSyncApiJobExecutionV1JobExecutionListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantDataSyncJobExecutionsWithHttpInfo(tenantId, jobId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobExecutionsApi.GetAllTenantDataSyncJobExecutionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiJobExecutionV1JobExecutionListResponsePaginatedItemsViewModel**](DataSyncApiJobExecutionV1JobExecutionListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of DataSync job executions returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of DataSync job executions right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

