using GameSearchApi.Models.Interfaces;
using GameSearchApi.Models.Request;
using GameSearchApi.Repositories.Interfaces;

namespace GameSearchApi.Repositories
{
    public class SearchRepository: ISearchRepository
    {
        public ISearchResult GetSearchRequestById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertSearchRequest(CreateSearchRequest result)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSearchRequest(CreateSearchRequest result)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSearchRequestById(string id)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetSearchResultById(string id)
        {
            throw new System.NotImplementedException();
        }

        public ISearchResult GetSearchResultBySearchRequestId(string requestId)
        {
            throw new System.NotImplementedException();
        }

        public void InsertSearchResult(ISearchResult result)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateSearchResult(ISearchResult result)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSearchResultById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}