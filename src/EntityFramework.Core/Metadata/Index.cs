// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata.Internal;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Metadata
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class Index : Annotatable, IMutableIndex
    {
        public Index([NotNull] IReadOnlyList<Property> properties,
            [CanBeNull] EntityType entityType = null)
        {
            Check.NotEmpty(properties, nameof(properties));
            Check.HasNoNulls(properties, nameof(properties));

            if (entityType == null)
            {
                entityType = properties[0].DeclaringEntityType;
            }

            MetadataHelper.CheckPropertiesInEntityType(properties, entityType, "properties");

            Properties = properties;
            DeclaringEntityType = entityType;
        }

        public virtual bool? IsUnique { get; set; }
        protected virtual bool DefaultIsUnique => false;

        public virtual IReadOnlyList<Property> Properties { get; }

        public virtual EntityType DeclaringEntityType { get; }

        IReadOnlyList<IProperty> IIndex.Properties => Properties;
        IReadOnlyList<IMutableProperty> IMutableIndex.Properties => Properties;
        IEntityType IIndex.DeclaringEntityType => DeclaringEntityType;
        IMutableEntityType IMutableIndex.DeclaringEntityType => DeclaringEntityType;
        bool IIndex.IsUnique => IsUnique ?? DefaultIsUnique;

        [UsedImplicitly]
        private string DebuggerDisplay => Property.Format(Properties);
    }
}
