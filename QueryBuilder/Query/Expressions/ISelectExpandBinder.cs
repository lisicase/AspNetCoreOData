﻿using System.Linq.Expressions;
using Microsoft.OData.UriParser;

namespace ODataQueryBuilder.Query.Expressions
{
    /// <summary>
    /// Exposes the ability to translate an OData $select or $expand parse tree represented by <see cref="SelectExpandClause"/> to
    /// an <see cref="Expression"/>.
    /// </summary>
    public interface ISelectExpandBinder
    {
        /// <summary>
        /// Translate an OData $select or $expand tree represented by <see cref="SelectExpandClause"/> to an <see cref="Expression"/>.
        /// $select=Name&amp;$expand=Orders
        /// $it => new { .... }
        /// </summary>
        /// <param name="selectExpandClause">The original <see cref="SelectExpandClause"/>.</param>
        /// <param name="context">An instance of the <see cref="QueryBinderContext"/>.</param>
        /// <returns>The $select and $expand binder result.</returns>
        Expression BindSelectExpand(SelectExpandClause selectExpandClause, QueryBinderContext context);
    }
}
