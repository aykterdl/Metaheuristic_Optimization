using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaheuristicOptimizationTool.GeneticAlgorithm
{
    abstract class Selection
    {
        int populationSize;
        //double[] fitness;
        public Selection(int populationSize)
        {
            this.populationSize = populationSize;
        }

        /*  public Selection(double[] fitness)
          {
              this.fitness = fitness;
          }*/

        public int getPopulationSize() { return populationSize; }
        public abstract int[] choose();
    }

    class RandomSelection : Selection
    {

        public RandomSelection(int populationSize) : base(populationSize) { }
        public override int[] choose()
        {
            int[] numbers = new int[2];
            Random rnd = new Random();

            numbers[0] = rnd.Next(0, getPopulationSize());
            numbers[1] = numbers[0];

            while (numbers[0] == numbers[1])
            {
                numbers[1] = rnd.Next(0, getPopulationSize());
            }

            return numbers;
        }
    }

    class TournametSelection : Selection
    {
        double[] fitnesDegerleri = new double[1000];

        public void getFitness(double[] fitness)
        {
            for (int i = 0; i < getPopulationSize(); i++)
            {
                fitnesDegerleri[i] = fitness[i];
            }
        }

        //  public double[] getFitness() { return fitness; }

        public TournametSelection(int populationSize) : base(populationSize) { }

        public override int[] choose()
        {

            int[] selectedIndividual = new int[2];
            //int[] numbers = new int[2];
            Random rnd = new Random();

            for (int i = 0; i < 2; i++)
            {

                int a = rnd.Next(0, getPopulationSize());
                int b = rnd.Next(0, getPopulationSize());

                while (a == b)
                {
                    b = rnd.Next(0, getPopulationSize());
                }
                while (a == selectedIndividual[0])
                {
                    a = rnd.Next(0, getPopulationSize());
                }
                while (b == selectedIndividual[0])
                {
                    b = rnd.Next(0, getPopulationSize());
                }


                if (fitnesDegerleri[a] > fitnesDegerleri[b])
                {
                    selectedIndividual[i] = a;
                }

                else if (fitnesDegerleri[a] < fitnesDegerleri[b])
                {
                    selectedIndividual[i] = b;
                }
            }

            return selectedIndividual;

        }
    }

    class BestSelection : Selection
    {
        public BestSelection(int populationSize) : base(populationSize)
        {
        }

        public override int[] choose()
        {
            throw new NotImplementedException();
        }
    }
}
