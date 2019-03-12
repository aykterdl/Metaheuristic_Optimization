using Cost;
using MetaheuristicOptimizationTool.GeneticAlgorithm;
using ProblemDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaheuristicOptimizationTool.SOS
{
    class Sos
    {
        double[][] randEko;
        double[] fitness;
        double[] low;
        double[] high;
        int[] index;
        double deger;


        int nd, maxIteration = 100000;

        Population population;
        Function denklem;
        public Sos()
        {
            this.low = Problem.low;
            this.high = Problem.high;
            nd = low.Length;
        }

        public double[] getFitness() { return fitness; }
        public double[][] getRandPop() { return randEko; }
        public double getDeger() { return deger; }


        public double sosStart(string benchmark)
        {
            population = new RandomPopulation(low, high, nd, 1000);
            randEko = population.create();
            fitness = new double[population.getPopulationSize()];
            Random rastgele = new Random();

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

            for (int i = 0; i < population.getPopulationSize(); i++)
                fitness[i] = denklem.calculate(randEko[i]);


            int fe = 0;
            double globalMin = 0;
            //listBox1.Items.Clear();

            double[] enIyiOrganizma = new double[population.getNumberVariables()];
            double[] mutualVektor = new double[population.getNumberVariables()];
            double[] yeniBirey1 = new double[population.getNumberVariables()];
            double[] yeniBirey2 = new double[population.getNumberVariables()];
            double[] parazitVektor = new double[population.getNumberVariables()];
            int BF1, BF2, j;
            double uygunluk1, uygunluk2;
            MinBul min = new TekMinBul(fitness);
            if (denklem.calculate(randEko[0]) == -1)
            {
                deger = -1;
                return deger;
            }
            else
            {
                while (fe < maxIteration)
                {
                    for (int i = 0; i < population.getPopulationSize(); i++)
                    {
                        for (int k = 0; k < population.getNumberVariables(); k++)
                            enIyiOrganizma[k] = randEko[min.minBul()][0];

                        // Mutualism Phase
                        j = i;
                        while (i == j)
                        {
                            j = rastgele.Next(0, (population.getPopulationSize() - 1));
                        }
                        for (int k = 0; k < population.getNumberVariables(); k++)
                            mutualVektor[k] = (randEko[i][k] + randEko[j][k]) / 2;
                        BF1 = rastgele.Next(1, 3);
                        BF2 = rastgele.Next(1, 3);
                        for (int k = 0; k < population.getNumberVariables(); k++)
                        {
                            yeniBirey1[k] = randEko[i][k] + rastgele.NextDouble() * (enIyiOrganizma[k] - (mutualVektor[k] * BF1));
                            yeniBirey2[k] = randEko[j][k] + rastgele.NextDouble() * (enIyiOrganizma[k] - (mutualVektor[k] * BF2));
                        }
                        //kontrol(yeniBirey1); //ceza
                        // kontrol(yeniBirey2); //ceza
                        uygunluk1 = denklem.calculate(yeniBirey1);
                        uygunluk2 = denklem.calculate(yeniBirey2);
                        if (uygunluk1 < fitness[i])
                        {
                            fitness[i] = uygunluk1;
                            for (int k = 0; k < population.getNumberVariables(); k++)
                                randEko[i][k] = yeniBirey1[k];
                        }
                        if (uygunluk2 < fitness[j])
                        {
                            fitness[j] = uygunluk2;
                            for (int k = 0; k < population.getNumberVariables(); k++)
                                randEko[j][k] = yeniBirey2[k];
                        }
                        fe = fe + 2;

                        // Commensialism Phase
                        j = i;
                        while (i == j)
                        {
                            j = rastgele.Next(0, (population.getPopulationSize() - 1));
                        }
                        for (int k = 0; k < population.getNumberVariables(); k++)
                            yeniBirey1[k] = randEko[i][k] + (rastgele.NextDouble() * 2 - 1) * (enIyiOrganizma[k] - randEko[j][k]);
                        // kontrol(yeniBirey1);
                        uygunluk1 = denklem.calculate(yeniBirey1);
                        if (uygunluk1 < fitness[i])
                        {
                            fitness[i] = uygunluk1;
                            for (int k = 0; k < population.getNumberVariables(); k++)
                                randEko[i][k] = yeniBirey1[k];
                        }
                        fe = fe + 1;

                        // Parasitism Phase
                        j = i;
                        while (i == j)
                        {
                            j = rastgele.Next(0, (population.getPopulationSize() - 1));
                        }
                        for (int k = 0; k < population.getNumberVariables(); k++)
                            parazitVektor[k] = randEko[i][k];
                        int secim = rastgele.Next(1, population.getNumberVariables());
                        //for (int k = 0; k < secim; k++)
                        //    parazitVektor[k] = rastgele.NextDouble() * (high - low) + low;
                        uygunluk1 = denklem.calculate(parazitVektor);
                        if (uygunluk1 < fitness[j])
                        {
                            fitness[j] = uygunluk1;
                            for (int k = 0; k < population.getNumberVariables(); k++)
                                randEko[j][k] = parazitVektor[k];
                        }
                        fe = fe + 1;

                    }
                }
            }
            globalMin = fitness.Min();


            return globalMin;
        }
    }
}
