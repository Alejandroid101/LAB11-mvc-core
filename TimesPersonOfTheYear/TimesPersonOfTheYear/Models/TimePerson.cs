using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TimesPersonOfTheYear.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        public TimePerson(int year, string honor, string name, string country, int birthYear, int deathYear, string title, string category, string context)
        {
            Year = year;
            Honor = honor;
            Name = name;
            Country = country;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Title = title;
            Category = category;
            Context = context;
        }

        public static List<TimePerson> GetPersons(int yearFrom, int yearTo)
        {
            string path = "./wwwroot/personOfTheYear.csv";
            string[] myFile = File.ReadAllLines(path);

            for(int i = 1; i < myFile.Length; i++)
            {
                
                string[] range = myFile[i].Split(',');
                //aqui me quede
                TimePerson person = new TimePerson
                {

                }
            }

            return null;
        }
    }
}
