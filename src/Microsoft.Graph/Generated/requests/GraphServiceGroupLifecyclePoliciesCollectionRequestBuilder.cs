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
    /// The type GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceGroupLifecyclePoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceGroupLifecyclePoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceGroupLifecyclePoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IGroupLifecyclePolicyRequestBuilder"/> for the specified GraphServiceGroupLifecyclePolicy.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceGroupLifecyclePolicy.</param>
        /// <returns>The <see cref="IGroupLifecyclePolicyRequestBuilder"/>.</returns>
        public IGroupLifecyclePolicyRequestBuilder this[string id]
        {
            get
            {
                return new GroupLifecyclePolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
