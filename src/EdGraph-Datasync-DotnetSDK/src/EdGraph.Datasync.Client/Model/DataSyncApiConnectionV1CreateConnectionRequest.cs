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
    /// DataSyncApiConnectionV1CreateConnectionRequest
    /// </summary>
    [DataContract(Name = "DataSyncApi.Connection.V1.CreateConnectionRequest")]
    public partial class DataSyncApiConnectionV1CreateConnectionRequest : IEquatable<DataSyncApiConnectionV1CreateConnectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiConnectionV1CreateConnectionRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="connectionId">connectionId.</param>
        /// <param name="name">name.</param>
        /// <param name="providerId">providerId.</param>
        /// <param name="connectionTypeId">connectionTypeId.</param>
        public DataSyncApiConnectionV1CreateConnectionRequest(string tenantId = default(string), string connectionId = default(string), string name = default(string), string providerId = default(string), string connectionTypeId = default(string))
        {
            this.TenantId = tenantId;
            this.ConnectionId = connectionId;
            this.Name = name;
            this.ProviderId = providerId;
            this.ConnectionTypeId = connectionTypeId;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionId
        /// </summary>
        [DataMember(Name = "connectionId", EmitDefaultValue = true)]
        public string ConnectionId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionMetadata
        /// </summary>
        [DataMember(Name = "connectionMetadata", EmitDefaultValue = true)]
        public List<DataSyncApiConnectionV1ConnectionMetadata> ConnectionMetadata { get; private set; }

        /// <summary>
        /// Returns false as ConnectionMetadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnectionMetadata()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionTypeId
        /// </summary>
        [DataMember(Name = "connectionTypeId", EmitDefaultValue = true)]
        public string ConnectionTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiConnectionV1CreateConnectionRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ConnectionId: ").Append(ConnectionId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConnectionMetadata: ").Append(ConnectionMetadata).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ConnectionTypeId: ").Append(ConnectionTypeId).Append("\n");
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
            return this.Equals(input as DataSyncApiConnectionV1CreateConnectionRequest);
        }

        /// <summary>
        /// Returns true if DataSyncApiConnectionV1CreateConnectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiConnectionV1CreateConnectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiConnectionV1CreateConnectionRequest input)
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
                    this.ConnectionId == input.ConnectionId ||
                    (this.ConnectionId != null &&
                    this.ConnectionId.Equals(input.ConnectionId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ConnectionMetadata == input.ConnectionMetadata ||
                    this.ConnectionMetadata != null &&
                    input.ConnectionMetadata != null &&
                    this.ConnectionMetadata.SequenceEqual(input.ConnectionMetadata)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.ConnectionTypeId == input.ConnectionTypeId ||
                    (this.ConnectionTypeId != null &&
                    this.ConnectionTypeId.Equals(input.ConnectionTypeId))
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
                if (this.ConnectionId != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ConnectionMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionMetadata.GetHashCode();
                }
                if (this.ProviderId != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                }
                if (this.ConnectionTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionTypeId.GetHashCode();
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