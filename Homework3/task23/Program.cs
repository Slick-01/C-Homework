//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int rnd = new Random().Next(-11, 11);
System.Console.WriteLine(rnd);

for (int i = 1; i <= rnd; i ++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}
