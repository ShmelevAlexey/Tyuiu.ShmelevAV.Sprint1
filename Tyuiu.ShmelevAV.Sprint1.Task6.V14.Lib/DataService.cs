using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShmelevAV.Sprint1.Task6.V14.Lib
{
    public class DataService : ISprint1Task6V14
    {
        public bool CheckLowerCaseRusLetters(string value)
        {
            string pattern = @"^[А-Яа-яЁё]+$";
            bool res;
            if (Regex.IsMatch(value, pattern))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
