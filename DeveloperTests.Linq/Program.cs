using System;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperTests.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static IEnumerable<string> GetColors()
        {
            string[] colors = { "green", "brown", "blue", "red" };
            return colors;
        }

        private static IEnumerable<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    First_name = "Billy",
                    Last_name = "Bob",
                    Email = "billy@bob.com",
                    Gender = Gender.Male,
                    Interests = new List<Interest>()
                    {
                        new Interest()
                        {
                            Id = 1,
                            InterestName = "Fishing",
                            InterestCategory = InterestCategories().Single(x => x.Id == 1)
                        }
                    }
                }
            };
        }

        private static IEnumerable<InterestCategory> InterestCategories()
        {
            return new List<InterestCategory>()
            {
                new InterestCategory()
                {
                    Id = 1,
                    CategoryName = "Outdoor"
                }
            };
        }
    }
}
