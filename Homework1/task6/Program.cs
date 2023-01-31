//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Put number");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine(a + " " + "even number"); 
else {
    Console.WriteLine(a + " " + "odd number");
}
