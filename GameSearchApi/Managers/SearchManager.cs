using System;
using System.Collections.Generic;
using GameSearchApi.Helpers;
using GameSearchApi.Managers.Interfaces;
using GameSearchApi.Mappers;
using GameSearchApi.Models;
using GameSearchApi.Models.Enums;
using GameSearchApi.Models.Interfaces;
using GameSearchApi.Models.Request;
using GameSearchApi.Repositories;
using GameSearchApi.Repositories.Interfaces;
using WebApi.Models.Exceptions;

namespace GameSearchApi.Managers
{
    public class SearchManager : ISearchManager
    {
        private readonly ISearchRepository _searchRepository;
        private readonly CoreHelper _coreHelper;
        public SearchManager(ISearchRepository searchRepository, CoreHelper coreHelper)
        {
            this._searchRepository = searchRepository;
            this._coreHelper = coreHelper;
        }
        
        public ISearchResult CreateSearch(CreateSearchRequest request)
        {
            if (FindSearch(request.Id.ToString()) != null)
            {
                var result = this._searchRepository.GetSearchResultBySearchRequestId(request.Id.ToString());
                
                if (result != null)
                {
                    return result;
                }
                
                this._searchRepository.UpdateSearchRequest(request);
            }
            switch (request.Type)
            {
                case SearchTypes.GameSearch:
                    return GetBestGames(request.Id.ToString(), request.TimeIntervalInDays);
                case SearchTypes.GenreSearch:
                    return GetBestGamesByGenre(request.Id.ToString(),request.Genres, request.TimeIntervalInDays);
                case SearchTypes.TitleSearch:
                    return GetGamesByTitle(request.Id.ToString(),request.Titles);
                case SearchTypes.DeveloperSearch:
                    return GetBestGamesByDeveloper(request.Id.ToString(),request.Developers);
                case SearchTypes.PlatformSearch:
                    return GetBestGamesByPlatform(request.Id.ToString(),request.Platforms, request.TimeIntervalInDays);
                case SearchTypes.ReleaseYearSearch:
                    return GetBestGamesByReleaseYear(request.Id.ToString(),request.ReleaseYears);
                default:
                    throw new BadRequestException("Invalid Search Type");
            }
        }

        public ISearchResult FindSearch(string searchId)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGames(string searchId, int? timeInterval = 7)
        {
            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(null));
        }

        public ISearchResult GetBestGamesByGenre(string searchId, List<GameGenres> genres, int? timeInterval = 7)
        {
            var coreRequest = new CoreRequest(createdAt: DateTime.UtcNow, genres);

            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(coreRequest));
        }

        public ISearchResult GetGamesByTitle(string searchId, List<string> titles)
        {
            var coreRequest = new CoreRequest(createdAt: DateTime.UtcNow, titles:titles);

            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(coreRequest));
        }

        public ISearchResult GetBestGamesByPlatform(string searchId, List<GamePlatform> platforms, int? timeInterval = 7)
        {
            var coreRequest = new CoreRequest(createdAt: DateTime.UtcNow, platforms:platforms);

            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(coreRequest));
        }

        public ISearchResult GetBestGamesByDeveloper(string searchId, List<GameDeveloper> developers)
        {
            var coreRequest = new CoreRequest(createdAt: DateTime.UtcNow, developers:developers);

            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(coreRequest));
        }

        public ISearchResult GetBestGamesByReleaseYear(string searchId, List<int> years)
        {
            var coreRequest = new CoreRequest(createdAt: DateTime.UtcNow, releaseYears:years);

            return SearchResultMapper.MapBestGamesSearchResult(searchId, this._coreHelper.CreateSearch(coreRequest));
        }
    }
}