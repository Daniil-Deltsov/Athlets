using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlets
{
    public abstract class Athlete : IComparable
    {
        protected string name;
        public Athlete(string name)
        {
            this.name = name;
        }

        public abstract int CompareTo(object? obj);

        public abstract bool IsOnDoping();
    }
}
