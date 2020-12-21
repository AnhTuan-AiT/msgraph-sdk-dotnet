// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CalendarAllowedCalendarSharingRolesRequestBuilder.
    /// </summary>
    public partial class CalendarAllowedCalendarSharingRolesRequestBuilder : BaseFunctionMethodRequestBuilder<ICalendarAllowedCalendarSharingRolesRequest>, ICalendarAllowedCalendarSharingRolesRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="CalendarAllowedCalendarSharingRolesRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="User">A User parameter for the OData method call.</param>
        public CalendarAllowedCalendarSharingRolesRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string User)
            : base(requestUrl, client)
        {
            this.SetParameter("user", User, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override ICalendarAllowedCalendarSharingRolesRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new CalendarAllowedCalendarSharingRolesRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
