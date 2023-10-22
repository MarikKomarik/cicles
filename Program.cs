using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.Write("Введите сумму вклада: ");
        decimal sum = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            sum += sum * 0.07M;
        }

        Console.WriteLine("Конечная сумма вклада: " + sum);

        Console.ReadKey();
    
        // Вывод таблицы умножения
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("{0,3}", i);
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0,4}", i * j);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
        Console.WriteLine("Температура(C)  |  Температура(F)");
        for (int tc = -50; tc <= 50; tc++)
        {
            double tf = (9.0 / 5.0) * tc + 32;
            Console.WriteLine($"{tc,10}       |  {tf,14}");
        }
        Console.ReadKey();*/
        double deposit = 1000;
        double interestRate = 0.02;
        double monthlyIncrease = 0;
        int months = 0;
        while (monthlyIncrease <= 30)
        {
            monthlyIncrease = deposit * interestRate;
            deposit += monthlyIncrease;
            months++;
        }
        Console.WriteLine("а) Ежемесячное увеличение вклада превысит 30 руб. через " + months + " месяцев");
        months = 0;
        while (deposit <= 1200)
        {
            monthlyIncrease = deposit * interestRate;
            deposit += monthlyIncrease;
            months++;
        }
        Console.WriteLine("б) Размер вклада превысит 120000000000000 руб. через " + months + " месяцев");

        Console.ReadLine();

    }
}