using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlingChallenge.Models
{
    public readonly struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }
        
    }
}
