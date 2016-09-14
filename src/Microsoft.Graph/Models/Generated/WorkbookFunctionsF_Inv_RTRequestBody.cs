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
    /// The type WorkbookFunctionsF_Inv_RTRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsF_Inv_RTRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [DataMember(Name = "probability", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Probability { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom1.
        /// </summary>
        [DataMember(Name = "degFreedom1", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken DegFreedom1 { get; set; }
    
        /// <summary>
        /// Gets or sets DegFreedom2.
        /// </summary>
        [DataMember(Name = "degFreedom2", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken DegFreedom2 { get; set; }
    
    }
}
