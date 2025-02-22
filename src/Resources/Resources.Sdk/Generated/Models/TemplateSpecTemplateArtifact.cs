// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Template Spec artifact containing an embedded Azure
    /// Resource Manager template.
    /// </summary>
    [Newtonsoft.Json.JsonObject("template")]
    public partial class TemplateSpecTemplateArtifact : TemplateSpecArtifact
    {
        /// <summary>
        /// Initializes a new instance of the TemplateSpecTemplateArtifact
        /// class.
        /// </summary>
        public TemplateSpecTemplateArtifact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateSpecTemplateArtifact
        /// class.
        /// </summary>
        /// <param name="path">A filesystem safe relative path of the
        /// artifact.</param>
        /// <param name="template">The Azure Resource Manager template.</param>
        public TemplateSpecTemplateArtifact(string path, object template)
            : base(path)
        {
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Resource Manager template.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
        }
    }
}
