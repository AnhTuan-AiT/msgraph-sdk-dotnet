// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsDollarFrRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDollarFrRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsDollarFrRequest>, IWorkbookFunctionsDollarFrRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDollarFrRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="decimalDollar">A decimalDollar parameter for the OData method call.</param>
        /// <param name="fraction">A fraction parameter for the OData method call.</param>
        public WorkbookFunctionsDollarFrRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken decimalDollar,
            Newtonsoft.Json.Linq.JToken fraction)
            : base(requestUrl, client)
        {
            this.SetParameter("decimalDollar", decimalDollar, true);
            this.SetParameter("fraction", fraction, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDollarFrRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDollarFrRequest(functionUrl, this.Client, options);

            if (this.HasParameter("decimalDollar"))
            {
                request.RequestBody.DecimalDollar = this.GetParameter<Newtonsoft.Json.Linq.JToken>("decimalDollar");
            }

            if (this.HasParameter("fraction"))
            {
                request.RequestBody.Fraction = this.GetParameter<Newtonsoft.Json.Linq.JToken>("fraction");
            }

            return request;
        }
    }
}
