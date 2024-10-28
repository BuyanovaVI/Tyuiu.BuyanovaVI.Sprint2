
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BuyanovaVI.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 7. Значение {value}");

            }
        }
    }
}
