using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesTestWebApplication.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuetion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
