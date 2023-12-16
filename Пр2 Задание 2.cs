
using System;

class NumberManager
{
    private int a = 0;

    public bool SetNumber(int number)
    {
        if (number == a + 1)
        {
            a = number;
            return true;
        }
        else
        {
            a = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return a + 1;
    }
}

class Program
{
    static void Main()
    {
        NumberManager manager = new NumberManager();

        while (true)
        {
            int expectedNumber = manager.GetExpectedNumber();
            Console.Write("Введите число " + expectedNumber + ": ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (manager.SetNumber(userInput))
                {
                    Console.WriteLine("Верно! Следующее число...");
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается число " + expectedNumber + ". Начните сначала.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное число.");
            }
        }
    }
}