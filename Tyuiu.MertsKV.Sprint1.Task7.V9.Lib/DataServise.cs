using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MertsKV.Sprint1.Task7.V9.Lib
{
    public class DataServise : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double a = Math.Pow(y, 2) + Math.Cos(Math.Pow(x, 3)) + 12 * x * y - 3 * Math.Pow(x, 2);
            double b = Math.Cos(Math.Pow(x, 3) + 3) + 18 * y - 1;
            double result = Math.Exp(x) - (a / b);

            return Math.Round(result, 3);

        }
    }
}
