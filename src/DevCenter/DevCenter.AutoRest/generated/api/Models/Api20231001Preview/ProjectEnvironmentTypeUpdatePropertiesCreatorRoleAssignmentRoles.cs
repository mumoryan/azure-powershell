// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Extensions;

    /// <summary>A map of roles to assign to the environment creator.</summary>
    public partial class ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRolesInternal
    {

        /// <summary>
        /// Creates an new <see cref="ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles" /> instance.
        /// </summary>
        public ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles()
        {

        }
    }
    /// A map of roles to assign to the environment creator.
    public partial interface IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRoles :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20231001Preview.IEnvironmentRole>
    {

    }
    /// A map of roles to assign to the environment creator.
    internal partial interface IProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignmentRolesInternal

    {

    }
}