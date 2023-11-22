# EdGraph.Datasync.Client.Model.DataSyncApiJobV1UpdateJobRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **string** |  | [optional] 
**JobId** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**SourceConnectionId** | **string** |  | [optional] 
**DestinationConnectionId** | **string** |  | [optional] 
**ProfileId** | **string** |  | [optional] 
**JobPoints** | **int** |  | [optional] 
**ApplicationId** | **string** |  | [optional] 
**DataRefreshType** | **DataSyncApiJobV1DataRefreshType** |  | [optional] 
**DataRefreshSpecificDate** | **string** |  | [optional] 
**MaxApiFailure** | **int** |  | [optional] 
**MaxApiRetry** | **int** |  | [optional] 
**JobCompleteCallbackUrl** | **string** |  | [optional] 
**JobMetadata** | [**List&lt;DataSyncApiJobV1JobMetadata&gt;**](DataSyncApiJobV1JobMetadata.md) |  | [optional] [readonly] 
**Schedule** | [**DataSyncApiJobV1Schedule**](DataSyncApiJobV1Schedule.md) |  | [optional] 
**NotificationEmails** | **List&lt;string&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

