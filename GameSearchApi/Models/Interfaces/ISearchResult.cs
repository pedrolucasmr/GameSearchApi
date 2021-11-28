using System;

namespace GameSearchApi.Models.Interfaces
{
    public class ISearchResult
    {
        Guid Id { get; set; }
        private string SearchRequestId { get; set; }
    }
}