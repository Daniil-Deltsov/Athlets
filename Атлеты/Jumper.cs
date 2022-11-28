using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlets
{
    public class Jumper : Athlete
    {
        private double distance;

        public double Distance { get => distance; }
        public Jumper(string name, double distance) : base(name)
        {
            this.distance = distance;
        }

        public override bool IsOnDoping()
        {
            return distance > 8.90;
        }

        public override string ToString()
        {
            return $"Jumper {name} {distance}";
        }

        public override int CompareTo(object? obj)
        {
            if (obj is Jumper jumper)
                return Distance.CompareTo(jumper.Distance);
            return -1;
        }
    }
}
