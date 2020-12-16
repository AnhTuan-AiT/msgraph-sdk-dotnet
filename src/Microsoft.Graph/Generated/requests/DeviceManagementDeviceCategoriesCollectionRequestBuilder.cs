// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementDeviceCategoriesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementDeviceCategoriesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementDeviceCategoriesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementDeviceCategoriesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementDeviceCategoriesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceCategoriesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementDeviceCategoriesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementDeviceCategoriesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDeviceCategoryRequestBuilder"/> for the specified DeviceManagementDeviceCategory.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementDeviceCategory.</param>
        /// <returns>The <see cref="IDeviceCategoryRequestBuilder"/>.</returns>
        public IDeviceCategoryRequestBuilder this[string id]
        {
            get
            {
                return new DeviceCategoryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
