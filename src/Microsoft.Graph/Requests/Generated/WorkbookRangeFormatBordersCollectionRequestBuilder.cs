// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookRangeFormatBordersCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookRangeFormatBordersCollectionRequestBuilder : BaseRequestBuilder, IWorkbookRangeFormatBordersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookRangeFormatBordersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookRangeFormatBordersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookRangeFormatBordersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookRangeFormatBordersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookRangeFormatBordersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookRangeBorderRequestBuilder"/> for the specified WorkbookRangeFormatWorkbookRangeBorder.
        /// </summary>
        /// <param name="id">The ID for the WorkbookRangeFormatWorkbookRangeBorder.</param>
        /// <returns>The <see cref="IWorkbookRangeBorderRequestBuilder"/>.</returns>
        public IWorkbookRangeBorderRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookRangeBorderRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBorderItemAtRequestBuilder"/>.</returns>
        public IWorkbookRangeBorderItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookRangeBorderItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBorderCountRequestBuilder"/>.</returns>
        public IWorkbookRangeBorderCountRequestBuilder Count()
        {
            return new WorkbookRangeBorderCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    }
}
