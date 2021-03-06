using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MoveWaffle_API.DataAccess;
using MoveWaffle_API.Interfaces;
using MoveWaffle_API.Models;

namespace MoveWaffle_API.Implementation
{
    public class Reader:IReader
    {
        private readonly WaffleContext _dbContext;
        public Reader(WaffleContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Models.Television GetTelevision()
        {
            return new Models.Television
            {
                Name = "",
                YearEnd = 2018,
                YearStart = 2004

            };
        }

        public User GetUser(Guid uuid)
        {
            return _dbContext.Find<User>(uuid);
        }

        public IQueryable<User> GetUsers()
        {
            //throw new NotImplementedException();
            return _dbContext.Set<User>();
        }

        public List<IMDBTitle> GetTitles()
        {
            List<IMDBTitle> resultTitles = new List<IMDBTitle>();

            string[] lines = File.ReadAllLines(Path.GetFullPath(@"D:\programming\movie-waffle\MoveWaffle_API\IMDB-datasets\title.basics.tsv"));

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
