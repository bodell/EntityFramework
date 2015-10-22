// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Entity.Internal;

namespace Microsoft.Data.Entity.Metadata.Internal
{
    internal static class MetadataHelper
    {
        public static void CheckPropertiesInEntityType(IReadOnlyList<Property> properties, EntityType entityType, string argumentName)
        {
            foreach (var property in properties)
            {
                if (property.DeclaringEntityType != entityType
                    && entityType.FindProperty(property.Name) != property)
                {
                    throw new ArgumentException(
                        CoreStrings.InconsistentEntityType(argumentName));
                }
            }
        }
    }
}
