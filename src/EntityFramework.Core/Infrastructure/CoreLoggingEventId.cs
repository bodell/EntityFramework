// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Logging;

namespace Microsoft.Data.Entity.Infrastructure
{
    /// <summary>
    ///     Values that are used as the eventId when logging messages from this assembly via <see cref="ILogger"/>.
    /// </summary>
    public enum CoreLoggingEventId
    {
        /// <summary>
        ///     An error occurred while accessing the database.
        /// </summary>
        DatabaseError = 1,

        /// <summary>
        ///     A LINQ query is being translated in SQL.
        /// </summary>
        CompilingQueryModel,

        /// <summary>
        ///     The object model from a LINQ query is being optimized.
        /// </summary>
        OptimizedQueryModel,

        /// <summary>
        ///     The related data that was included in a LINQ query is being processed.
        /// </summary>
        IncludingNavigation,

        /// <summary>
        ///     Results from a LINQ query that should be tracked by the context are being processed.
        /// </summary>
        TrackingQuerySources,

        /// <summary>
        ///     The query plan for a LINQ query is being calculated.
        /// </summary>
        QueryPlan
    }
}
