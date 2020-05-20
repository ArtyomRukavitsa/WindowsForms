using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика17
{
    class NumeralSystem
    {
        public NumeralSystem() { }

        public static string ConvertToTen(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result += Convert.ToInt32(Convert.ToString(number[number.Length - i - 1])) 
                    * (int)Math.Pow(2, i);
            }
            return Convert.ToString(result);
        }

        static string ReverseNumbers(string number)
        {
            string result = "";  // Итоговый результат
            for (int i = 0; i < number.Length; i++)
            {
                result += number[number.Length - i - 1];
            }
            return result;
        } 
        public static string ConvertToEight(string number)
        {
            int current; // Сумма тройки
            string result = ""; // Перевернутый результат
            if (number.Length % 3 == 2) number = "0" + number; // Дополнение до длины, кратной 3
            else if (number.Length % 3 == 1) number = "00" + number; // Дополнение до длины, кратной 3
            for (int i = 0; i < number.Length; i += 3) // Разделил число на тройки
            {
                current = 0;
                for (int j = 0; j < 3; j++)
                {
                    current += Convert.ToInt32(Convert.ToString(number[number.Length - i - j - 1]))
                    * (int)Math.Pow(2, j);
                }
                result += Convert.ToString(current); // Складываем в обратном порядке
            }
            string result_good = ReverseNumbers(result);
            return result_good;
        }

        
        public static string ConvertToSixteen(string number)
        {
            string[] numbers = { "A", "B", "C", "D", "E", "F" };
            int current; // Сумма четверки
            string result = ""; // Перевернутый результат
            if (number.Length % 4 == 3) number = "0" + number; // Дополнение до длины, кратной 4
            else if (number.Length % 4 == 2) number = "00" + number; // Дополнение до длины, кратной 4
            else if (number.Length % 4 == 1) number = "000" + number; // Дополнение до длины, кратной 4
            for (int i = 0; i < number.Length; i += 4) // Разделил число на четверки
            {
                current = 0;
                for (int j = 0; j < 4; j++)
                {
                    current += Convert.ToInt32(Convert.ToString(number[number.Length - i - j - 1]))
                    * (int)Math.Pow(2, j);
                }
                if (current <= 9) result += Convert.ToString(current); // Складываем в обратном порядке
                else result += numbers[current % 10]; // Сумма четверки больше 10, прибавляем букву
            }
            string result_good = ReverseNumbers(result);  // Итоговый результат]
            return result_good;
        }
    }
}
