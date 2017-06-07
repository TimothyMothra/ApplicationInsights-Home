
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.9.0.0
//   File : ContextTagKeys_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Microsoft.ApplicationInsights.Ingestion.Maestro.Contracts
{
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.9.0.0")]
    public partial class ContextTagKeys
    {
        public string ApplicationVersion { get; set; }

        public string DeviceId { get; set; }

        public string DeviceLocale { get; set; }

        public string DeviceModel { get; set; }

        public string DeviceOEMName { get; set; }

        public string DeviceOSVersion { get; set; }

        public string DeviceType { get; set; }

        public string LocationIp { get; set; }

        public string OperationId { get; set; }

        public string OperationName { get; set; }

        public string OperationParentId { get; set; }

        public string OperationSyntheticSource { get; set; }

        public string OperationCorrelationVector { get; set; }

        public string SessionId { get; set; }

        public string SessionIsFirst { get; set; }

        public string UserAccountId { get; set; }

        public string UserId { get; set; }

        public string UserAuthUserId { get; set; }

        public string CloudRole { get; set; }

        public string CloudRoleInstance { get; set; }

        public string InternalSdkVersion { get; set; }

        public string InternalAgentVersion { get; set; }

        public string InternalNodeName { get; set; }

        public ContextTagKeys()
            : this("AI.ContextTagKeys", "ContextTagKeys")
        {}

        protected ContextTagKeys(string fullName, string name)
        {
            ApplicationVersion = "ai.application.ver";
            DeviceId = "ai.device.id";
            DeviceLocale = "ai.device.locale";
            DeviceModel = "ai.device.model";
            DeviceOEMName = "ai.device.oemName";
            DeviceOSVersion = "ai.device.osVersion";
            DeviceType = "ai.device.type";
            LocationIp = "ai.location.ip";
            OperationId = "ai.operation.id";
            OperationName = "ai.operation.name";
            OperationParentId = "ai.operation.parentId";
            OperationSyntheticSource = "ai.operation.syntheticSource";
            OperationCorrelationVector = "ai.operation.correlationVector";
            SessionId = "ai.session.id";
            SessionIsFirst = "ai.session.isFirst";
            UserAccountId = "ai.user.accountId";
            UserId = "ai.user.id";
            UserAuthUserId = "ai.user.authUserId";
            CloudRole = "ai.cloud.role";
            CloudRoleInstance = "ai.cloud.roleInstance";
            InternalSdkVersion = "ai.internal.sdkVersion";
            InternalAgentVersion = "ai.internal.agentVersion";
            InternalNodeName = "ai.internal.nodeName";
        }
    }
} // AI
