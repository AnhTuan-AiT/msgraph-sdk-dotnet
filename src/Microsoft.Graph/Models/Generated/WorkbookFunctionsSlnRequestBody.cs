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

    /// <summary>
    /// The type WorkbookFunctionsSlnRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsSlnRequestBody
    {
    
        /// <summary>
        /// Gets or sets Cost.
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Cost { get; set; }
    
        /// <summary>
        /// Gets or sets Salvage.
        /// </summary>
        [DataMember(Name = "salvage", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Salvage { get; set; }
    
        /// <summary>
        /// Gets or sets Life.
        /// </summary>
        [DataMember(Name = "life", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Life { get; set; }
    
    }
}
