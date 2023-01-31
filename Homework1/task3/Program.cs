// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.WriteLine("Put 3 numbers");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int max = a;

        if (b > a && b > c) max = b;
            else if (c > a && c > b)
        {
            max = c;
        }
        Console.WriteLine("max" + " = " + max);
            