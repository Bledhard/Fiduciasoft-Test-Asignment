using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.Core
{
    public static class DataService
    {
        static DataService()
        {
            var eagles = new Team { Name = "Eagles" };
            var bears = new Team { Name = "Bears" };

            Teams = new List<Team>
            {
                eagles,
                bears,
            };

            People = new List<Person>
            {
                new Person { Name = "John" },
                new Person { Name = "Joe" },
                new Person { Name = "Ed", Team = eagles },
                new Person { Name = "Merphy", Team = bears },
                new Person { Name = "Met", Team = bears },
            };
        }

        public static IEnumerable<Team> Teams { get; set; }
        public static IEnumerable<Person> People { get; set; }

        public static void AddPersonToTheTeam(string teamName, string personName)
        {
            var person = People.Where(p => p.Name == personName).FirstOrDefault();
            person.Team = Teams.Where(t => t.Name == teamName).FirstOrDefault();
        }
    }
}
