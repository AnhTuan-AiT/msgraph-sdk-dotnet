// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type WorkbookChartTitleFormatRequest.
    /// </summary>
    public partial class WorkbookChartTitleFormatRequest : BaseRequest, IWorkbookChartTitleFormatRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartTitleFormatRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartTitleFormatRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <returns>The created WorkbookChartTitleFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartTitleFormat> CreateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate)
        {
            return this.CreateAsync(workbookChartTitleFormatToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartTitleFormat using POST.
        /// </summary>
        /// <param name="workbookChartTitleFormatToCreate">The WorkbookChartTitleFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartTitleFormat> CreateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartTitleFormat>(workbookChartTitleFormatToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartTitleFormat>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <returns>The WorkbookChartTitleFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartTitleFormat> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartTitleFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartTitleFormat> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartTitleFormat>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <returns>The updated WorkbookChartTitleFormat.</returns>
        public System.Threading.Tasks.Task<WorkbookChartTitleFormat> UpdateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate)
        {
            return this.UpdateAsync(workbookChartTitleFormatToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartTitleFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartTitleFormatToUpdate">The WorkbookChartTitleFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartTitleFormat.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartTitleFormat> UpdateAsync(WorkbookChartTitleFormat workbookChartTitleFormatToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartTitleFormat>(workbookChartTitleFormatToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartTitleFormatRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartTitleFormatRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartTitleFormatToInitialize">The <see cref="WorkbookChartTitleFormat"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartTitleFormat workbookChartTitleFormatToInitialize)
        {

        }
    }
}
