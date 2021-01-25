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
    /// The type PasswordCredential.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PasswordCredential>))]
    public partial class PasswordCredential
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordCredential"/> class.
        /// </summary>
        public PasswordCredential()
        {
            this.ODataType = "microsoft.graph.passwordCredential";
        }

        /// <summary>
        /// Gets or sets customKeyIdentifier.
        /// Do not use.
        /// </summary>
        [JsonPropertyName("customKeyIdentifier")]
        public byte[] CustomKeyIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Friendly name for the password. Optional.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets hint.
        /// Contains the first three characters of the password. Read-only.
        /// </summary>
        [JsonPropertyName("hint")]
        public string Hint { get; set; }
    
        /// <summary>
        /// Gets or sets keyId.
        /// The unique identifier for the password.
        /// </summary>
        [JsonPropertyName("keyId")]
        public Guid? KeyId { get; set; }
    
        /// <summary>
        /// Gets or sets secretText.
        /// Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
        /// </summary>
        [JsonPropertyName("secretText")]
        public string SecretText { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
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
