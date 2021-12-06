using System;
using System.Collections.Generic;
using GameSearchApi.Models.Interfaces;
using GameSearchApi.Models.Response;

namespace GameSearchApi.Models
{
    public class BestGamesSearchResult: ISearchResult
    {
        public Guid Id { get; set; }
        public string SearchRequestId { get; set; }
        public CoreResponse CoreResponse { get; set; }
    }
}