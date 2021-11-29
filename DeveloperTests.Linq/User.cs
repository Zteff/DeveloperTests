using System.Collections.Generic;

namespace DeveloperTests.Linq
{
    public class User
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public IEnumerable<Interest> Interests { get; set; }
    }
}