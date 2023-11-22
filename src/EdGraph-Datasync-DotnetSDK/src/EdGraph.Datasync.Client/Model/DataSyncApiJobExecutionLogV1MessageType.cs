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
    /// Defines DataSyncApi.JobExecutionLog.V1.MessageType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataSyncApiJobExecutionLogV1MessageType
    {
        /// <summary>
        /// Enum Information for value: Information
        /// </summary>
        [EnumMember(Value = "Information")]
        Information = 1,

        /// <summary>
        /// Enum Warning for value: Warning
        /// </summary>
        [EnumMember(Value = "Warning")]
        Warning = 2,

        /// <summary>
        /// Enum SyncError for value: SyncError
        /// </summary>
        [EnumMember(Value = "SyncError")]
        SyncError = 3,

        /// <summary>
        /// Enum FatalError for value: FatalError
        /// </summary>
        [EnumMember(Value = "FatalError")]
        FatalError = 4
    }

}