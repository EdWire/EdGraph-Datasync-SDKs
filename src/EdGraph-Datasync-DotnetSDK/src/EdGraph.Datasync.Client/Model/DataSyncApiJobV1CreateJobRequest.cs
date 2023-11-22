/*
 * DataSync Api
 *
 * DataSync Api - v1.0
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdGraph.Datasync.Client.Client.OpenAPIDateConverter;

namespace EdGraph.Datasync.Client.Model
{
    /// <summary>
    /// DataSyncApiJobV1CreateJobRequest
    /// </summary>
    [DataContract(Name = "DataSyncApi.Job.V1.CreateJobRequest")]
    public partial class DataSyncApiJobV1CreateJobRequest : IEquatable<DataSyncApiJobV1CreateJobRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataRefreshType
        /// </summary>
        [DataMember(Name = "dataRefreshType", EmitDefaultValue = false)]
        public DataSyncApiJobV1DataRefreshType? DataRefreshType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobV1CreateJobRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="name">name.</param>
        /// <param name="jobTypeId">jobTypeId.</param>
        /// <param name="sourceConnectionId">sourceConnectionId.</param>
        /// <param name="destinationConnectionId">destinationConnectionId.</param>
        /// <param name="profileId">profileId.</param>
        /// <param name="jobPoints">jobPoints.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="dataRefreshType">dataRefreshType.</param>
        /// <param name="dataRefreshSpecificDate">dataRefreshSpecificDate.</param>
        /// <param name="maxApiFailure">maxApiFailure.</param>
        /// <param name="maxApiRetry">maxApiRetry.</param>
        /// <param name="jobCompleteCallbackUrl">jobCompleteCallbackUrl.</param>
        /// <param name="schedule">schedule.</param>
        public DataSyncApiJobV1CreateJobRequest(string tenantId = default(string), string jobId = default(string), string name = default(string), string jobTypeId = default(string), string sourceConnectionId = default(string), string destinationConnectionId = default(string), string profileId = default(string), int jobPoints = default(int), string applicationId = default(string), DataSyncApiJobV1DataRefreshType? dataRefreshType = default(DataSyncApiJobV1DataRefreshType?), string dataRefreshSpecificDate = default(string), int maxApiFailure = default(int), int maxApiRetry = default(int), string jobCompleteCallbackUrl = default(string), DataSyncApiJobV1Schedule schedule = default(DataSyncApiJobV1Schedule))
        {
            this.TenantId = tenantId;
            this.JobId = jobId;
            this.Name = name;
            this.JobTypeId = jobTypeId;
            this.SourceConnectionId = sourceConnectionId;
            this.DestinationConnectionId = destinationConnectionId;
            this.ProfileId = profileId;
            this.JobPoints = jobPoints;
            this.ApplicationId = applicationId;
            this.DataRefreshType = dataRefreshType;
            this.DataRefreshSpecificDate = dataRefreshSpecificDate;
            this.MaxApiFailure = maxApiFailure;
            this.MaxApiRetry = maxApiRetry;
            this.JobCompleteCallbackUrl = jobCompleteCallbackUrl;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets JobTypeId
        /// </summary>
        [DataMember(Name = "jobTypeId", EmitDefaultValue = true)]
        public string JobTypeId { get; set; }

        /// <summary>
        /// Gets or Sets SourceConnectionId
        /// </summary>
        [DataMember(Name = "sourceConnectionId", EmitDefaultValue = true)]
        public string SourceConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets DestinationConnectionId
        /// </summary>
        [DataMember(Name = "destinationConnectionId", EmitDefaultValue = true)]
        public string DestinationConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Gets or Sets JobPoints
        /// </summary>
        [DataMember(Name = "jobPoints", EmitDefaultValue = false)]
        public int JobPoints { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets DataRefreshSpecificDate
        /// </summary>
        [DataMember(Name = "dataRefreshSpecificDate", EmitDefaultValue = true)]
        public string DataRefreshSpecificDate { get; set; }

        /// <summary>
        /// Gets or Sets MaxApiFailure
        /// </summary>
        [DataMember(Name = "maxApiFailure", EmitDefaultValue = false)]
        public int MaxApiFailure { get; set; }

        /// <summary>
        /// Gets or Sets MaxApiRetry
        /// </summary>
        [DataMember(Name = "maxApiRetry", EmitDefaultValue = false)]
        public int MaxApiRetry { get; set; }

        /// <summary>
        /// Gets or Sets JobCompleteCallbackUrl
        /// </summary>
        [DataMember(Name = "jobCompleteCallbackUrl", EmitDefaultValue = true)]
        public string JobCompleteCallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets JobMetadata
        /// </summary>
        [DataMember(Name = "jobMetadata", EmitDefaultValue = true)]
        public List<DataSyncApiJobV1JobMetadata> JobMetadata { get; private set; }

        /// <summary>
        /// Returns false as JobMetadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJobMetadata()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public DataSyncApiJobV1Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or Sets NotificationEmails
        /// </summary>
        [DataMember(Name = "notificationEmails", EmitDefaultValue = true)]
        public List<string> NotificationEmails { get; private set; }

        /// <summary>
        /// Returns false as NotificationEmails should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotificationEmails()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiJobV1CreateJobRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  JobTypeId: ").Append(JobTypeId).Append("\n");
            sb.Append("  SourceConnectionId: ").Append(SourceConnectionId).Append("\n");
            sb.Append("  DestinationConnectionId: ").Append(DestinationConnectionId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  JobPoints: ").Append(JobPoints).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  DataRefreshType: ").Append(DataRefreshType).Append("\n");
            sb.Append("  DataRefreshSpecificDate: ").Append(DataRefreshSpecificDate).Append("\n");
            sb.Append("  MaxApiFailure: ").Append(MaxApiFailure).Append("\n");
            sb.Append("  MaxApiRetry: ").Append(MaxApiRetry).Append("\n");
            sb.Append("  JobCompleteCallbackUrl: ").Append(JobCompleteCallbackUrl).Append("\n");
            sb.Append("  JobMetadata: ").Append(JobMetadata).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  NotificationEmails: ").Append(NotificationEmails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataSyncApiJobV1CreateJobRequest);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobV1CreateJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobV1CreateJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobV1CreateJobRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.JobTypeId == input.JobTypeId ||
                    (this.JobTypeId != null &&
                    this.JobTypeId.Equals(input.JobTypeId))
                ) && 
                (
                    this.SourceConnectionId == input.SourceConnectionId ||
                    (this.SourceConnectionId != null &&
                    this.SourceConnectionId.Equals(input.SourceConnectionId))
                ) && 
                (
                    this.DestinationConnectionId == input.DestinationConnectionId ||
                    (this.DestinationConnectionId != null &&
                    this.DestinationConnectionId.Equals(input.DestinationConnectionId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.JobPoints == input.JobPoints ||
                    this.JobPoints.Equals(input.JobPoints)
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.DataRefreshType == input.DataRefreshType ||
                    this.DataRefreshType.Equals(input.DataRefreshType)
                ) && 
                (
                    this.DataRefreshSpecificDate == input.DataRefreshSpecificDate ||
                    (this.DataRefreshSpecificDate != null &&
                    this.DataRefreshSpecificDate.Equals(input.DataRefreshSpecificDate))
                ) && 
                (
                    this.MaxApiFailure == input.MaxApiFailure ||
                    this.MaxApiFailure.Equals(input.MaxApiFailure)
                ) && 
                (
                    this.MaxApiRetry == input.MaxApiRetry ||
                    this.MaxApiRetry.Equals(input.MaxApiRetry)
                ) && 
                (
                    this.JobCompleteCallbackUrl == input.JobCompleteCallbackUrl ||
                    (this.JobCompleteCallbackUrl != null &&
                    this.JobCompleteCallbackUrl.Equals(input.JobCompleteCallbackUrl))
                ) && 
                (
                    this.JobMetadata == input.JobMetadata ||
                    this.JobMetadata != null &&
                    input.JobMetadata != null &&
                    this.JobMetadata.SequenceEqual(input.JobMetadata)
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.NotificationEmails == input.NotificationEmails ||
                    this.NotificationEmails != null &&
                    input.NotificationEmails != null &&
                    this.NotificationEmails.SequenceEqual(input.NotificationEmails)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.JobTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.JobTypeId.GetHashCode();
                }
                if (this.SourceConnectionId != null)
                {
                    hashCode = (hashCode * 59) + this.SourceConnectionId.GetHashCode();
                }
                if (this.DestinationConnectionId != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationConnectionId.GetHashCode();
                }
                if (this.ProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobPoints.GetHashCode();
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataRefreshType.GetHashCode();
                if (this.DataRefreshSpecificDate != null)
                {
                    hashCode = (hashCode * 59) + this.DataRefreshSpecificDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxApiFailure.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxApiRetry.GetHashCode();
                if (this.JobCompleteCallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JobCompleteCallbackUrl.GetHashCode();
                }
                if (this.JobMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.JobMetadata.GetHashCode();
                }
                if (this.Schedule != null)
                {
                    hashCode = (hashCode * 59) + this.Schedule.GetHashCode();
                }
                if (this.NotificationEmails != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationEmails.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}