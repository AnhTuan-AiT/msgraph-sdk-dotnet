// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AlertStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlertStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// New Alert
        /// </summary>
        NewAlert = 1,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 2,
	
        /// <summary>
        /// Resolved
        /// </summary>
        Resolved = 3,
	
        /// <summary>
        /// Dismissed
        /// </summary>
        Dismissed = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
