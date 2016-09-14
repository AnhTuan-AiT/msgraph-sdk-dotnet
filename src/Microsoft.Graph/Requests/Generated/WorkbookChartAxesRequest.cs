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
    /// The type WorkbookChartAxesRequest.
    /// </summary>
    public partial class WorkbookChartAxesRequest : BaseRequest, IWorkbookChartAxesRequest
    {
        /// <summary>
        /// Constructs a new WorkbookChartAxesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookChartAxesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookChartAxes using POST.
        /// </summary>
        /// <param name="workbookChartAxesToCreate">The WorkbookChartAxes to create.</param>
        /// <returns>The created WorkbookChartAxes.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAxes> CreateAsync(WorkbookChartAxes workbookChartAxesToCreate)
        {
            return this.CreateAsync(workbookChartAxesToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookChartAxes using POST.
        /// </summary>
        /// <param name="workbookChartAxesToCreate">The WorkbookChartAxes to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartAxes.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxes> CreateAsync(WorkbookChartAxes workbookChartAxesToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookChartAxes>(workbookChartAxesToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAxes.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookChartAxes.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookChartAxes>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxes.
        /// </summary>
        /// <returns>The WorkbookChartAxes.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAxes> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookChartAxes.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartAxes.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxes> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookChartAxes>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PATCH.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes to update.</param>
        /// <returns>The updated WorkbookChartAxes.</returns>
        public System.Threading.Tasks.Task<WorkbookChartAxes> UpdateAsync(WorkbookChartAxes workbookChartAxesToUpdate)
        {
            return this.UpdateAsync(workbookChartAxesToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookChartAxes using PATCH.
        /// </summary>
        /// <param name="workbookChartAxesToUpdate">The WorkbookChartAxes to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartAxes.</returns>
        public async System.Threading.Tasks.Task<WorkbookChartAxes> UpdateAsync(WorkbookChartAxes workbookChartAxesToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookChartAxes>(workbookChartAxesToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAxesRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookChartAxesRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookChartAxesToInitialize">The <see cref="WorkbookChartAxes"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookChartAxes workbookChartAxesToInitialize)
        {

        }
    }
}
