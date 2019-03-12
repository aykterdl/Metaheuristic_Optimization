using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaheuristicOptimizationTool.GeneticAlgorithm
{
    abstract class CrossOver
    {
        Random rnd;

        public CrossOver() { rnd = new Random(); }

        public Random getRandom() { return rnd; }

        public abstract double[][] make(double[] x1, double[] x2);
    }

    class SingleCrossOver : CrossOver
    {
        public override double[][] make(double[] x1, double[] x2)
        {
            double[][] cons = new double[2][];

            cons[0] = new double[x1.Length];
            cons[1] = new double[x2.Length];

            int index = getRandom().Next(1, x1.Length);

            for (int i = 0; i < index; i++)
            {
                cons[0][i] = x1[i];
                cons[1][i] = x2[i];

            }
            for (int i = index; i < x1.Length; i++)
            {
                cons[1][i] = x1[i];
                cons[0][i] = x2[i];
            }

            return cons;
        }
    }

    class DoubleCrossOver : CrossOver
    {
        public override double[][] make(double[] x1, double[] x2)
        {
            double[][] cons = new double[2][];
            cons[0] = new double[x1.Length];
            cons[1] = new double[x1.Length];

            int index = getRandom().Next(1, x1.Length);
            int index2 = getRandom().Next(1, x1.Length);

            if (index < index2)
            {
                for (int i = 0; i < index; i++)
                {
                    cons[0][i] = x1[i];
                    cons[1][i] = x2[i];
                }
                for (int i = index; i < index2; i++)
                {
                    cons[1][i] = x1[i];
                    cons[0][i] = x2[i];
                }
                for (int i = index2; i < x1.Length; i++)
                {
                    cons[0][i] = x1[i];
                    cons[1][i] = x2[i];
                }
            }
            else
            {
                for (int i = 0; i < index2; i++)
                {
                    cons[0][i] = x1[i];
                    cons[1][i] = x2[i];
                }

                for (int i = index2; i < index; i++)
                {
                    cons[1][i] = x1[i];
                    cons[0][i] = x2[i];
                }
                for (int i = index; i < x1.Length; i++)
                {
                    cons[1][i] = x1[i];
                    cons[0][i] = x2[i];
                }
            }



            return cons;
        }
    }
}
