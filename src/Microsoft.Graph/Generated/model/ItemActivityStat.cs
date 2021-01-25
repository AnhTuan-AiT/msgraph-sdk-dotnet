// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Item Activity Stat.
    /// </summary>
    public partial class ItemActivityStat : Entity
    {
    
		///<summary>
		/// The ItemActivityStat constructor
		///</summary>
        public ItemActivityStat()
        {
            this.ODataType = "microsoft.graph.itemActivityStat";
        }
	
        /// <summary>
        /// Gets or sets access.
        /// Statistics about the access actions in this interval. Read-only.
        /// </summary>
        [JsonPropertyName("access")]
        public ItemActionStat Access { get; set; }
    
        /// <summary>
        /// Gets or sets create.
        /// Statistics about the create actions in this interval. Read-only.
        /// </summary>
        [JsonPropertyName("create")]
        public ItemActionStat Create { get; set; }
    
        /// <summary>
        /// Gets or sets delete.
        /// Statistics about the delete actions in this interval. Read-only.
        /// </summary>
        [JsonPropertyName("delete")]
        public ItemActionStat Delete { get; set; }
    
        /// <summary>
        /// Gets or sets edit.
        /// Statistics about the edit actions in this interval. Read-only.
        /// </summary>
        [JsonPropertyName("edit")]
        public ItemActionStat Edit { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// When the interval ends. Read-only.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets incomplete data.
        /// Indicates that the statistics in this interval are based on incomplete data. Read-only.
        /// </summary>
        [JsonPropertyName("incompleteData")]
        public IncompleteData IncompleteData { get; set; }
    
        /// <summary>
        /// Gets or sets is trending.
        /// Indicates whether the item is 'trending.' Read-only.
        /// </summary>
        [JsonPropertyName("isTrending")]
        public bool? IsTrending { get; set; }
    
        /// <summary>
        /// Gets or sets move.
        /// Statistics about the move actions in this interval. Read-only.
        /// </summary>
        [JsonPropertyName("move")]
        public ItemActionStat Move { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// When the interval starts. Read-only.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// Exposes the itemActivities represented in this itemActivityStat resource.
        /// </summary>
        [JsonPropertyName("activities")]
        public IItemActivityStatActivitiesCollectionPage Activities { get; set; }
    
    }
}

