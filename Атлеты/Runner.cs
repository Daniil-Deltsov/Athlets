using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athlets.Exceptions;

namespace Athlets
{
    public class Runner : Athlete
    {
        private const int distance = 100;
        private double time;

        public double Speed { get => distance / time; }

        public Runner(string name, double time) : base(name)
        {
            if (time <= 0)
                throw new RunnerTimeOutOfRangeException("Время должно быть больше нуля!");
            this.time = time;
        }

        public override bool IsOnDoping()
        {
            return this.Speed > 12.42;
        }

        public override string ToString()
        {
            return $"Runner {name} {time}";
        }

        public override int CompareTo(object? obj)
        {
            if (obj is Runner runner)
                return Speed.CompareTo(runner.Speed);
            return -1;
        }
    }
}
