namespace MyProject
{
    internal static class MethodsUserInput
    {
        /// <summary>
        /// Получение числа от пользователя
        /// </summary>
        /// <param name="message">сообщение для пользователя</param>
        /// <returns>возвращает число</returns>
    public static int UserInputNumber(string message)
        {
            Console.Write($"{message} -->");
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Получения строки от пользователя
        /// </summary>
        /// <param name="message">сообщение для пользователя</param>
        /// <returns>возврощает строку</returns>
        public static string UserInputString(string message)
        {
            Console.Write($"{message} -->");
            return Console.ReadLine();
        }
    }
}
