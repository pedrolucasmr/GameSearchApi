using GameSearchApi.Models.Interfaces;
using GameSearchApi.Models.Request;

namespace GameSearchApi.Repositories.Interfaces
{
    public interface ISearchRepository
    {
        ISearchResult GetSearchRequestById(string id);
        void InsertSearchRequest(CreateSearchRequest result);
        void UpdateSearchRequest(CreateSearchRequest result);
        void DeleteSearchRequestById(string id);
        
        ISearchResult GetSearchResultById(string id);
        ISearchResult GetSearchResultBySearchRequestId(string requestId);
        void InsertSearchResult(ISearchResult result);
        void UpdateSearchResult(ISearchResult result);
        void DeleteSearchResultById(string id);
    }
}