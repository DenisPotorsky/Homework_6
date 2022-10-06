using static System.Console;
Clear();

// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

WriteLine("Введите числа:");
string[] nums = ReadLine()!.Split(new char[] { ' ', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
int[] intArray = Array.ConvertAll(nums, int.Parse);
WriteLine();

int result = CountNumbers(intArray);
WriteLine($"Количество чисел больше ноля:\n{result}");

int CountNumbers(int[] intArray)
{
    int counter = 0;
    for (int i = 0; i < intArray.Length; i++)
    {
        if (intArray[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}

