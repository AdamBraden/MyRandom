using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandom
{
    public class NumberGenerator
    {
        private Random _rand;

        public int GetInteger()
        {
            return GetIntegerWithinRange(0, int.MaxValue);
        }
        public int GetIntegerWithinRange(int Min, int Max)
        {
            if (_rand is null) { _rand = new Random(); }
            return _rand.Next(Min, Max);
        }
    }
}
