﻿// Copyright (c) 1997-2013, SalesLogix NA, LLC. All rights reserved.

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using Remotion.Linq.Clauses;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace Saleslogix.SData.Client.Linq
{
    internal class SingleAsyncExpressionNode : SingleExpressionNode
    {
        public static readonly MethodInfo[] SupportedMethods =
            new[]
                {
                    new Func<IQueryable<object>, Task<object>>(SDataQueryableExtensions.SingleAsync).GetMethodInfo().GetGenericMethodDefinition(),
                    new Func<IQueryable<object>, Task<object>>(SDataQueryableExtensions.SingleOrDefaultAsync).GetMethodInfo().GetGenericMethodDefinition(),
                    new Func<IQueryable<object>, Expression<Func<object, bool>>, Task<object>>(SDataQueryableExtensions.SingleAsync).GetMethodInfo().GetGenericMethodDefinition(),
                    new Func<IQueryable<object>, Expression<Func<object, bool>>, Task<object>>(SDataQueryableExtensions.SingleOrDefaultAsync).GetMethodInfo().GetGenericMethodDefinition()
                };

        public SingleAsyncExpressionNode(MethodCallExpressionParseInfo parseInfo, LambdaExpression optionalPredicate)
            : base(parseInfo, optionalPredicate)
        {
        }

        protected override ResultOperatorBase CreateResultOperator(ClauseGenerationContext clauseGenerationContext)
        {
            return new SingleAsyncResultOperator(ParsedExpression.Method.Name.EndsWith("OrDefaultAsync"));
        }
    }
}