// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Put number");

int a = Convert.ToInt32(Console.ReadLine());
string ThirdNumber = Convert.ToString(a);

if (ThirdNumber.Length > 2)

System.Console.WriteLine("Third number is" + " " + ThirdNumber[2]);

else {
  System.Console.WriteLine("Third number is not");  
}
