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
    /// Defines DataSyncApi.Job.V1.DataRefreshType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataSyncApiJobV1DataRefreshType
    {
        /// <summary>
        /// Enum Unknown for value: Unknown
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Full for value: Full
        /// </summary>
        [EnumMember(Value = "Full")]
        Full,

        /// <summary>
        /// Enum Deltasincelastjobexecution for value: Deltasincelastjobexecution
        /// </summary>
        [EnumMember(Value = "Deltasincelastjobexecution")]
        Deltasincelastjobexecution,

        /// <summary>
        /// Enum Deltasincespecificdatetime for value: Deltasincespecificdatetime
        /// </summary>
        [EnumMember(Value = "Deltasincespecificdatetime")]
        Deltasincespecificdatetime
    }

}