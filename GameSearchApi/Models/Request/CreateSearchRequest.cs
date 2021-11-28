using System;
using System.Collections.Generic;
using GameSearchApi.Models.Enums;

namespace GameSearchApi.Models.Request
{
    public class CreateSearchRequest
    {
        public Guid Id { get; set; }
        public SearchTypes Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? TimeIntervalInDays { get; set; }
        public string UserId { get; set; }
        public List<GameGenres>? Genres { get; set; }
        public List<string>? Titles { get; set; }
        public List<GamePlatform>? Platforms { get; set; }
        public List<GameDeveloper>? Developers { get; set; }
        public List<int>? ReleaseYears { get; set; }
    }
}