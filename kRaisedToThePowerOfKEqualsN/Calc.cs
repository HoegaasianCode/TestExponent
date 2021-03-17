using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace kRaisedToThePowerOfKEqualsN
{
    public class Calc
    {
        private readonly int _k;
        private readonly string _n;

        public Calc(string n, int k)
        {
            _n = n;
            _k = k;
        }

        public bool IsSquare()
        {
            var result = Double.Parse(_n);
            return Math.Sqrt(result) == _k;
        }
    }
}
