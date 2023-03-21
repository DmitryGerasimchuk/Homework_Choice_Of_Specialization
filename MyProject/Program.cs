namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int userArrayLength = MethodsUserInput.UserInputNumber("Введите количество элементов массива");
                string[] userArray = MethodsArray.CreateArrayUser(userArrayLength);
                int maxCharElement = MethodsUserInput.UserInputNumber("Введите максимально количество символов которое будем искать в элементах массива");
                string[] newArray = MethodsArray.CreateArrayUserSearchedElements(MethodsArray.SearchElementUpThree(userArray, maxCharElement));
                MethodsArray.FillArrayUserSearchedElement(newArray, userArray, maxCharElement);
                Console.WriteLine("\n\nИзначально заданный массив");
                MethodsArray.PrintArray(userArray);
                Console.WriteLine("\n\nМассив с искомыми элементами ");
                MethodsArray.PrintArray(newArray);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели неправильное значение, перезапустите программу =(");
                Console.ReadLine();
            }
        }
    }
}