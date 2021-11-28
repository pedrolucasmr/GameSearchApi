using System.Collections.Generic;
using GameSearchApi.Managers.Interfaces;
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
        public SearchManager(ISearchRepository searchRepository)
        {
            this._searchRepository = searchRepository;
        }
        
        public ISearchResult CreateSearch(CreateSearchRequest request)
        {
            ISearchResult result;
            if (FindSearch(request.Id.ToString()) != null)
            {
                result = this._searchRepository.GetSearchResultBySearchRequestId(request.Id.ToString());
                
                if (result != null)
                {
                    return result;
                }
                
                this._searchRepository.UpdateSearchRequest(request);
            }
            switch (request.Type)
            {
                case SearchTypes.GameSearch:
                    return GetBestGames(request.TimeIntervalInDays);
                case SearchTypes.GenreSearch:
                    return GetBestGamesByGenre(request.Genres, request.TimeIntervalInDays);
                case SearchTypes.TitleSearch:
                    return GetGamesByTitle(request.Titles);
                case SearchTypes.DeveloperSearch:
                    return GetBestGamesByDeveloper(request.Developers);
                case SearchTypes.PlatformSearch:
                    return GetBestGamesByPlatform(request.Platforms, request.TimeIntervalInDays);
                case SearchTypes.ReleaseYearSearch:
                    return GetBestGamesByReleaseYear(request.ReleaseYears);
                default:
                    throw new BadRequestException("Invalid Search Type");
            }
        }

        public ISearchResult FindSearch(string searchId)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGames(int? timeInterval = 7)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGamesByGenre(List<GameGenres> genres, int? timeInterval = 7)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetGamesByTitle(List<string> titles)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGamesByPlatform(List<GamePlatform> platforms, int? timeInterval = 7)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGamesByDeveloper(List<GameDeveloper> developers)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetBestGamesByReleaseYear(List<int> years)
        {
            throw new System.NotImplementedException();
        }
    }
}