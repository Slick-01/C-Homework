// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Put 2 number");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine("max" + " = " + a);
    else 
        Console.WriteLine("max" + " = " + b);
