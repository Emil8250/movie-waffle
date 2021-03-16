using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoveWaffle_API.Models
{

    public class IMDBTitle
    {
        /// <summary>
        /// tconst(string) - alphanumeric unique identifier of the title
        /// titleType(string) – the type/format of the title(e.g.movie, short, tvseries, tvepisode, video, etc)
        /// primaryTitle(string) – the more popular title / the title used by the filmmakers on promotional materials at the point of release
        /// originalTitle(string) - original title, in the original language
        /// isAdult(boolean) - 0: non-adult title; 1: adult title
        /// startYear(YYYY) – represents the release year of a title.In the case of TV Series, it is the series start year
        /// endYear(YYYY) – TV Series end year. ‘\N’ for all other title types
        /// runtimeMinutes – primary runtime of the title, in minutes
        /// genres (string array) – includes up to three genres associated with the title
        /// </summary>
        public string tconst { get; set; }
        public string titleType { get; set; }
        public string primaryTitle { get; set; }
        public string originalTitle { get; set; }
        public bool isAdult { get; set; }
        public DateTime? startYear { get; set; }
        public DateTime? endYear { get; set; }
        public string runtimeMinutes { get; set; }
        public List<string> genres { get; set; }
        public IMDBRating rating { get; set; }
        public List<IMDBEpisode> episodes { get; set; }

        public IMDBTitle(string Tconst, string TitleType, string PrimaryTitle, string OriginalTitle,
                        bool IsAdult, DateTime? StartYear, DateTime? EndYear, string RuntimeMinutes, List<string> Genres)
        {
            tconst = Tconst;
            titleType = TitleType;
            primaryTitle = PrimaryTitle;
            originalTitle = OriginalTitle;
            isAdult = IsAdult;
            startYear = StartYear;
            endYear = EndYear;
            runtimeMinutes = RuntimeMinutes;
            genres = Genres;
        }
    }
}
