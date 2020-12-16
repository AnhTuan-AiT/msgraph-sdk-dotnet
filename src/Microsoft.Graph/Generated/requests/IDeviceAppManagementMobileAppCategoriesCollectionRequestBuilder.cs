// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementMobileAppCategoriesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAppManagementMobileAppCategoriesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAppManagementMobileAppCategoriesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMobileAppCategoryRequestBuilder"/> for the specified MobileAppCategory.
        /// </summary>
        /// <param name="id">The ID for the MobileAppCategory.</param>
        /// <returns>The <see cref="IMobileAppCategoryRequestBuilder"/>.</returns>
        IMobileAppCategoryRequestBuilder this[string id] { get; }

        
    }
}
