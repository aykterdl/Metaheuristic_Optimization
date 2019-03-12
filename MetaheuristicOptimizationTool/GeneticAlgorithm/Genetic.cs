using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cost;
using ProblemDefinition;
using MetaheuristicOptimizationTool;
using System.Windows.Forms;

namespace MetaheuristicOptimizationTool.GeneticAlgorithm
{
    class Genetic
    {
        double[][] randPop;
        double[] fitness;
        double[] low;
        double[] high;
        double[] consM;
        double[][] consC;
        int[] index;
        double deger;


        int nd, maxIteration = 100000;
        double mutasyonConstant = 0.001;

        Population population;
        Function denklem;
        Selection trnmtSelect;
        CrossOver scover;
        Mutation mutation;
        public Genetic()
        {
            this.low = Problem.low;
            this.high = Problem.high;
            nd = low.Length;
        }

        public double[] getFitness() { return fitness; }
        public double[][] getRandPop() { return randPop; }
        public double getDeger() { return deger; }

        public double geneticStart(string benchmark)
        {
            population = new RandomPopulation(low, high, nd, 1000);
            // MinBul min;
            randPop = population.create();
            fitness = new double[population.getPopulationSize()];

            // denklem = new Sphere(low, high, 0, nd);
            switch (benchmark)
            {
                case "Griewank":
                    denklem = new Griewank(low, high, 0, nd);
                    break;
                case "Sphere":
                    denklem = new Sphere(low, high, 0, nd);
                    break;
                case "Booth":
                    denklem = new Booth(low, high, 0, nd);
                    break;
                case "Beale":
                    denklem = new Beale(low, high, 0, nd);
                    break;
                case "Denklem":
                    denklem = new Denklem(low, high, 0, nd);
                    break;
                case "Matyas":
                    denklem = new Matyas(low, high, 0, nd);
                    break;
                case "Easom":
                    denklem = new Easom(low, high, 0, nd);
                    break;
                case "Schaffer":
                    denklem = new Schaffer(low, high, 0, nd);
                    break;
                case "Schwefel":
                    denklem = new Schwefel(low, high, 0, nd);
                    break;
                    
                default:
                    denklem = new Sphere(low, high, 0, nd);
                    break;
            }
            if (denklem.calculate(randPop[0]) == -1)
            {
                deger = -1;
                return deger;
            }
            else
            {
                for (int i = 0; i < population.getPopulationSize(); i++)
                    fitness[i] = denklem.calculate(randPop[i]);

                //Selection randomSelect = new RandomSelection(5);
                trnmtSelect = new TournametSelection(population.getPopulationSize());

                scover = new SingleCrossOver();
                //CrossOver dbCross = new DoubleCrossOver();

                mutation = new ChangeMutation(mutasyonConstant);

                int fe = 0;
                double globalMin = 0;
                //listBox1.Items.Clear();

                while (fe < maxIteration)
                {
                    //index = randomSelect.choose();
                    index = trnmtSelect.choose();
                    index[1] = Array.IndexOf(fitness, fitness.Min());
                    consC = scover.make(randPop[index[0]], randPop[index[1]]);
                    // consC = dbCross.make(randPop[index[0]], randPop[index[1]]);

                    double fitness1 = denklem.calculate(consC[0]);
                    fe = fe + 1;
                    if (fitness1 < fitness[index[0]])
                    {
                        randPop[index[0]] = consC[0];
                        fitness[index[0]] = fitness1;
                    }

                    double fitness2 = denklem.calculate(consC[0]);
                    fe = fe + 1;
                    if (fitness2 < fitness[index[1]])
                    {
                        randPop[index[1]] = consC[1];
                        fitness[index[1]] = fitness2;
                    }

                    //index = randomSelect.choose();
                    index = trnmtSelect.choose();
                    consM = mutation.make(randPop[index[0]]);
                    //bound.make(consM);

                    fitness1 = denklem.calculate(consM);
                    fe = fe + 1;
                    if (fitness1 < fitness[index[0]])
                    {
                        randPop[index[0]] = consM;
                        fitness[index[0]] = fitness1;
                    }
                }
                globalMin = fitness.Min();


                return globalMin;
            }
        }
    }
}
