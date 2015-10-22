// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.Data.Entity.Infrastructure;

namespace Microsoft.Data.Entity.Metadata
{
    public interface IKey : IAnnotatable
    {
        IReadOnlyList<IProperty> Properties { get; }
        IEntityType DeclaringEntityType { get; }
        IIndex Index { get; }
        IEntityType EntityType { get; }
    }
}
