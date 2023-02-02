// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int number = new Random().Next(1, 100000);

System.Console.WriteLine(number);

System.Console.WriteLine(SumNumber(number));
static int SumNumber(int number)
{
    int sum = 0;

while (number > 0){
    sum = sum + number % 10;
    number = number / 10;
}
    return sum;
}
