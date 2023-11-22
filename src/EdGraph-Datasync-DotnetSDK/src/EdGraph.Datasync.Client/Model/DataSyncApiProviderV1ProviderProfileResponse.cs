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
    /// DataSyncApiProviderV1ProviderProfileResponse
    /// </summary>
    [DataContract(Name = "DataSyncApi.Provider.V1.ProviderProfileResponse")]
    public partial class DataSyncApiProviderV1ProviderProfileResponse : IEquatable<DataSyncApiProviderV1ProviderProfileResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiProviderV1ProviderProfileResponse" /> class.
        /// </summary>
        /// <param name="providerId">providerId.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="iconUri">iconUri.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        public DataSyncApiProviderV1ProviderProfileResponse(string providerId = default(string), string name = default(string), string description = default(string), string iconUri = default(string), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string))
        {
            this.ProviderId = providerId;
            this.Name = name;
            this.Description = description;
            this.IconUri = iconUri;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
        }

        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconUri
        /// </summary>
        [DataMember(Name = "iconUri", EmitDefaultValue = true)]
        public string IconUri { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionTypes
        /// </summary>
        [DataMember(Name = "connectionTypes", EmitDefaultValue = true)]
        public List<DataSyncApiProviderV1ConnectionType> ConnectionTypes { get; private set; }

        /// <summary>
        /// Returns false as ConnectionTypes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConnectionTypes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = true)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = true)]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiProviderV1ProviderProfileResponse {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUri: ").Append(IconUri).Append("\n");
            sb.Append("  ConnectionTypes: ").Append(ConnectionTypes).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
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
            return this.Equals(input as DataSyncApiProviderV1ProviderProfileResponse);
        }

        /// <summary>
        /// Returns true if DataSyncApiProviderV1ProviderProfileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiProviderV1ProviderProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiProviderV1ProviderProfileResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUri == input.IconUri ||
                    (this.IconUri != null &&
                    this.IconUri.Equals(input.IconUri))
                ) && 
                (
                    this.ConnectionTypes == input.ConnectionTypes ||
                    this.ConnectionTypes != null &&
                    input.ConnectionTypes != null &&
                    this.ConnectionTypes.SequenceEqual(input.ConnectionTypes)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
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
                if (this.ProviderId != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconUri != null)
                {
                    hashCode = (hashCode * 59) + this.IconUri.GetHashCode();
                }
                if (this.ConnectionTypes != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionTypes.GetHashCode();
                }
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDateTime.GetHashCode();
                }
                if (this.LastModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedBy.GetHashCode();
                }
                if (this.LastModifiedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDateTime.GetHashCode();
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
