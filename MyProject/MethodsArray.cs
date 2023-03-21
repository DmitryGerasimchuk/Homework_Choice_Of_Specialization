using System;

namespace MyProject
{
    static class MethodsArray
    {
        /// <summary>Метод вывода массива в консоль/// </summary>
        /// <param name="array">аргументом передается массив</param>
        public static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"|{item}|\t");
            }
            Console.WriteLine();
        }

        /// <summary>Метод Создания массива пользователем, с его строковыми значениями /// </summary>
        /// <param name="size">количество элементов массива</param>
        /// <returns>Возвращает массив строк, заполненный пользователем</returns>
        public static string[] CreateArrayUser(int size)
        {
            string[] array = new string[size];
            for (int i = 0, j = 1; i < array.Length; i++, j++)
            {
                Console.Clear();
                array[i] = MethodsUserInput.UserInputString($"Введите {j} строку, число или слово ");
                if (array[i] == string.Empty) array[i] = "Empty";
                Console.Clear();
            }
            return array;
        }

        /// <summary>
        /// Метод поиска элементов определенной размерности в массиве строк
        /// </summary>
        /// <param name="array">массив строк</param>
        /// <param name="max">максимальное количество символов</param>
        /// <returns>возвращает количество подходящих элементов</returns>
        public static int SearchElementUpThree(string[] array, int max)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= max) count++;
            }
            return count;
        }

        /// <summary>
        /// Метод создания массива размерности искомых элементов
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <returns>возвращает новый массив</returns>
        public static string[] CreateArrayUserSearchedElements(int size)
        {
            string[] array = new string[size];
            return array;
        }

        /// <summary>
        /// Метод заполнения массива подходящими элементами
        /// </summary>
        /// <param name="newArray">новый заполненый массив</param>
        /// <param name="baseArray">массив из которого берем значения</param>
        /// <param name="max">максимальное количество символов</param>
        /// <returns>возвращает новый заполненый массив</returns>
        public static string[] FillArrayUserSearchedElement(string[] newArray,string[] baseArray, int max )
        {
            for (int i = 0, j = 0; i < baseArray.Length; i++)
            {
                if (baseArray[i].Length <= max)
                {
                    newArray[j] = baseArray[i];
                    j++;
                }
            }
            return newArray;
        }
    }
}
