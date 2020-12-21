// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOutlookCategoryRequest.
    /// </summary>
    public partial interface IOutlookCategoryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OutlookCategory using POST.
        /// </summary>
        /// <param name="outlookCategoryToCreate">The OutlookCategory to create.</param>
        /// <returns>The created OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> CreateAsync(OutlookCategory outlookCategoryToCreate);        /// <summary>
        /// Creates the specified OutlookCategory using POST.
        /// </summary>
        /// <param name="outlookCategoryToCreate">The OutlookCategory to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> CreateAsync(OutlookCategory outlookCategoryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OutlookCategory.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OutlookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OutlookCategory.
        /// </summary>
        /// <returns>The OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> GetAsync();

        /// <summary>
        /// Gets the specified OutlookCategory.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OutlookCategory using PATCH.
        /// </summary>
        /// <param name="outlookCategoryToUpdate">The OutlookCategory to update.</param>
        /// <returns>The updated OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> UpdateAsync(OutlookCategory outlookCategoryToUpdate);

        /// <summary>
        /// Updates the specified OutlookCategory using PATCH.
        /// </summary>
        /// <param name="outlookCategoryToUpdate">The OutlookCategory to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OutlookCategory.</returns>
        System.Threading.Tasks.Task<OutlookCategory> UpdateAsync(OutlookCategory outlookCategoryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookCategoryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookCategoryRequest Expand(Expression<Func<OutlookCategory, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookCategoryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOutlookCategoryRequest Select(Expression<Func<OutlookCategory, object>> selectExpression);

    }
}
