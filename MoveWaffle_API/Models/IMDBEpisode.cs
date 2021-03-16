using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveWaffle_API.Models
{
    /// <summary>
    /// tconst(string) - alphanumeric identifier of episode
    /// parentTconst(string) - alphanumeric identifier of the parent TV Series
    /// seasonNumber(integer) – season number the episode belongs to
    /// episodeNumber(integer) – episode number of the tconst in the TV series
    /// </summary>
    public class IMDBEpisode
    {
        public string tconst { get; set; }
        public string parentTconst { get; set; }
        public int seasonNumber { get; set; }
        public int episodeNumber { get; set; }
    }
}
