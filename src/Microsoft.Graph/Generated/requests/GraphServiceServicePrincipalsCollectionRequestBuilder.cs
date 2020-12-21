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
    /// The type GraphServiceServicePrincipalsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceServicePrincipalsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceServicePrincipalsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceServicePrincipalsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceServicePrincipalsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceServicePrincipalsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceServicePrincipalsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceServicePrincipalsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IServicePrincipalRequestBuilder"/> for the specified GraphServiceServicePrincipal.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceServicePrincipal.</param>
        /// <returns>The <see cref="IServicePrincipalRequestBuilder"/>.</returns>
        public IServicePrincipalRequestBuilder this[string id]
        {
            get
            {
                return new ServicePrincipalRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ServicePrincipalDelta.
        /// </summary>
        /// <returns>The <see cref="IServicePrincipalDeltaRequestBuilder"/>.</returns>
        public IServicePrincipalDeltaRequestBuilder Delta()
        {
            return new ServicePrincipalDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
