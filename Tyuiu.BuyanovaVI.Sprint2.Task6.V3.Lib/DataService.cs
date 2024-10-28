
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BuyanovaVI.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 7. Значение {value}");

            }
        }
    }
}
