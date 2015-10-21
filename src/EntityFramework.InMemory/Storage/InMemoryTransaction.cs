// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure.Internal;
using Microsoft.Data.Entity.Internal;

namespace Microsoft.Data.Entity.Storage
{
    public class InMemoryTransaction : IDbContextTransaction
    {
        private readonly InMemoryOptionsExtension _inMemoryOptionsExtension;

        public InMemoryTransaction([CanBeNull] InMemoryOptionsExtension inMemoryOptionsExtension)
        {
            _inMemoryOptionsExtension = inMemoryOptionsExtension;
        }

        public virtual void Commit()
        {
            if(_inMemoryOptionsExtension.ThrowOnTransaction)
            {
                throw new InvalidOperationException(InMemoryStrings.TransactionsNotSupported);
            }
        }

        public virtual void Rollback()
        {
            if (_inMemoryOptionsExtension.ThrowOnTransaction)
            {
                throw new InvalidOperationException(InMemoryStrings.TransactionsNotSupported);
            }
        }

        public virtual void Dispose()
        {
            if (_inMemoryOptionsExtension.ThrowOnTransaction)
            {
                throw new InvalidOperationException(InMemoryStrings.TransactionsNotSupported);
            }
        }
    }
}
