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
    /// The type TermsAndConditionsAcceptanceStatusesCollectionRequestBuilder.
    /// </summary>
    public partial class TermsAndConditionsAcceptanceStatusesCollectionRequestBuilder : BaseRequestBuilder, ITermsAndConditionsAcceptanceStatusesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TermsAndConditionsAcceptanceStatusesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TermsAndConditionsAcceptanceStatusesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITermsAndConditionsAcceptanceStatusesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITermsAndConditionsAcceptanceStatusesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TermsAndConditionsAcceptanceStatusesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITermsAndConditionsAcceptanceStatusRequestBuilder"/> for the specified TermsAndConditionsTermsAndConditionsAcceptanceStatus.
        /// </summary>
        /// <param name="id">The ID for the TermsAndConditionsTermsAndConditionsAcceptanceStatus.</param>
        /// <returns>The <see cref="ITermsAndConditionsAcceptanceStatusRequestBuilder"/>.</returns>
        public ITermsAndConditionsAcceptanceStatusRequestBuilder this[string id]
        {
            get
            {
                return new TermsAndConditionsAcceptanceStatusRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
