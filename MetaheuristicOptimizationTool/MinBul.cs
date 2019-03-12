using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaheuristicOptimizationTool
{
    abstract class MinBul
    {
        double[] fitness;
        public MinBul(double[] fitness)
        {
            this.fitness = fitness;
        }
        public double[] getFitness() { return fitness; }

        public abstract int minBul();

    }

    class TekMinBul : MinBul
    {
        public TekMinBul(double[] fitness) : base(fitness) { }

        double[] fitness;

        public override int minBul()
        {
            fitness = getFitness();

            double kucuk = fitness[0];
            int index=0;

            for (int i = 0; i < fitness.Length; i++)
            {
                if (kucuk > fitness[i])
                {
                    kucuk = fitness[i];
                    index = i;
                }

            }
            // return kucuk;

            return index;
        }
    }
}
