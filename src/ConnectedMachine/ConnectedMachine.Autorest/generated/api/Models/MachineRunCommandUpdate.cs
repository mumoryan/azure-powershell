// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Describes a Machine Extension Update.</summary>
    public partial class MachineRunCommandUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommandUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommandUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdate __resourceUpdate = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceUpdate();

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)__resourceUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)__resourceUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="MachineRunCommandUpdate" /> instance.</summary>
        public MachineRunCommandUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceUpdate), __resourceUpdate);
            await eventListener.AssertObjectIsValid(nameof(__resourceUpdate), __resourceUpdate);
        }
    }
    /// Describes a Machine Extension Update.
    public partial interface IMachineRunCommandUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdate
    {

    }
    /// Describes a Machine Extension Update.
    internal partial interface IMachineRunCommandUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal
    {

    }
}