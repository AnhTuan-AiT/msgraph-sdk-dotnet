// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ServicePrincipalMemberOfCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ServicePrincipalMemberOfCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IServicePrincipalMemberOfCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ServicePrincipalMemberOfCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServicePrincipalMemberOfCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServicePrincipalMemberOfCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServicePrincipalMemberOfCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ServicePrincipalMemberOfCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectWithReferenceRequestBuilder"/> for the specified ServicePrincipalDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the ServicePrincipalDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        public IDirectoryObjectWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IServicePrincipalMemberOfCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalMemberOfCollectionReferencesRequestBuilder"/>.</returns>
        public IServicePrincipalMemberOfCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ServicePrincipalMemberOfCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
