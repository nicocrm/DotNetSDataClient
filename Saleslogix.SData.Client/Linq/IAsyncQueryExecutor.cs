﻿// Copyright (c) 1997-2013, SalesLogix NA, LLC. All rights reserved.

using System.Collections.Generic;
using System.Threading.Tasks;
using Remotion.Linq;

namespace Saleslogix.SData.Client.Linq
{
    internal interface IAsyncQueryExecutor : IQueryExecutor
    {
        Task<T> ExecuteScalarAsync<T>(QueryModel queryModel);
        Task<T> ExecuteSingleAsync<T>(QueryModel queryModel);
        Task<ICollection<T>> ExecuteCollectionAsync<T>(QueryModel queryModel);
    }
}