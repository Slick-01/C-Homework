// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Put number");

int a = Convert.ToInt32(Console.ReadLine());
string TwoNumber = Convert.ToString(a);

System.Console.WriteLine("Second number is" + " " + TwoNumber[1]);


