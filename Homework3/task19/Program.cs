// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int rnd = new Random().Next(10001, 100000);
// Это для проверки конкретного палиндромного числа
//Console.WriteLine("Put number");
//int rnd = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(rnd);

int num = (rnd % 10 )* 10000 + ((rnd / 10) % 10) * 1000 + ((rnd / 100) % 10) * 100 + ((rnd / 1000 ) % 10) * 10 + rnd / 10000;

if (rnd == num)
    System.Console.WriteLine("Number is palindrom" +  " " + num);
else {
    System.Console.WriteLine("Number is not palindrom" +  " " + rnd);
}
