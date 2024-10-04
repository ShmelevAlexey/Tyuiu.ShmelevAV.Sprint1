using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShmelevAV.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            int res = (int)((x - (int)x) * 10);
            return res;
        }
    }
}
