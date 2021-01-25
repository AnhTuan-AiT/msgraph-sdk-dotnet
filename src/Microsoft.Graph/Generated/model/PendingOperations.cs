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
    /// The type PendingOperations.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PendingOperations>))]
    public partial class PendingOperations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingOperations"/> class.
        /// </summary>
        public PendingOperations()
        {
            this.ODataType = "microsoft.graph.pendingOperations";
        }

        /// <summary>
        /// Gets or sets pendingContentUpdate.
        /// A property that indicates that an operation that might update the binary content of a file is pending completion.
        /// </summary>
        [JsonPropertyName("pendingContentUpdate")]
        public PendingContentUpdate PendingContentUpdate { get; set; }
    
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
