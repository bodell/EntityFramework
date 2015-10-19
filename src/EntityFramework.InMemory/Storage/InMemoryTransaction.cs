// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Storage
{
    public class InMemoryTransaction : ITransaction
    {
        public InMemoryTransaction([NotNull] IConnection connection)
        {
            Check.NotNull(connection, nameof(connection));

            Connection = connection;
        }

        public virtual IConnection Connection { get; }

        public virtual void Commit()
        {
        }

        public virtual void Rollback()
        {
        }

        public virtual void Dispose()
        {
        }
    }
}
