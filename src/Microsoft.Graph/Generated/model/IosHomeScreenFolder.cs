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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosHomeScreenFolder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosHomeScreenFolder : IosHomeScreenItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosHomeScreenFolder"/> class.
        /// </summary>
        public IosHomeScreenFolder()
        {
            this.ODataType = "microsoft.graph.iosHomeScreenFolder";
        }

        /// <summary>
        /// Gets or sets pages.
        /// Pages of Home Screen Layout Icons which must be Application Type. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IosHomeScreenFolderPage> Pages { get; set; }
    
    }
}
