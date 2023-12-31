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
    /// DataSyncApiJobTypeV1JobMetadataField
    /// </summary>
    [DataContract(Name = "DataSyncApi.JobType.V1.JobMetadataField")]
    public partial class DataSyncApiJobTypeV1JobMetadataField : IEquatable<DataSyncApiJobTypeV1JobMetadataField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobTypeV1JobMetadataField" /> class.
        /// </summary>
        /// <param name="tab">tab.</param>
        /// <param name="code">code.</param>
        /// <param name="label">label.</param>
        /// <param name="validation">validation.</param>
        /// <param name="order">order.</param>
        /// <param name="display">display.</param>
        /// <param name="defaultValue">defaultValue.</param>
        /// <param name="type">type.</param>
        /// <param name="values">values.</param>
        /// <param name="api">api.</param>
        /// <param name="isSecret">isSecret.</param>
        public DataSyncApiJobTypeV1JobMetadataField(string tab = default(string), string code = default(string), string label = default(string), string validation = default(string), string order = default(string), bool display = default(bool), string defaultValue = default(string), string type = default(string), string values = default(string), string api = default(string), bool isSecret = default(bool))
        {
            this.Tab = tab;
            this.Code = code;
            this.Label = label;
            this.Validation = validation;
            this.Order = order;
            this.Display = display;
            this.DefaultValue = defaultValue;
            this.Type = type;
            this.Values = values;
            this.Api = api;
            this.IsSecret = isSecret;
        }

        /// <summary>
        /// Gets or Sets Tab
        /// </summary>
        [DataMember(Name = "tab", EmitDefaultValue = true)]
        public string Tab { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Validation
        /// </summary>
        [DataMember(Name = "validation", EmitDefaultValue = true)]
        public string Validation { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// Gets or Sets Display
        /// </summary>
        [DataMember(Name = "display", EmitDefaultValue = true)]
        public bool Display { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValue
        /// </summary>
        [DataMember(Name = "defaultValue", EmitDefaultValue = true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public string Values { get; set; }

        /// <summary>
        /// Gets or Sets Api
        /// </summary>
        [DataMember(Name = "api", EmitDefaultValue = true)]
        public string Api { get; set; }

        /// <summary>
        /// Gets or Sets IsSecret
        /// </summary>
        [DataMember(Name = "isSecret", EmitDefaultValue = true)]
        public bool IsSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiJobTypeV1JobMetadataField {\n");
            sb.Append("  Tab: ").Append(Tab).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Api: ").Append(Api).Append("\n");
            sb.Append("  IsSecret: ").Append(IsSecret).Append("\n");
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
            return this.Equals(input as DataSyncApiJobTypeV1JobMetadataField);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobTypeV1JobMetadataField instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobTypeV1JobMetadataField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobTypeV1JobMetadataField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tab == input.Tab ||
                    (this.Tab != null &&
                    this.Tab.Equals(input.Tab))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Validation == input.Validation ||
                    (this.Validation != null &&
                    this.Validation.Equals(input.Validation))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Display == input.Display ||
                    this.Display.Equals(input.Display)
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
                ) && 
                (
                    this.Api == input.Api ||
                    (this.Api != null &&
                    this.Api.Equals(input.Api))
                ) && 
                (
                    this.IsSecret == input.IsSecret ||
                    this.IsSecret.Equals(input.IsSecret)
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
                if (this.Tab != null)
                {
                    hashCode = (hashCode * 59) + this.Tab.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                if (this.Validation != null)
                {
                    hashCode = (hashCode * 59) + this.Validation.GetHashCode();
                }
                if (this.Order != null)
                {
                    hashCode = (hashCode * 59) + this.Order.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Display.GetHashCode();
                if (this.DefaultValue != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValue.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                if (this.Api != null)
                {
                    hashCode = (hashCode * 59) + this.Api.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSecret.GetHashCode();
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
