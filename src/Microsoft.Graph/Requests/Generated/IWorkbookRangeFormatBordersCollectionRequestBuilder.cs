// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookRangeFormatBordersCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookRangeFormatBordersCollectionRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookRangeFormatBordersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookRangeFormatBordersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookRangeBorderRequestBuilder"/> for the specified WorkbookRangeBorder.
        /// </summary>
        /// <param name="id">The ID for the WorkbookRangeBorder.</param>
        /// <returns>The <see cref="IWorkbookRangeBorderRequestBuilder"/>.</returns>
        IWorkbookRangeBorderRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBorderItemAtRequestBuilder"/>.</returns>
        IWorkbookRangeBorderItemAtRequestBuilder ItemAt(
            Int32 index);

        /// <summary>
        /// Gets the request builder for WorkbookRangeBorderCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookRangeBorderCountRequestBuilder"/>.</returns>
        IWorkbookRangeBorderCountRequestBuilder Count();
    }
}
