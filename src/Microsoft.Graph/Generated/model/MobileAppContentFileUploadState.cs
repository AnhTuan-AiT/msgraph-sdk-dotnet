// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MobileAppContentFileUploadState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MobileAppContentFileUploadState
    {
    
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Transient Error
        /// </summary>
        TransientError = 1,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 2,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 3,
	
        /// <summary>
        /// Azure Storage Uri Request Success
        /// </summary>
        AzureStorageUriRequestSuccess = 100,
	
        /// <summary>
        /// Azure Storage Uri Request Pending
        /// </summary>
        AzureStorageUriRequestPending = 101,
	
        /// <summary>
        /// Azure Storage Uri Request Failed
        /// </summary>
        AzureStorageUriRequestFailed = 102,
	
        /// <summary>
        /// Azure Storage Uri Request Timed Out
        /// </summary>
        AzureStorageUriRequestTimedOut = 103,
	
        /// <summary>
        /// Azure Storage Uri Renewal Success
        /// </summary>
        AzureStorageUriRenewalSuccess = 200,
	
        /// <summary>
        /// Azure Storage Uri Renewal Pending
        /// </summary>
        AzureStorageUriRenewalPending = 201,
	
        /// <summary>
        /// Azure Storage Uri Renewal Failed
        /// </summary>
        AzureStorageUriRenewalFailed = 202,
	
        /// <summary>
        /// Azure Storage Uri Renewal Timed Out
        /// </summary>
        AzureStorageUriRenewalTimedOut = 203,
	
        /// <summary>
        /// Commit File Success
        /// </summary>
        CommitFileSuccess = 300,
	
        /// <summary>
        /// Commit File Pending
        /// </summary>
        CommitFilePending = 301,
	
        /// <summary>
        /// Commit File Failed
        /// </summary>
        CommitFileFailed = 302,
	
        /// <summary>
        /// Commit File Timed Out
        /// </summary>
        CommitFileTimedOut = 303,
	
    }
}
