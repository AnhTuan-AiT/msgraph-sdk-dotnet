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
    /// The interface IUserMailFoldersCollectionRequestBuilder.
    /// </summary>
    public partial interface IUserMailFoldersCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IUserMailFoldersCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IUserMailFoldersCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IMailFolderRequestBuilder"/> for the specified MailFolder.
        /// </summary>
        /// <param name="id">The ID for the MailFolder.</param>
        /// <returns>The <see cref="IMailFolderRequestBuilder"/>.</returns>
        IMailFolderRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for MailFolderDelta.
        /// </summary>
        /// <returns>The <see cref="IMailFolderDeltaRequestBuilder"/>.</returns>
        IMailFolderDeltaRequestBuilder Delta();
    }
}
