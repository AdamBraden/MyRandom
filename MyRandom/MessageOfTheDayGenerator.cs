using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandom
{
    public class MessageOfTheDayGenerator
    {
        private Random _rand;

        private List<string> _messages = new List<string>{
                                "A fool and his money are soon parted",
                                "A bird in hand is worth 2 in the bush",
                                "Do unto others as you'd have them to unto you"                            
                                };
        public string MessageOfTheDay()
        {
            if (_rand is null) { _rand = new Random(); }
            return _messages[_rand.Next(0, _messages.Count - 1)];
        }

    }
}
