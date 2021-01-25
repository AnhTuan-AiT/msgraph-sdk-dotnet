// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sign In.
    /// </summary>
    public partial class SignIn : Entity
    {
    
		///<summary>
		/// The SignIn constructor
		///</summary>
        public SignIn()
        {
            this.ODataType = "microsoft.graph.signIn";
        }
	
        /// <summary>
        /// Gets or sets app display name.
        /// App name displayed in the Azure Portal.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// Unique GUID representing the app ID in the Azure Active Directory.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets applied conditional access policies.
        /// </summary>
        [JsonPropertyName("appliedConditionalAccessPolicies")]
        public IEnumerable<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
        /// </summary>
        [JsonPropertyName("clientAppUsed")]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// Reports status of an activated conditional access policy. Possible values are: success, failure, notApplied, and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("conditionalAccessStatus")]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
        /// </summary>
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// Device information from where the sign-in occurred; includes device ID, operating system, and browser.
        /// </summary>
        [JsonPropertyName("deviceDetail")]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// IP address of the client used to sign in.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets is interactive.
        /// Indicates if a sign-in is interactive or not.
        /// </summary>
        [JsonPropertyName("isInteractive")]
        public bool? IsInteractive { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// Provides the city, state, and country code where the sign-in originated.
        /// </summary>
        [JsonPropertyName("location")]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// Name of the resource the user signed into.
        /// </summary>
        [JsonPropertyName("resourceDisplayName")]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// ID of the resource that the user signed into.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// Provides the 'reason' behind a specific state of a risky user, sign-in or a risk event. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Note: Details for this property require an Azure AD Premium P2 license. Other licenses return the value hidden.
        /// </summary>
        [JsonPropertyName("riskDetail")]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types.
        /// Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskEventTypes")]
        public IEnumerable<RiskEventType> RiskEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types_v2.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskEventTypes_v2")]
        public IEnumerable<string> RiskEventTypes_v2 { get; set; }
    
        /// <summary>
        /// Gets or sets risk level aggregated.
        /// Aggregated risk level. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelAggregated")]
        public RiskLevel? RiskLevelAggregated { get; set; }
    
        /// <summary>
        /// Gets or sets risk level during sign in.
        /// Risk level during sign-in. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelDuringSignIn")]
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// Reports status of the risky user, sign-in, or a risk event. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskState")]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Sign-in status. Includes the error code and description of the error (in case of a sign-in failure).
        /// </summary>
        [JsonPropertyName("status")]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Display name of the user that initiated the sign-in.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// ID of the user that initiated the sign-in.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name of the user that initiated the sign-in.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

