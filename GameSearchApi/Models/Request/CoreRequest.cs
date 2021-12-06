using System;
using System.Collections.Generic;
using GameSearchApi.Models.Enums;
using GameSearchApi.Models.Response;

namespace GameSearchApi.Models.Request
{
    public class CoreRequest
    {
        public CoreRequest(DateTime createdAt)
        {
            this.Id = new Guid();
            this.CreatedAt = createdAt;
        }
        
        public CoreRequest(
            DateTime createdAt,
            List<GameGenres> genres = null,
            List<string> titles = null,
            List<GamePlatform> platforms = null,
            List<GameDeveloper> developers = null,
            List<int> releaseYears = null)
        {
            this.Id = new Guid();
            this.CreatedAt = createdAt;
            this.Genres = genres;
            this.Titles = titles;
            this.Platforms = platforms;
            this.Developers = developers;
            this.ReleaseYears = releaseYears;
        }
        
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<GameGenres>? Genres { get; set; }
        public List<string>? Titles { get; set; }
        public List<GamePlatform>? Platforms { get; set; }
        public List<GameDeveloper>? Developers { get; set; }
        public List<int>? ReleaseYears { get; set; }
    }
}