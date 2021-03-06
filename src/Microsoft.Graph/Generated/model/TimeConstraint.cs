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
    /// The type TimeConstraint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TimeConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeConstraint"/> class.
        /// </summary>
        public TimeConstraint()
        {
            this.ODataType = "microsoft.graph.timeConstraint";
        }

        /// <summary>
        /// Gets or sets activityDomain.
        /// The nature of the activity, optional. The possible values are: work, personal, unrestricted, or unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityDomain", Required = Newtonsoft.Json.Required.Default)]
        public ActivityDomain? ActivityDomain { get; set; }
    
        /// <summary>
        /// Gets or sets timeSlots.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeSlots", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<TimeSlot> TimeSlots { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
