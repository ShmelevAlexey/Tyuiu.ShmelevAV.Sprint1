using Tyuiu.ShmelevAV.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShmelevAV.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "здравствуй мир";
            DataService ds = new DataService();
            var res = ds.CheckLowerCaseRusLetters(value);
            var wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}