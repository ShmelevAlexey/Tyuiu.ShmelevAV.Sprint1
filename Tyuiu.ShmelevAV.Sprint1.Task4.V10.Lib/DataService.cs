using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShmelevAV.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            return Math.Round((1 + Math.Cos(a)) / (Math.Pow(Math.Sin(a), 2)), 3);
        }
    }
}
