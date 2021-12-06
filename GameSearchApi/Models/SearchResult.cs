﻿using System;
using GameSearchApi.Models.Interfaces;

namespace GameSearchApi.Models
{
    public class SearchResult: ISearchResult
    {
        public Guid Id { get; set; }
        public string SearchRequestId { get; set; }
    }
}