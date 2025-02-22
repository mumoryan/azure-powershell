
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Updates a Custom Location with the specified Resource Name in the specified Resource Group and Subscription.
.Description
Updates a Custom Location with the specified Resource Name in the specified Resource Group and Subscription.
.Example
Update-AzCustomLocation -ResourceGroupName azps_test_group -Name azps_test_cluster_1 -ClusterExtensionId "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/azps_test_group/providers/Microsoft.Kubernetes/connectedClusters/azps_test_cluster/providers/Microsoft.KubernetesConfiguration/extensions/azps_test_extension" -HostResourceId "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourceGroups/azps_test_group/providers/Microsoft.Kubernetes/connectedClusters/azps_test_cluster" -Namespace arc
.Example
Get-AzCustomLocation -ResourceGroupName azps_test_group -Name azps_test_cluster | Update-AzCustomLocation

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocation
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <ICustomLocationIdentity>: Identity Parameter
  [ChildResourceName <String>]: Resource Sync Rule name.
  [Id <String>]: Resource identity path
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ResourceName <String>]: Custom Locations name.
  [SubscriptionId <String>]: The ID of the target subscription.
.Link
https://learn.microsoft.com/powershell/module/az.customlocation/update-azcustomlocation
#>
function Update-AzCustomLocation {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocation])]
    [CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Path')]
        [System.String]
        # Custom Locations name.
        ${Name},

        [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Path')]
        [System.String]
        # The name of the resource group.
        # The name is case insensitive.
        ${ResourceGroupName},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaJsonFilePath')]
        [Parameter(ParameterSetName='UpdateViaJsonString')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # The ID of the target subscription.
        ${SubscriptionId},

        [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ICustomLocationIdentity]
        # Identity Parameter
        # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
        ${InputObject},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # The type of the Custom Locations authentication
        ${AuthenticationType},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # The kubeconfig value.
        ${AuthenticationValue},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String[]]
        # Contains the reference to the add-on that contains charts to deploy CRDs and operators.
        ${ClusterExtensionId},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # Display name for the Custom Locations location.
        ${DisplayName},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # Connected Cluster or AKS Cluster.
        # The Custom Locations RP will perform a checkAccess API for listAdminCredentials permissions.
        ${HostResourceId},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PSArgumentCompleterAttribute("SystemAssigned", "None")]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # The identity type.
        ${IdentityType},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # Kubernetes namespace that will be created on the specified cluster.
        ${Namespace},

        [Parameter(ParameterSetName='UpdateExpanded')]
        [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IPatchableCustomLocationsTags]))]
        [System.Collections.Hashtable]
        # Resource tags
        ${Tag},

        [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # Path of Json file supplied to the Update operation
        ${JsonFilePath},

        [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Body')]
        [System.String]
        # Json string supplied to the Update operation
        ${JsonString},

        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},

        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},

        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )

    process {
        try {
            Az.CustomLocation.internal\Update-AzCustomLocation @PSBoundParameters
        }
        catch {
            throw
        }
    }
}
