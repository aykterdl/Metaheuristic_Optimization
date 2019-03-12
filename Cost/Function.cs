using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MathWorks.MATLAB.NET.Arrays;
//using Obj_Func;

namespace Cost
{
    public abstract class Function
    {
        double[] lowerBand, upperBand;
        double globalMin;
        int numberVariables;

        public Function(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables)
        {
            this.lowerBand = lowerBand;
            this.upperBand = upperBand;
            this.globalMin = globalMin;
            this.numberVariables = numberVariables;
        }

        public int getNumberVariables() { return numberVariables; }
        public double getGlobalMin() { return globalMin; }
        public double[] getLowerBand() { return lowerBand; }
        public double[] getUpperBand() { return upperBand; }

        public abstract double calculate(double[] x);
    }

    /*public class CreateFunction : Function
    {
        public CreateFunction(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, globalMin, numberVariables)
        {
        }
        MWArray[] dizi;
        public override double calculate(double[] x)
        {
            ObjectiveFunc objfunc = new ObjectiveFunc();

            // dizi =  objfunc.Obj_Func(x);

            return Convert.ToDouble(dizi);

        }

    }*/

    public class Denklem : Function
    {
        public Denklem(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }

        public override double calculate(double[] x)
        {
            double y1, y2, y3, y4;
            y1 = x[0];
            y2 = x[1];
            y3 = x[2];
            y4 = x[3];
            if (x.Length != 4)
            {
                return -1;
            }
            else
                return Math.Abs(y1 - (y2 * 2) + y3 - y4);
        }
    }

    public class Griewank : Function
    {
        public Griewank(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            double y1 = 0, y2 = 1;
            for (int i = 0; i < getNumberVariables(); i++)
            {
                y1 = y1 + Math.Pow(x[i], 2);
                y2 = y2 * Math.Cos(x[i] / Math.Sqrt(i + 1));
            }
            return y1 / 4000 - y2 + 1;
        }
    }

    public class Booth : Function
    {
        public Booth(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            if (x.Length > 2)
            {
                return -1;
            }
            else
                return Math.Pow(x[0] + 2 * x[1] - 7, 2) + Math.Pow(2 * x[0] + x[1] - 5, 2);
        }
    }

    public class Matyas : Function
    {
        public Matyas(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            if (x.Length > 2)
            {
                return -1;
            }
            else
                return 0.26 * (Math.Pow(x[0], 2) + Math.Pow(x[1], 2)) - 0.48 * x[0] * x[1];
        }
    }

    public class Sphere : Function
    {
        public Sphere(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            double y = 0;
            for (int i = 0; i < getNumberVariables(); i++)
            {
                y += Math.Pow(x[i], 2);
            }
            return y;
        }
    }

    public class Beale : Function
    {
        public Beale(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            if (x.Length != 2)
            {
                return -1;
            }
            else
                return Math.Pow((1.5 - x[0] + x[0] * x[1]), 2) + Math.Pow((2.25 - x[0] + x[0] * Math.Pow(x[1], 2)), 2) + Math.Pow((2.625 - x[0] + x[0] * Math.Pow(x[1], 3)), 2);
        }
    }

    public class Easom : Function
    {
        public Easom(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            const double pi = 3.14;
            if (x.Length != 2)
            {
                return -1;
            }
            else
                return -1 * Math.Cos(x[0]) * Math.Cos(x[1]) * Math.Exp(-1 * Math.Pow((x[0] - pi), 2) - Math.Pow((x[1] - pi), 2));
        }
    }

    public class Schwefel : Function
    {
        public Schwefel(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            double y = 0;
            if (x.Length != 1)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < getNumberVariables(); i++)
                {
                    y += x[0] * Math.Sin(Math.Sqrt(Math.Abs(x[0])));
                }
                return 418.9829 * getNumberVariables() - y;
            }
        }
    }

    public class Schaffer : Function
    {
        public Schaffer(double[] lowerBand, double[] upperBand, double globalMin, int numberVariables) : base(lowerBand, upperBand, 0, numberVariables) { }
        public override double calculate(double[] x)
        {
            if (x.Length != 2)
            {
                return -1;
            }
            else
                return 0.5 + (Math.Cos(Math.Sin(Math.Abs(Math.Pow(x[0], 2) - Math.Pow(x[1], 2)))) - 0.5) / (Math.Pow(1 + 0.001 * (Math.Pow(x[0], 2) + Math.Pow(x[1], 2)), 2));
        }
    }


}
