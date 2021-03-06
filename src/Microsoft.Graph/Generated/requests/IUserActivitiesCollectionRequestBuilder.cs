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
    /// The interface IUserActivitiesCollectionRequestBuilder.
    /// </summary>
    public partial interface IUserActivitiesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserActivitiesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserActivitiesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserActivityRequestBuilder"/> for the specified UserActivity.
        /// </summary>
        /// <param name="id">The ID for the UserActivity.</param>
        /// <returns>The <see cref="IUserActivityRequestBuilder"/>.</returns>
        IUserActivityRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UserActivityRecent.
        /// </summary>
        /// <returns>The <see cref="IUserActivityRecentRequestBuilder"/>.</returns>
        IUserActivityRecentRequestBuilder Recent();
    }
}
