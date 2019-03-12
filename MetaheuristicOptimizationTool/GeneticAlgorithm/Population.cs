using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemDefinition;

namespace MetaheuristicOptimizationTool.GeneticAlgorithm
{
    abstract class Population
    {
        double[] lowerBand, upperBand;
        int numberVariables, populationSize;

        public Population(double[] lowerBand, double[] upperBand, int numberVariables, int populationSize)
        {
            this.lowerBand = lowerBand;
            this.upperBand = upperBand;
            this.populationSize = populationSize;
            this.numberVariables = numberVariables;
        }

        public int getPopulationSize() { return populationSize; }
        public int getNumberVariables() { return numberVariables; }
        public double[] getUpperBand() { return upperBand; }
        public double[] getLowerBand() { return lowerBand; }
        public abstract double[][] create();

    }
    
    class RandomPopulation : Population
    {
        public RandomPopulation(double[] lowerBand, double[] upperBand, int numberVariables, int populationSize) : base(lowerBand, upperBand, numberVariables, populationSize)
        { }
        double[] low;
        double[] high;
        public override double[][] create()
        {
            
            Random rnd = new Random();
            double[][] population = new double[getPopulationSize()][];
            low = Problem.lowerBand();
            high = Problem.upperBand();
            for (int i = 0; i < getPopulationSize(); i++)
            {
                population[i] = new double[getNumberVariables()];
                for (int j = 0; j < getNumberVariables(); j++)
                {
                    population[i][j] = rnd.NextDouble() * (high[j] - low[j]) + low[j];
                }
            }

            return population;
        }
    }
}
