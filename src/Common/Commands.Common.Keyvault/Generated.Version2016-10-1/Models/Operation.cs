// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.Keyvault.Version2016_10_1.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Key Vault REST API operation definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}</param>
        /// <param name="display">Display metadata associated with the
        /// operation.</param>
        /// <param name="origin">The origin of operations.</param>
        /// <param name="serviceSpecification">One property of operation,
        /// include metric specifications.</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), string origin = default(string), ServiceSpecification serviceSpecification = default(ServiceSpecification))
        {
            Name = name;
            Display = display;
            Origin = origin;
            ServiceSpecification = serviceSpecification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation name: {provider}/{resource}/{operation}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display metadata associated with the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets the origin of operations.
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets one property of operation, include metric
        /// specifications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceSpecification")]
        public ServiceSpecification ServiceSpecification { get; set; }

    }
}
