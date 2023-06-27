﻿namespace ODataQueryBuilder.Query.Validator
{
    public class QueryValidators
    {
        public QueryValidators() { }

        IComputeQueryValidator ComputeQueryValidator { get; set; }

        ICountQueryValidator CountQueryValidator { get; set; }

        IFilterQueryValidator FilterQueryValidator { get; set; }

        IODataQueryValidator ODataQueryValidator { get; set; }

        IOrderByQueryValidator OrderByQueryValidator { get; set; }

        ISelectExpandQueryValidator SelectExpandQueryValidator { get; set; }

        ISkipQueryValidator SkipQueryValidator { get; set; }

        ISkipTokenQueryValidator SkipTokenQueryValidator { get; set; }

        ITopQueryValidator TopQueryValidator { get; set; }

        public IComputeQueryValidator GetComputeQueryValidator()
        {
            return ComputeQueryValidator ??= new ComputeQueryValidator();
        }

        public ICountQueryValidator GetCountQueryValidator()
        {
            return CountQueryValidator ??= new CountQueryValidator();
        }

        public IFilterQueryValidator GetFilterQueryValidator()
        {
            return FilterQueryValidator ??= new FilterQueryValidator();
        }

        public IODataQueryValidator GetODataQueryValidator()
        {
            return ODataQueryValidator ??= new ODataQueryValidator();
        }

        public IOrderByQueryValidator GetOrderByQueryValidator()
        {
            return OrderByQueryValidator ??= new OrderByQueryValidator();
        }

        public ISelectExpandQueryValidator GetSelectExpandQueryValidator()
        {
            return SelectExpandQueryValidator ??= new SelectExpandQueryValidator();
        }

        public ISkipQueryValidator GetSkipQueryValidator()
        {
            return SkipQueryValidator ??= new SkipQueryValidator();
        }

        public ISkipTokenQueryValidator GetSkipTokenQueryValidator()
        {
            return SkipTokenQueryValidator ??= new SkipTokenQueryValidator();
        }

        public ITopQueryValidator GetTopQueryValidator()
        {
            return TopQueryValidator ??= new TopQueryValidator();
        }
    }
}
