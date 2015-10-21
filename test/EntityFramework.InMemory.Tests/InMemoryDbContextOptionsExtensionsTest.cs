// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using Microsoft.Data.Entity.Infrastructure.Internal;
using Xunit;

namespace Microsoft.Data.Entity.InMemory
{
    public class InMemoryDbContextOptionsExtensionsTest
    {
        [Fact]
        public void Can_add_extension_with_transaction_exception_suppressed()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseInMemoryDatabase().SuppressTransactionException();

            var extension = optionsBuilder.Options.Extensions.OfType<InMemoryOptionsExtension>().Single();

            Assert.Equal(false, extension.ThrowOnTransaction);
        }
    }
}
