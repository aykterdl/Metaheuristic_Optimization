using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaheuristicOptimizationTool.GeneticAlgorithm
{
    abstract class Mutation
    {
        Random rnd;
        double constant;

        public Mutation(double constant)
        {
            rnd = new Random();
            this.constant = constant;
        }

        public Random getRandom() { return rnd; }

        public double getConstant() { return constant; }

        public abstract double[] make(double[] x);
    }

    class ChangeMutation : Mutation
    {
        public ChangeMutation(double constant) : base(constant) { }
        public override double[] make(double[] x)
        {
            double temp;
            int index = getRandom().Next(0, x.Length);
            int pow = getRandom().Next(0, x.Length);
            temp = x[index];
            x[index] = x[pow];
            x[pow] = temp;

            return x;
        }
    }
}
