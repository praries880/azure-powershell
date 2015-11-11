﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Commands.Insights.OutputClasses
{
    /// <summary>
    /// Wraps around MetricDefinition to provide summarized data about it
    /// </summary>
    public class PSMetricDefinitionNoDetails : MetricDefinition
    {
        /// <summary>
        /// Gets or sets the Name of the metric
        /// </summary>
        public new string Name { get; set; }

        /// <summary>
        /// Initializes an new instance of the PSMetricDefinitionNoDetails class
        /// </summary>
        /// <param name="metricDefinition">The MetricDefinition</param>
        public PSMetricDefinitionNoDetails(MetricDefinition metricDefinition)
        {
            // Keep the original value (localized string, Dictionary, List) in the base
            base.Name = metricDefinition.Name;

            this.Dimensions = metricDefinition.Dimensions;
            this.MetricAvailabilities = metricDefinition.MetricAvailabilities;
            this.Name = metricDefinition.Name != null ? metricDefinition.Name.Value : null;
            this.PrimaryAggregationType = metricDefinition.PrimaryAggregationType;
            this.Properties = metricDefinition.Properties;
            this.ResourceId = metricDefinition.ResourceId;
            this.Unit = metricDefinition.Unit;
        }
    }
}
