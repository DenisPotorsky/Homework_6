using static System.Console;
Clear();

// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

WriteLine("Введите значения:");
string[] nums = ReadLine()!.Split(new char[] { ' ', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
WriteLine();

GetPoint(double.Parse(nums[0]), double.Parse(nums[1]), double.Parse(nums[2]), double.Parse(nums[3]));

void GetPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    if (k1 == k2) System.Console.WriteLine("Параллельные прямые");
    else System.Console.WriteLine($"Точка пересечения: ({x:f1}, {y:f1})");
}
