// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.PowerShell;

    /// <summary>Flink cluster catalog options.</summary>
    [System.ComponentModel.TypeConverter(typeof(FlinkCatalogOptionsTypeConverter))]
    public partial class FlinkCatalogOptions
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkCatalogOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptions" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FlinkCatalogOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkCatalogOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptions" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FlinkCatalogOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkCatalogOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FlinkCatalogOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).Hive = (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkHiveCatalogOption) content.GetValueForProperty("Hive",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).Hive, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkHiveCatalogOptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("HiveMetastoreDbConnectionPasswordSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionPasswordSecret = (string) content.GetValueForProperty("HiveMetastoreDbConnectionPasswordSecret",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionPasswordSecret, global::System.Convert.ToString);
            }
            if (content.Contains("HiveMetastoreDbConnectionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUrl = (string) content.GetValueForProperty("HiveMetastoreDbConnectionUrl",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("HiveMetastoreDbConnectionUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUserName = (string) content.GetValueForProperty("HiveMetastoreDbConnectionUserName",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUserName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkCatalogOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FlinkCatalogOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hive"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).Hive = (Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkHiveCatalogOption) content.GetValueForProperty("Hive",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).Hive, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.FlinkHiveCatalogOptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("HiveMetastoreDbConnectionPasswordSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionPasswordSecret = (string) content.GetValueForProperty("HiveMetastoreDbConnectionPasswordSecret",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionPasswordSecret, global::System.Convert.ToString);
            }
            if (content.Contains("HiveMetastoreDbConnectionUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUrl = (string) content.GetValueForProperty("HiveMetastoreDbConnectionUrl",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUrl, global::System.Convert.ToString);
            }
            if (content.Contains("HiveMetastoreDbConnectionUserName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUserName = (string) content.GetValueForProperty("HiveMetastoreDbConnectionUserName",((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptionsInternal)this).HiveMetastoreDbConnectionUserName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FlinkCatalogOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FlinkCatalogOptions" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IFlinkCatalogOptions FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Flink cluster catalog options.
    [System.ComponentModel.TypeConverter(typeof(FlinkCatalogOptionsTypeConverter))]
    public partial interface IFlinkCatalogOptions

    {

    }
}