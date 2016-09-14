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
    /// The type WorkbookFunctionsYieldDiscRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsYieldDiscRequestBody
    {
    
        /// <summary>
        /// Gets or sets Settlement.
        /// </summary>
        [DataMember(Name = "settlement", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Settlement { get; set; }
    
        /// <summary>
        /// Gets or sets Maturity.
        /// </summary>
        [DataMember(Name = "maturity", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Maturity { get; set; }
    
        /// <summary>
        /// Gets or sets Pr.
        /// </summary>
        [DataMember(Name = "pr", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Pr { get; set; }
    
        /// <summary>
        /// Gets or sets Redemption.
        /// </summary>
        [DataMember(Name = "redemption", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Redemption { get; set; }
    
        /// <summary>
        /// Gets or sets Basis.
        /// </summary>
        [DataMember(Name = "basis", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Basis { get; set; }
    
    }
}
