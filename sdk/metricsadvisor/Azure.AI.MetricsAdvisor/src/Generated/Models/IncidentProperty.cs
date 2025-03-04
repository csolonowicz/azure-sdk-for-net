// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The IncidentProperty. </summary>
    internal partial class IncidentProperty
    {
        /// <summary> Initializes a new instance of IncidentProperty. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        /// <param name="incidentStatus">
        /// incident status
        /// 
        /// 
        /// 
        /// only return for alerting incident result.
        /// </param>
        internal IncidentProperty(AnomalySeverity maxSeverity, AnomalyIncidentStatus incidentStatus)
        {
            MaxSeverity = maxSeverity;
            IncidentStatus = incidentStatus;
        }

        /// <summary> Initializes a new instance of IncidentProperty. </summary>
        /// <param name="maxSeverity"> max severity of latest anomalies in the incident. </param>
        /// <param name="incidentStatus">
        /// incident status
        /// 
        /// 
        /// 
        /// only return for alerting incident result.
        /// </param>
        /// <param name="valueOfRootNode"> value of the root node. </param>
        /// <param name="expectedValueOfRootNode"> expected value of the root node given by smart detector. </param>
        internal IncidentProperty(AnomalySeverity maxSeverity, AnomalyIncidentStatus incidentStatus, double? valueOfRootNode, double? expectedValueOfRootNode)
        {
            MaxSeverity = maxSeverity;
            IncidentStatus = incidentStatus;
            ValueOfRootNode = valueOfRootNode;
            ExpectedValueOfRootNode = expectedValueOfRootNode;
        }

        /// <summary> max severity of latest anomalies in the incident. </summary>
        public AnomalySeverity MaxSeverity { get; }
        /// <summary>
        /// incident status
        /// 
        /// 
        /// 
        /// only return for alerting incident result.
        /// </summary>
        public AnomalyIncidentStatus IncidentStatus { get; }
        /// <summary> value of the root node. </summary>
        public double? ValueOfRootNode { get; }
        /// <summary> expected value of the root node given by smart detector. </summary>
        public double? ExpectedValueOfRootNode { get; }
    }
}
