// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> Type of data source credential. </summary>
    internal readonly partial struct DataSourceCredentialType : IEquatable<DataSourceCredentialType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DataSourceCredentialType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataSourceCredentialType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureSQLConnectionStringValue = "AzureSQLConnectionString";
        private const string DataLakeGen2SharedKeyValue = "DataLakeGen2SharedKey";
        private const string ServicePrincipalValue = "ServicePrincipal";
        private const string ServicePrincipalInKVValue = "ServicePrincipalInKV";

        /// <summary> AzureSQLConnectionString. </summary>
        public static DataSourceCredentialType AzureSQLConnectionString { get; } = new DataSourceCredentialType(AzureSQLConnectionStringValue);
        /// <summary> DataLakeGen2SharedKey. </summary>
        public static DataSourceCredentialType DataLakeGen2SharedKey { get; } = new DataSourceCredentialType(DataLakeGen2SharedKeyValue);
        /// <summary> ServicePrincipal. </summary>
        public static DataSourceCredentialType ServicePrincipal { get; } = new DataSourceCredentialType(ServicePrincipalValue);
        /// <summary> ServicePrincipalInKV. </summary>
        public static DataSourceCredentialType ServicePrincipalInKV { get; } = new DataSourceCredentialType(ServicePrincipalInKVValue);
        /// <summary> Determines if two <see cref="DataSourceCredentialType"/> values are the same. </summary>
        public static bool operator ==(DataSourceCredentialType left, DataSourceCredentialType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataSourceCredentialType"/> values are not the same. </summary>
        public static bool operator !=(DataSourceCredentialType left, DataSourceCredentialType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataSourceCredentialType"/>. </summary>
        public static implicit operator DataSourceCredentialType(string value) => new DataSourceCredentialType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataSourceCredentialType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataSourceCredentialType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
