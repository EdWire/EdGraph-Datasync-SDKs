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
    /// DataSyncApiJobV1ExecuteJobRequest
    /// </summary>
    [DataContract(Name = "DataSyncApi.Job.V1.ExecuteJobRequest")]
    public partial class DataSyncApiJobV1ExecuteJobRequest : IEquatable<DataSyncApiJobV1ExecuteJobRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataRefreshType
        /// </summary>
        [DataMember(Name = "dataRefreshType", EmitDefaultValue = false)]
        public DataSyncApiJobV1DataRefreshType? DataRefreshType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobV1ExecuteJobRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="childJobId">childJobId.</param>
        /// <param name="dataRefreshType">dataRefreshType.</param>
        /// <param name="dataRefreshSpecificDate">dataRefreshSpecificDate.</param>
        public DataSyncApiJobV1ExecuteJobRequest(string tenantId = default(string), string jobId = default(string), string childJobId = default(string), DataSyncApiJobV1DataRefreshType? dataRefreshType = default(DataSyncApiJobV1DataRefreshType?), string dataRefreshSpecificDate = default(string))
        {
            this.TenantId = tenantId;
            this.JobId = jobId;
            this.ChildJobId = childJobId;
            this.DataRefreshType = dataRefreshType;
            this.DataRefreshSpecificDate = dataRefreshSpecificDate;
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
        /// Gets or Sets DataRefreshSpecificDate
        /// </summary>
        [DataMember(Name = "dataRefreshSpecificDate", EmitDefaultValue = true)]
        public string DataRefreshSpecificDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiJobV1ExecuteJobRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ChildJobId: ").Append(ChildJobId).Append("\n");
            sb.Append("  DataRefreshType: ").Append(DataRefreshType).Append("\n");
            sb.Append("  DataRefreshSpecificDate: ").Append(DataRefreshSpecificDate).Append("\n");
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
            return this.Equals(input as DataSyncApiJobV1ExecuteJobRequest);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobV1ExecuteJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobV1ExecuteJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobV1ExecuteJobRequest input)
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
                    this.DataRefreshType == input.DataRefreshType ||
                    this.DataRefreshType.Equals(input.DataRefreshType)
                ) && 
                (
                    this.DataRefreshSpecificDate == input.DataRefreshSpecificDate ||
                    (this.DataRefreshSpecificDate != null &&
                    this.DataRefreshSpecificDate.Equals(input.DataRefreshSpecificDate))
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
                hashCode = (hashCode * 59) + this.DataRefreshType.GetHashCode();
                if (this.DataRefreshSpecificDate != null)
                {
                    hashCode = (hashCode * 59) + this.DataRefreshSpecificDate.GetHashCode();
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
