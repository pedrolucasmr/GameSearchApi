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
        ISearchResult GetBestGames(int? timeInterval);
        ISearchResult GetBestGamesByGenre(List<GameGenres> genres, int? timeInterval);
        ISearchResult GetGamesByTitle(List<string> titles);
        ISearchResult GetBestGamesByPlatform(List<GamePlatform> platforms, int? timeInterval);
        ISearchResult GetBestGamesByDeveloper(List<GameDeveloper> developers);
        ISearchResult GetBestGamesByReleaseYear(List<int> years);
    }
}