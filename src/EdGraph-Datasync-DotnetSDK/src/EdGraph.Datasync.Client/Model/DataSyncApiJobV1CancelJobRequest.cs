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
    /// DataSyncApiJobV1CancelJobRequest
    /// </summary>
    [DataContract(Name = "DataSyncApi.Job.V1.CancelJobRequest")]
    public partial class DataSyncApiJobV1CancelJobRequest : IEquatable<DataSyncApiJobV1CancelJobRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobV1CancelJobRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="childJobId">childJobId.</param>
        /// <param name="jobExecutionId">jobExecutionId.</param>
        public DataSyncApiJobV1CancelJobRequest(string tenantId = default(string), string jobId = default(string), string childJobId = default(string), string jobExecutionId = default(string))
        {
            this.TenantId = tenantId;
            this.JobId = jobId;
            this.ChildJobId = childJobId;
            this.JobExecutionId = jobExecutionId;
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
        /// Gets or Sets ChildJobId
        /// </summary>
        [DataMember(Name = "childJobId", EmitDefaultValue = true)]
        public string ChildJobId { get; set; }

        /// <summary>
        /// Gets or Sets JobExecutionId
        /// </summary>
        [DataMember(Name = "jobExecutionId", EmitDefaultValue = true)]
        public string JobExecutionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiJobV1CancelJobRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ChildJobId: ").Append(ChildJobId).Append("\n");
            sb.Append("  JobExecutionId: ").Append(JobExecutionId).Append("\n");
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
            return this.Equals(input as DataSyncApiJobV1CancelJobRequest);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobV1CancelJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobV1CancelJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobV1CancelJobRequest input)
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
                    this.ChildJobId == input.ChildJobId ||
                    (this.ChildJobId != null &&
                    this.ChildJobId.Equals(input.ChildJobId))
                ) && 
                (
                    this.JobExecutionId == input.JobExecutionId ||
                    (this.JobExecutionId != null &&
                    this.JobExecutionId.Equals(input.JobExecutionId))
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
                if (this.ChildJobId != null)
                {
                    hashCode = (hashCode * 59) + this.ChildJobId.GetHashCode();
                }
                if (this.JobExecutionId != null)
                {
                    hashCode = (hashCode * 59) + this.JobExecutionId.GetHashCode();
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