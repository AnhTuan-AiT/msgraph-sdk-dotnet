// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Chart Axis.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAxis : Entity
    {
    
        /// <summary>
        /// Gets or sets major unit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "majorUnit", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken MajorUnit { get; set; }
    
        /// <summary>
        /// Gets or sets maximum.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maximum", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Maximum { get; set; }
    
        /// <summary>
        /// Gets or sets minimum.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimum", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken Minimum { get; set; }
    
        /// <summary>
        /// Gets or sets minor unit.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minorUnit", Required = Required.Default)]
        public Newtonsoft.Json.Linq.JToken MinorUnit { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "format", Required = Required.Default)]
        public WorkbookChartAxisFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets major gridlines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "majorGridlines", Required = Required.Default)]
        public WorkbookChartGridlines MajorGridlines { get; set; }
    
        /// <summary>
        /// Gets or sets minor gridlines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minorGridlines", Required = Required.Default)]
        public WorkbookChartGridlines MinorGridlines { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Required.Default)]
        public WorkbookChartAxisTitle Title { get; set; }
    
    }
}

