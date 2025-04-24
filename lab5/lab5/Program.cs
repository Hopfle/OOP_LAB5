using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Варiант 3: Присвоєння змiнним символьного типу C2, C1, C0 цифр трьохзначного числа");
        Console.Write("Введiть трьохзначне число k: ");

        string input = Console.ReadLine();
        int k;

        // Перевірка правильності введеного числа
        if (!int.TryParse(input, out k) || k < 100 || k > 999)
        {
            Console.WriteLine("Помилка! Введене число не є трьохзначним.");
            return;
        }

        // Отримання окремих цифр з трьохзначного числа
        // Для перетворення цифри в символ додаємо до неї '0'
        char C2 = (char)('0' + k / 100);        // Ліва цифра
        char C1 = (char)('0' + (k / 10) % 10);  // Середня цифра
        char C0 = (char)('0' + k % 10);         // Права цифра

        // Виведення результатів
        Console.WriteLine($"Для числа {k}:");
        Console.WriteLine($"C2 (лiва цифра) = '{C2}'");
        Console.WriteLine($"C1 (середня цифра) = '{C1}'");
        Console.WriteLine($"C0 (права цифра) = '{C0}'");

        // Додаткова демонстрація - відтворення числа з окремих цифр
        Console.WriteLine($"Перевiрка: {C2}{C1}{C0} == {k}");
    }
}