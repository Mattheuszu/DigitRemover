using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        if (ulong.TryParse(Console.ReadLine(), out ulong number))
        {
            Console.Write("Введите цифру для удаления: ");
            if (byte.TryParse(Console.ReadLine(), out byte digit))
            {
                ulong result = RemoveDigit(number, digit);
                Console.WriteLine($"Число после удаления цифры {digit}: {result}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод цифры.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод числа.");
        }
    }

    static ulong RemoveDigit(ulong num, byte digit)
    {
        string numStr = num.ToString();
        string digitStr = digit.ToString();

        numStr = numStr.Replace(digitStr, "");

        if (ulong.TryParse(numStr, out ulong result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Произошла ошибка при удалении цифры.");
            return num;
        }
    }
}
