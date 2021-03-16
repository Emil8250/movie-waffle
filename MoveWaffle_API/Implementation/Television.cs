using System;
using System.Collections.Generic;
using System.IO;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;
using System.Linq;

namespace MoveWaffle_API.Implementation
{
    public class Television:IReader
    {
        public Models.Television GetTelevision()
        {
            return new Models.Television
            {
                Name = "",
                YearEnd = 2018,
                YearStart = 2004

            };
        }

        public List<IMDBTitle> GetTitles()
        {
            List<IMDBTitle> resultTitles = new List<IMDBTitle>();

            string[] lines = File.ReadAllLines(@"D:\programming\movie-waffle\MoveWaffle_API\IMDB-datasets\title.basics.tsv");

            System.Diagnostics.Debug.WriteLine(lines.Length);

            foreach (string row in lines.Skip(1))
            {

                string[] epVal = row.Split('\t');
                List<string> genres = new List<string>(epVal[8].Split(','));

                try
                {
                    System.Diagnostics.Debug.WriteLine(row);

                    DateTime? startDate;
                    DateTime? endDate;

                    if (epVal[5] == "\\N")
                        startDate = null;
                    else
                        startDate = new DateTime(int.Parse(epVal[5]));

                    if (epVal[6] == "\\N")
                        endDate = null;
                    else
                        endDate = new DateTime(int.Parse(epVal[6]));


                    IMDBTitle Episode = new IMDBTitle(epVal[0], epVal[1], epVal[2], epVal[3], 
                        epVal[4] == "0" ? true : false, startDate, endDate, epVal[7], genres);
                    resultTitles.Add(Episode);
                }
                catch (System.FormatException)
                {

                    throw;
                }
            }

            return resultTitles;
        }
    }
}
