// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.NetApp.Models
{
    using System.Linq;

    /// <summary>
    /// Break replication request
    /// </summary>
    public partial class BreakReplicationRequest
    {
        /// <summary>
        /// Initializes a new instance of the BreakReplicationRequest class.
        /// </summary>
        public BreakReplicationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BreakReplicationRequest class.
        /// </summary>

        /// <param name="forceBreakReplication">If replication is in status transferring and you want to force break the
        /// replication, set to true
        /// </param>
        public BreakReplicationRequest(bool? forceBreakReplication = default(bool?))

        {
            this.ForceBreakReplication = forceBreakReplication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets if replication is in status transferring and you want to force
        /// break the replication, set to true
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "forceBreakReplication")]
        public bool? ForceBreakReplication {get; set; }
    }
}