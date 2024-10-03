using Tyuiu.ShmelevAV.Sprint1.Task4.V10.Lib;

namespace Tyuiu.ShmelevAV.Sprint1.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 100;
            var res = ds.Calculate(a);
            Assert.AreEqual(7.263, res);
        }
    }
}