// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Domain Dns Srv Record.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DomainDnsSrvRecord : DomainDnsRecord
    {
    
		///<summary>
		/// The DomainDnsSrvRecord constructor
		///</summary>
        public DomainDnsSrvRecord()
        {
            this.ODataType = "microsoft.graph.domainDnsSrvRecord";
        }
	
        /// <summary>
        /// Gets or sets name target.
        /// Value to use when configuring the Target property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nameTarget", Required = Newtonsoft.Json.Required.Default)]
        public string NameTarget { get; set; }
    
        /// <summary>
        /// Gets or sets port.
        /// Value to use when configuring the port property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "port", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Port { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// Value to use when configuring the priority property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "priority", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// Value to use when configuring the protocol property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protocol", Required = Newtonsoft.Json.Required.Default)]
        public string Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// Value to use when configuring the service property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "service", Required = Newtonsoft.Json.Required.Default)]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets weight.
        /// Value to use when configuring the weight property of the SRV record at the DNS host.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "weight", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Weight { get; set; }
    
    }
}
