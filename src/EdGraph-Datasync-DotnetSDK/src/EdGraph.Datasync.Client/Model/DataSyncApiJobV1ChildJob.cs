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
    /// DataSyncApiJobV1ChildJob
    /// </summary>
    [DataContract(Name = "DataSyncApi.Job.V1.ChildJob")]
    public partial class DataSyncApiJobV1ChildJob : IEquatable<DataSyncApiJobV1ChildJob>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets JobExecutionStatus
        /// </summary>
        [DataMember(Name = "jobExecutionStatus", EmitDefaultValue = false)]
        public DataSyncApiJobV1JobExecutionStatus? JobExecutionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobV1ChildJob" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="jobExecutionId">jobExecutionId.</param>
        /// <param name="childJobId">childJobId.</param>
        /// <param name="childJobName">childJobName.</param>
        /// <param name="jobExecutionStatus">jobExecutionStatus.</param>
        /// <param name="jobExecutionStartDateTime">jobExecutionStartDateTime.</param>
        /// <param name="jobExecutionEndDateTime">jobExecutionEndDateTime.</param>
        public DataSyncApiJobV1ChildJob(string jobId = default(string), string jobExecutionId = default(string), string childJobId = default(string), string childJobName = default(string), DataSyncApiJobV1JobExecutionStatus? jobExecutionStatus = default(DataSyncApiJobV1JobExecutionStatus?), string jobExecutionStartDateTime = default(string), string jobExecutionEndDateTime = default(string))
        {
            this.JobId = jobId;
            this.JobExecutionId = jobExecutionId;
            this.ChildJobId = childJobId;
            this.ChildJobName = childJobName;
            this.JobExecutionStatus = jobExecutionStatus;
            this.JobExecutionStartDateTime = jobExecutionStartDateTime;
            this.JobExecutionEndDateTime = jobExecutionEndDateTime;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobExecutionId
        /// </summary>
        [DataMember(Name = "jobExecutionId", EmitDefaultValue = true)]
        public string JobExecutionId { get; set; }

        /// <summary>
        /// Gets or Sets ChildJobId
        /// </summary>
        [DataMember(Name = "childJobId", EmitDefaultValue = true)]
        public string ChildJobId { get; set; }

        /// <summary>
        /// Gets or Sets ChildJobName
        /// </summary>
        [DataMember(Name = "childJobName", EmitDefaultValue = true)]
        public string ChildJobName { get; set; }

        /// <summary>
        /// Gets or Sets JobExecutionStartDateTime
        /// </summary>
        [DataMember(Name = "jobExecutionStartDateTime", EmitDefaultValue = true)]
        public string JobExecutionStartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets JobExecutionEndDateTime
        /// </summary>
        [DataMember(Name = "jobExecutionEndDateTime", EmitDefaultValue = true)]
        public string JobExecutionEndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = true)]
        public List<DataSyncApiJobV1Metric> Metrics { get; private set; }

        /// <summary>
        /// Returns false as Metrics should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetrics()
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
            sb.Append("class DataSyncApiJobV1ChildJob {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobExecutionId: ").Append(JobExecutionId).Append("\n");
            sb.Append("  ChildJobId: ").Append(ChildJobId).Append("\n");
            sb.Append("  ChildJobName: ").Append(ChildJobName).Append("\n");
            sb.Append("  JobExecutionStatus: ").Append(JobExecutionStatus).Append("\n");
            sb.Append("  JobExecutionStartDateTime: ").Append(JobExecutionStartDateTime).Append("\n");
            sb.Append("  JobExecutionEndDateTime: ").Append(JobExecutionEndDateTime).Append("\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
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
            return this.Equals(input as DataSyncApiJobV1ChildJob);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobV1ChildJob instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobV1ChildJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobV1ChildJob input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobExecutionId == input.JobExecutionId ||
                    (this.JobExecutionId != null &&
                    this.JobExecutionId.Equals(input.JobExecutionId))
                ) && 
                (
                    this.ChildJobId == input.ChildJobId ||
                    (this.ChildJobId != null &&
                    this.ChildJobId.Equals(input.ChildJobId))
                ) && 
                (
                    this.ChildJobName == input.ChildJobName ||
                    (this.ChildJobName != null &&
                    this.ChildJobName.Equals(input.ChildJobName))
                ) && 
                (
                    this.JobExecutionStatus == input.JobExecutionStatus ||
                    this.JobExecutionStatus.Equals(input.JobExecutionStatus)
                ) && 
                (
                    this.JobExecutionStartDateTime == input.JobExecutionStartDateTime ||
                    (this.JobExecutionStartDateTime != null &&
                    this.JobExecutionStartDateTime.Equals(input.JobExecutionStartDateTime))
                ) && 
                (
                    this.JobExecutionEndDateTime == input.JobExecutionEndDateTime ||
                    (this.JobExecutionEndDateTime != null &&
                    this.JobExecutionEndDateTime.Equals(input.JobExecutionEndDateTime))
                ) && 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
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
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.JobExecutionId != null)
                {
                    hashCode = (hashCode * 59) + this.JobExecutionId.GetHashCode();
                }
                if (this.ChildJobId != null)
                {
                    hashCode = (hashCode * 59) + this.ChildJobId.GetHashCode();
                }
                if (this.ChildJobName != null)
                {
                    hashCode = (hashCode * 59) + this.ChildJobName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.JobExecutionStatus.GetHashCode();
                if (this.JobExecutionStartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.JobExecutionStartDateTime.GetHashCode();
                }
                if (this.JobExecutionEndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.JobExecutionEndDateTime.GetHashCode();
                }
                if (this.Metrics != null)
                {
                    hashCode = (hashCode * 59) + this.Metrics.GetHashCode();
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