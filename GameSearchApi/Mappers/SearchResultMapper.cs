using System;
using GameSearchApi.Models;
using GameSearchApi.Models.Response;

namespace GameSearchApi.Mappers
{
    public static class SearchResultMapper
    {
        public static BestGamesSearchResult MapBestGamesSearchResult(string searchId, CoreResponse coreResponse)
        {
            return new BestGamesSearchResult
            {
                Id = new Guid(),
                SearchRequestId = searchId,
                CoreResponse = coreResponse
            };
        }
    }
}