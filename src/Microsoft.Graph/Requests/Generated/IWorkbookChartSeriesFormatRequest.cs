// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookChartSeriesFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartSeriesFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using PUT.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <returns>The created WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> CreateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartSeriesFormat using PUT.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToCreate">The WorkbookChartSeriesFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> CreateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <returns>The WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartSeriesFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <returns>The updated WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> UpdateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartSeriesFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartSeriesFormatToUpdate">The WorkbookChartSeriesFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartSeriesFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartSeriesFormat> UpdateAsync(WorkbookChartSeriesFormat workbookChartSeriesFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartSeriesFormatRequest Select(string value);

    }
}
