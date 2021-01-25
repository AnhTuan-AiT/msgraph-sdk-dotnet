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
    /// The type Win32LobAppRestartSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppRestartSettings>))]
    public partial class Win32LobAppRestartSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppRestartSettings"/> class.
        /// </summary>
        public Win32LobAppRestartSettings()
        {
            this.ODataType = "microsoft.graph.win32LobAppRestartSettings";
        }

        /// <summary>
        /// Gets or sets countdownDisplayBeforeRestartInMinutes.
        /// The number of minutes before the restart time to display the countdown dialog for pending restarts.
        /// </summary>
        [JsonPropertyName("countdownDisplayBeforeRestartInMinutes")]
        public Int32? CountdownDisplayBeforeRestartInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets gracePeriodInMinutes.
        /// The number of minutes to wait before restarting the device after an app installation.
        /// </summary>
        [JsonPropertyName("gracePeriodInMinutes")]
        public Int32? GracePeriodInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets restartNotificationSnoozeDurationInMinutes.
        /// The number of minutes to snooze the restart notification dialog when the snooze button is selected.
        /// </summary>
        [JsonPropertyName("restartNotificationSnoozeDurationInMinutes")]
        public Int32? RestartNotificationSnoozeDurationInMinutes { get; set; }
    
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
