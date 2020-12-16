// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagedDeviceWithReferenceRequest.
    /// </summary>
    public partial interface IManagedDeviceWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified ManagedDevice.
        /// </summary>
        /// <returns>The ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> GetAsync();

        /// <summary>
        /// Gets the specified ManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified ManagedDevice using POST.
        /// </summary>
        /// <param name="managedDeviceToCreate">The ManagedDevice to create.</param>
        /// <returns>The created ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> CreateAsync(ManagedDevice managedDeviceToCreate);        /// <summary>
        /// Creates the specified ManagedDevice using POST.
        /// </summary>
        /// <param name="managedDeviceToCreate">The ManagedDevice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> CreateAsync(ManagedDevice managedDeviceToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified ManagedDevice using PATCH.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice to update.</param>
        /// <returns>The updated ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> UpdateAsync(ManagedDevice managedDeviceToUpdate);

        /// <summary>
        /// Updates the specified ManagedDevice using PATCH.
        /// </summary>
        /// <param name="managedDeviceToUpdate">The ManagedDevice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDevice.</returns>
        System.Threading.Tasks.Task<ManagedDevice> UpdateAsync(ManagedDevice managedDeviceToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified ManagedDevice.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ManagedDevice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceWithReferenceRequest Expand(Expression<Func<ManagedDevice, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceWithReferenceRequest Select(Expression<Func<ManagedDevice, object>> selectExpression);

    }
}
