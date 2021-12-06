using System;

namespace GameSearchApi.Models.Interfaces
{
    public interface ISearchResult
    {
        abstract Guid Id { get; set; }
        abstract string SearchRequestId { get; set; }
    }
}