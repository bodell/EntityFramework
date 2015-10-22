// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Metadata.Internal
{
    public class InternalKeyBuilder : InternalMetadataItemBuilder<Key>
    {
        public InternalKeyBuilder([NotNull] Key key, [NotNull] InternalModelBuilder modelBuilder)
            : base(key, modelBuilder)
        {
        }

        public virtual InternalIndexBuilder IndexBuilder
            => ModelBuilder
                .Entity(Metadata.DeclaringEntityType.Name, ConfigurationSource.Convention)
                .HasIndex(Metadata.Properties.Select(p => p.Name).ToList(), ConfigurationSource.Convention);
    }
}
