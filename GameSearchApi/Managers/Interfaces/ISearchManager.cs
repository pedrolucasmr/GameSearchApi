using System.Collections.Generic;
using GameSearchApi.Models.Enums;
using GameSearchApi.Models.Request;
using GameSearchApi.Models.Interfaces;

namespace GameSearchApi.Managers.Interfaces
{
    public interface ISearchManager
    {
        ISearchResult CreateSearch(CreateSearchRequest request);
        ISearchResult FindSearch(string searchId);
        ISearchResult GetBestGames(string searchId, int? timeInterval);
        ISearchResult GetBestGamesByGenre(string searchId, List<GameGenres> genres, int? timeInterval);
        ISearchResult GetGamesByTitle(string searchId, List<string> titles);
        ISearchResult GetBestGamesByPlatform(string searchId, List<GamePlatform> platforms, int? timeInterval);
        ISearchResult GetBestGamesByDeveloper(string searchId, List<GameDeveloper> developers);
        ISearchResult GetBestGamesByReleaseYear(string searchId, List<int> years);
    }
}