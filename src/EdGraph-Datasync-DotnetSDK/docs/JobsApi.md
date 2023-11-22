# EdGraph.Datasync.Client.Api.JobsApi

All URIs are relative to *https://api.edgraph.dev/tenant*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateTenantDataSyncJob**](JobsApi.md#activatetenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/activate | Activate a DataSync job matching the primary key |
| [**CancelTenantDataSyncJob**](JobsApi.md#canceltenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/cancel | Cancel a DataSync job matching the primary key |
| [**CreateTenantDataSyncJob**](JobsApi.md#createtenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/create | Creates a new DataSync job |
| [**DeactivateTenantDataSyncJob**](JobsApi.md#deactivatetenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/deactivate | Deactivate a DataSync job matching the primary key |
| [**DeleteTenantDataSyncJob**](JobsApi.md#deletetenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/delete | Delete a DataSync job matching the primary key |
| [**ExecuteTenantDataSyncJob**](JobsApi.md#executetenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/execute | Execute a DataSync job matching the primary key |
| [**GetAllTenantDataSyncJobs**](JobsApi.md#getalltenantdatasyncjobs) | **GET** /tenants/{tenantId}/datasync/jobs | Retrieves a list of DataSync Jobs |
| [**GetTenantDataSyncJobProfileById**](JobsApi.md#gettenantdatasyncjobprofilebyid) | **GET** /tenants/{tenantId}/datasync/jobs/{jobId} | Retrieves a specific DataSync job using its primary key |
| [**UpdateTenantDataSyncJob**](JobsApi.md#updatetenantdatasyncjob) | **POST** /tenants/{tenantId}/datasync/jobs/{jobId}/update | Updates a DataSync job matching the primary key |

<a id="activatetenantdatasyncjob"></a>
# **ActivateTenantDataSyncJob**
> void ActivateTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1ActivateJobRequest? dataSyncApiJobV1ActivateJobRequest = null)

Activate a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class ActivateTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1ActivateJobRequest = new DataSyncApiJobV1ActivateJobRequest?(); // DataSyncApiJobV1ActivateJobRequest? |  (optional) 

            try
            {
                // Activate a DataSync job matching the primary key
                apiInstance.ActivateTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1ActivateJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ActivateTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a DataSync job matching the primary key
    apiInstance.ActivateTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1ActivateJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ActivateTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1ActivateJobRequest** | [**DataSyncApiJobV1ActivateJobRequest?**](DataSyncApiJobV1ActivateJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job activated |  -  |
| **400** | DataSync job has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t activate your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="canceltenantdatasyncjob"></a>
# **CancelTenantDataSyncJob**
> void CancelTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1CancelJobRequest? dataSyncApiJobV1CancelJobRequest = null)

Cancel a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class CancelTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1CancelJobRequest = new DataSyncApiJobV1CancelJobRequest?(); // DataSyncApiJobV1CancelJobRequest? |  (optional) 

            try
            {
                // Cancel a DataSync job matching the primary key
                apiInstance.CancelTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1CancelJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.CancelTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel a DataSync job matching the primary key
    apiInstance.CancelTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1CancelJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.CancelTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1CancelJobRequest** | [**DataSyncApiJobV1CancelJobRequest?**](DataSyncApiJobV1CancelJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job cancellation requested |  -  |
| **400** | DataSync job cancellation request has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t cancel your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtenantdatasyncjob"></a>
# **CreateTenantDataSyncJob**
> void CreateTenantDataSyncJob (string tenantId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1CreateJobRequest? dataSyncApiJobV1CreateJobRequest = null)

Creates a new DataSync job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class CreateTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1CreateJobRequest = new DataSyncApiJobV1CreateJobRequest?(); // DataSyncApiJobV1CreateJobRequest? |  (optional) 

            try
            {
                // Creates a new DataSync job
                apiInstance.CreateTenantDataSyncJob(tenantId, apiVersion, xVersion, dataSyncApiJobV1CreateJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.CreateTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new DataSync job
    apiInstance.CreateTenantDataSyncJobWithHttpInfo(tenantId, apiVersion, xVersion, dataSyncApiJobV1CreateJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.CreateTenantDataSyncJobWithHttpInfo: " + e.Message);
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
| **dataSyncApiJobV1CreateJobRequest** | [**DataSyncApiJobV1CreateJobRequest?**](DataSyncApiJobV1CreateJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job created |  -  |
| **400** | DataSync job has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t create your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deactivatetenantdatasyncjob"></a>
# **DeactivateTenantDataSyncJob**
> void DeactivateTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1DeactivateJobRequest? dataSyncApiJobV1DeactivateJobRequest = null)

Deactivate a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class DeactivateTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1DeactivateJobRequest = new DataSyncApiJobV1DeactivateJobRequest?(); // DataSyncApiJobV1DeactivateJobRequest? |  (optional) 

            try
            {
                // Deactivate a DataSync job matching the primary key
                apiInstance.DeactivateTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1DeactivateJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.DeactivateTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate a DataSync job matching the primary key
    apiInstance.DeactivateTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1DeactivateJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.DeactivateTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1DeactivateJobRequest** | [**DataSyncApiJobV1DeactivateJobRequest?**](DataSyncApiJobV1DeactivateJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job deactivated |  -  |
| **400** | DataSync job has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t deactivate your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantdatasyncjob"></a>
# **DeleteTenantDataSyncJob**
> void DeleteTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1DeleteJobRequest? dataSyncApiJobV1DeleteJobRequest = null)

Delete a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class DeleteTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1DeleteJobRequest = new DataSyncApiJobV1DeleteJobRequest?(); // DataSyncApiJobV1DeleteJobRequest? |  (optional) 

            try
            {
                // Delete a DataSync job matching the primary key
                apiInstance.DeleteTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1DeleteJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.DeleteTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DataSync job matching the primary key
    apiInstance.DeleteTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1DeleteJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.DeleteTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1DeleteJobRequest** | [**DataSyncApiJobV1DeleteJobRequest?**](DataSyncApiJobV1DeleteJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job deleted |  -  |
| **400** | DataSync job has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t delete your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="executetenantdatasyncjob"></a>
# **ExecuteTenantDataSyncJob**
> void ExecuteTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1ExecuteJobRequest? dataSyncApiJobV1ExecuteJobRequest = null)

Execute a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class ExecuteTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1ExecuteJobRequest = new DataSyncApiJobV1ExecuteJobRequest?(); // DataSyncApiJobV1ExecuteJobRequest? |  (optional) 

            try
            {
                // Execute a DataSync job matching the primary key
                apiInstance.ExecuteTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1ExecuteJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ExecuteTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExecuteTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Execute a DataSync job matching the primary key
    apiInstance.ExecuteTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1ExecuteJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ExecuteTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1ExecuteJobRequest** | [**DataSyncApiJobV1ExecuteJobRequest?**](DataSyncApiJobV1ExecuteJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job execution requested |  -  |
| **400** | DataSync job execution request has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t execute your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantdatasyncjobs"></a>
# **GetAllTenantDataSyncJobs**
> DataSyncApiJobV1JobListResponsePaginatedItemsViewModel GetAllTenantDataSyncJobs (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync Jobs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetAllTenantDataSyncJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync Jobs
                DataSyncApiJobV1JobListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantDataSyncJobs(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetAllTenantDataSyncJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantDataSyncJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync Jobs
    ApiResponse<DataSyncApiJobV1JobListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantDataSyncJobsWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetAllTenantDataSyncJobsWithHttpInfo: " + e.Message);
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

[**DataSyncApiJobV1JobListResponsePaginatedItemsViewModel**](DataSyncApiJobV1JobListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of DataSync jobs returned |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve the list of DataSync jobs right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantdatasyncjobprofilebyid"></a>
# **GetTenantDataSyncJobProfileById**
> DataSyncApiJobV1JobProfileResponse GetTenantDataSyncJobProfileById (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific DataSync job using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class GetTenantDataSyncJobProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific DataSync job using its primary key
                DataSyncApiJobV1JobProfileResponse result = apiInstance.GetTenantDataSyncJobProfileById(tenantId, jobId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetTenantDataSyncJobProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantDataSyncJobProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific DataSync job using its primary key
    ApiResponse<DataSyncApiJobV1JobProfileResponse> response = apiInstance.GetTenantDataSyncJobProfileByIdWithHttpInfo(tenantId, jobId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetTenantDataSyncJobProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiJobV1JobProfileResponse**](DataSyncApiJobV1JobProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | DataSync job returned |  -  |
| **404** | DataSync job not found |  -  |
| **400** | Tenant has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t retrieve your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantdatasyncjob"></a>
# **UpdateTenantDataSyncJob**
> void UpdateTenantDataSyncJob (string tenantId, string jobId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobV1UpdateJobRequest? dataSyncApiJobV1UpdateJobRequest = null)

Updates a DataSync job matching the primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Datasync.Client.Api;
using EdGraph.Datasync.Client.Client;
using EdGraph.Datasync.Client.Model;

namespace Example
{
    public class UpdateTenantDataSyncJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.dev/tenant";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var jobId = "jobId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobV1UpdateJobRequest = new DataSyncApiJobV1UpdateJobRequest?(); // DataSyncApiJobV1UpdateJobRequest? |  (optional) 

            try
            {
                // Updates a DataSync job matching the primary key
                apiInstance.UpdateTenantDataSyncJob(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1UpdateJobRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.UpdateTenantDataSyncJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantDataSyncJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a DataSync job matching the primary key
    apiInstance.UpdateTenantDataSyncJobWithHttpInfo(tenantId, jobId, apiVersion, xVersion, dataSyncApiJobV1UpdateJobRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.UpdateTenantDataSyncJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **jobId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobV1UpdateJobRequest** | [**DataSyncApiJobV1UpdateJobRequest?**](DataSyncApiJobV1UpdateJobRequest?.md) |  | [optional]  |

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
| **202** | DataSync job updated |  -  |
| **400** | DataSync job has missing/invalid values |  -  |
| **403** | Missing the required permissions to access to this tenant/resource |  -  |
| **500** | Oops! Can&#39;t update your DataSync job right now |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

