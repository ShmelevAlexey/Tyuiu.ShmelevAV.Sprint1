using Tyuiu.ShmelevAV.Sprint1.Task3.V15.Lib;

namespace Tyuiu.ShmelevAV.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 2;
            double v2 = 3;
            double T = 6;
            double S = 5;
            var res = ds.DistanceOverTime(v1, v2, T, S);
            Assert.AreEqual(31, res);
        }
    }
}