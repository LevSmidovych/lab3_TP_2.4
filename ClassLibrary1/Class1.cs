using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class workWithArray
    {
        /// <summary>
        /// Размер массива.
        /// </summary>
        public int arraySize;
        /// <summary>
        /// Нижняя граница.
        /// </summary>
        private int lowerRange;
        /// <summary>
        /// Верхняя граница.
        /// </summary>
        private int upperRange;
        /// <summary>
        /// Число С.
        /// </summary>
        private int C;
        /// <summary>
        /// Условно недостижимое число.
        /// </summary>
        readonly int INF = 999999999;
        /// <summary>
        /// Массив.
        /// </summary>
        public int[] array = new int[1000];
        /// <summary>
        /// Сверяет текст с паттерном.
        /// </summary>
        public bool checkNum(string textToCheck)
        {
            if(textToCheck == "")
            {
                return false;
            }
            string pattern = @"^\d{0,5}$";
            Match m = Regex.Match(textToCheck, pattern);
            if (m.Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Проверяет С.
        /// </summary>
        public bool cCheck(string c)
        {
            if (!checkNum(c))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Проверяет все введеные данные.
        /// </summary>
        public int checkAll(string range, string lower, string upper)
        {
            if (!checkNum(range))
            {
                return 0;
            }
            else if ((1000 < (double.Parse(range))) || 0 > (double.Parse(range)))
            {
                return 1;
            }
            else if (!checkNum(lower))
            {
                return 2;
            }
            else if ((0 > (double.Parse(lower))) || 10000 < (double.Parse(lower)))
            {
                return 3;
            }
            else if (!checkNum(upper))
            {
                return 4;
            }
            else if ((0 > (double.Parse(upper))) || 10000 < (double.Parse(upper)))
            {
                return 5;
            }
            else if ((double.Parse(upper)) < (double.Parse(lower)))
            {
                return 6;
            }
            else
            {
                return 7;
            }
        }
        /// <summary>
        /// Генерирует массив.
        /// </summary>
        public int[] getArr(string NInString, string lowerRangeInString, string upperRangeInString)
        {

            if (checkAll(NInString, lowerRangeInString, upperRangeInString) == 7) 
            {
                arraySize = int.Parse(NInString);
                lowerRange = int.Parse(lowerRangeInString);
                upperRange = int.Parse(upperRangeInString);
                Random random = new Random();
                for (int i = 0; i < arraySize; i++)
                {
                    array[i] = random.Next(lowerRange, upperRange);
                }
                return array;
            }
            else
            {
                int[] arrayForError = new int[2] {INF, checkAll(NInString, lowerRangeInString, upperRangeInString) };
                return arrayForError;
            }
        }
        /// <summary>
        /// Выполняет первую операцию.
        /// </summary>
        public string firstOp( string CInString)
        {
            if (cCheck(CInString))
            {
                C = int.Parse(CInString);
                int sumH = 0;
                int sumL = 0;
                for (int i = 1; i < arraySize; i = i + 2)
                {
                    if (array[i] > C)
                    {
                        sumH = sumH + array[i];
                    }
                    else if (array[i] < C)
                    {
                        sumL = sumL + array[i];
                    }
                }
                return $"Сумма чисел больших {C} равна {sumH}\nСумма чисел меньших {C} равна {sumL}\n";
            }
            else
            {
                return "C не соответсвует формату";
            }

        }
        /// <summary>
        /// Выполняет вторую операцию.
        /// </summary>
        public int[] secondOp()
        {
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }
                }
            }
            return array;
        }
        /// <summary>
        /// Выполняет третью операцию.
        /// </summary>
        public string thirdOp(string CS)
        {
            int sum = 0;
            int num = 0;
            int numForCheck;
            for (int i = 0; i < arraySize; i++)
            {
                if (array[i] <= 9)
                {
                    if (array[i] % 2 == 1)
                    {
                        sum = sum + array[i];
                        num++;
                    }
                }
                else
                {
                    string numS = Convert.ToString(array[i]);
                    numForCheck = int.Parse(numS.Substring(0, 2));
                    if (numForCheck % 2 == 1)
                    {
                        sum = sum + array[i];
                        num++;
                    }
                }
            }
            return $"Количество чисел у которых число составленное из двух первых цифер которых нечетна {num} Сумма этих чисел {sum}";
        }
        /// <summary>
        /// Выполняет четвертую операцию.
        /// </summary>
        public string foursOp()
        {
            bool check;
            int count = 0;
            for (int i = 0; i < arraySize; i++)
            {
                check = true;
                for (int j = 2; j < Math.Sqrt(array[i]); j++)
                {
                    if (array[i] % j == 0)
                    {
                        check = false;
                    }

                }
                if (check)
                {
                    count++;
                }
            }
            return $"Количество простых чисел {count}";
        }

    }
}
