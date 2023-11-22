# EdGraph.Datasync.Client.Api.JobExecutionLogsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllTenantDataSyncJobExecutionLogs**](JobExecutionLogsApi.md#getalltenantdatasyncjobexecutionlogs) | **GET** /tenants/{tenantId}/datasync/jobs/{jobId}/executions/{jobExecutionId}/logs | Retrieves a list of DataSync Job Execution Logs |

<a id="getalltenantdatasyncjobexecutionlogs"></a>
# **GetAllTenantDataSyncJobExecutionLogs**
> DataSyncApiJobExecutionLogV1JobExecutionLogEntryPaginatedItemsViewModel GetAllTenantDataSyncJobExecutionLogs (string tenantId, string jobId, string jobExecutionId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? search = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync Job Execution Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetAllTenantDataSyncJobExecutionLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobExecutionLogsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var jobExecutionId = "jobExecutionId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var search = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync Job Execution Logs
                DataSyncApiJobExecutionLogV1JobExecutionLogEntryPaginatedItemsViewModel result = apiInstance.GetAllTenantDataSyncJobExecutionLogs(tenantId, jobId, jobExecutionId, pageSize, pageIndex, orderBy, filter, search, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobExecutionLogsApi.GetAllTenantDataSyncJobExecutionLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantDataSyncJobExecutionLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync Job Execution Logs
    ApiResponse<DataSyncApiJobExecutionLogV1JobExecutionLogEntryPaginatedItemsViewModel> response = apiInstance.GetAllTenantDataSyncJobExecutionLogsWithHttpInfo(tenantId, jobId, jobExecutionId, pageSize, pageIndex, orderBy, filter, search, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobExecutionLogsApi.GetAllTenantDataSyncJobExecutionLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **jobExecutionId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **search** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiJobExecutionLogV1JobExecutionLogEntryPaginatedItemsViewModel**](DataSyncApiJobExecutionLogV1JobExecutionLogEntryPaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of DataSync job execution logs returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of DataSync job execution logs right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

