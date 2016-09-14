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
    /// The type WorkbookFunctionsDateRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsDateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Year.
        /// </summary>
        [DataMember(Name = "year", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Year { get; set; }
    
        /// <summary>
        /// Gets or sets Month.
        /// </summary>
        [DataMember(Name = "month", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Month { get; set; }
    
        /// <summary>
        /// Gets or sets Day.
        /// </summary>
        [DataMember(Name = "day", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Day { get; set; }
    
    }
}
