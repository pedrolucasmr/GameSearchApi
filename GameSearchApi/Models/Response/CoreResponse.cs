using System;
using System.Collections.Generic;

namespace GameSearchApi.Models.Response
{
    public class CoreResponse
    {
        public string Id { get; set; }
        public List<Game> Games { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}