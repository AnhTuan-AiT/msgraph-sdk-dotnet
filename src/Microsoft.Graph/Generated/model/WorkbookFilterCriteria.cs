// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFilterCriteria.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WorkbookFilterCriteria>))]
    public partial class WorkbookFilterCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbookFilterCriteria"/> class.
        /// </summary>
        public WorkbookFilterCriteria()
        {
            this.ODataType = "microsoft.graph.workbookFilterCriteria";
        }

        /// <summary>
        /// Gets or sets color.
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or sets criterion1.
        /// </summary>
        [JsonPropertyName("criterion1")]
        public string Criterion1 { get; set; }
    
        /// <summary>
        /// Gets or sets criterion2.
        /// </summary>
        [JsonPropertyName("criterion2")]
        public string Criterion2 { get; set; }
    
        /// <summary>
        /// Gets or sets dynamicCriteria.
        /// </summary>
        [JsonPropertyName("dynamicCriteria")]
        public string DynamicCriteria { get; set; }
    
        /// <summary>
        /// Gets or sets filterOn.
        /// </summary>
        [JsonPropertyName("filterOn")]
        public string FilterOn { get; set; }
    
        /// <summary>
        /// Gets or sets icon.
        /// </summary>
        [JsonPropertyName("icon")]
        public WorkbookIcon Icon { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// </summary>
        [JsonPropertyName("values")]
        public System.Text.Json.JsonDocument Values { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
