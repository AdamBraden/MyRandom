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

        // Messages provided by http://www.fortunecookiemessage.com/archive.php
        private List<string> _Messages = new List<string>{
                                "A friend asks only for your time not your money.",
                                "A smile is your passport into the hearts of others.",
                                "Change can hurt, but it leads a path to something better.",
                                "Enjoy the good luck a companion brings you.",
                                "A chance meeting opens new doors to success and friendship.",
                                "You learn from your mistakes... You will learn a lot today.",
                                "A dream you have will come true.",
                                "The greatest risk is not taking one.",
                                "A stranger, is a friend you have not spoken to yet.",
                                "A new voyage will fill your life with untold memories.",
                                };
        public string MessageOfTheDay()
        {
            if (_rand is null) { _rand = new Random(); }
            return _Messages[_rand.Next(0, _Messages.Count - 1)];
        }

    }
}
