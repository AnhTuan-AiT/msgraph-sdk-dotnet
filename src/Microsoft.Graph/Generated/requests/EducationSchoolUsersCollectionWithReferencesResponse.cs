// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type EducationSchoolUsersCollectionWithReferencesResponse.
    /// </summary>
    public class EducationSchoolUsersCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IEducationSchoolUsersCollectionWithReferencesPage"/> value.
        /// </summary>
		[JsonPropertyName("value")]
        public IEducationSchoolUsersCollectionWithReferencesPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
