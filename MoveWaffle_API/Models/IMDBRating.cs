using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveWaffle_API.Models
{

    public class IMDBRating
    {
        /// <summary>
        /// tconst (string) - alphanumeric unique identifier of the title
        /// averageRating – weighted average of all the individual user ratings
        /// numVotes - number of votes the title has received
        /// </summary>
        public string tconst { get; set; }
        public string averageRating { get; set; }
        public int numVotes { get; set; }
    }
}
