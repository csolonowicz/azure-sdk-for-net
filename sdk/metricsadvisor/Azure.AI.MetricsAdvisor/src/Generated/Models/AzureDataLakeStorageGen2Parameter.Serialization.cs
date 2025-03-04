// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureDataLakeStorageGen2Parameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AccountName != null)
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            else
            {
                writer.WriteNull("accountName");
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey");
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (FileSystemName != null)
            {
                writer.WritePropertyName("fileSystemName");
                writer.WriteStringValue(FileSystemName);
            }
            else
            {
                writer.WriteNull("fileSystemName");
            }
            if (DirectoryTemplate != null)
            {
                writer.WritePropertyName("directoryTemplate");
                writer.WriteStringValue(DirectoryTemplate);
            }
            else
            {
                writer.WriteNull("directoryTemplate");
            }
            if (FileTemplate != null)
            {
                writer.WritePropertyName("fileTemplate");
                writer.WriteStringValue(FileTemplate);
            }
            else
            {
                writer.WriteNull("fileTemplate");
            }
            writer.WriteEndObject();
        }

        internal static AzureDataLakeStorageGen2Parameter DeserializeAzureDataLakeStorageGen2Parameter(JsonElement element)
        {
            string accountName = default;
            Optional<string> accountKey = default;
            string fileSystemName = default;
            string directoryTemplate = default;
            string fileTemplate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountName = null;
                        continue;
                    }
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountKey = null;
                        continue;
                    }
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileSystemName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileSystemName = null;
                        continue;
                    }
                    fileSystemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("directoryTemplate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        directoryTemplate = null;
                        continue;
                    }
                    directoryTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileTemplate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fileTemplate = null;
                        continue;
                    }
                    fileTemplate = property.Value.GetString();
                    continue;
                }
            }
            return new AzureDataLakeStorageGen2Parameter(accountName, accountKey.Value, fileSystemName, directoryTemplate, fileTemplate);
        }
    }
}
