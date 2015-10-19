// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Data.Entity.Storage
{
    public class InMemoryConnection : IConnection
    {
        public virtual ITransaction BeginTransaction()
            => new InMemoryTransaction(this);

        public virtual Task<ITransaction> BeginTransactionAsync(CancellationToken cancellationToken = default(CancellationToken))
            => Task.FromResult<ITransaction>(new InMemoryTransaction(this));
    }
}
