// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Put number");

int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7) 
    System.Console.WriteLine("This day is weekend");

else if (a >= 1 && a <=5){
  System.Console.WriteLine("This day is workday");  
}

else {
   System.Console.WriteLine("This number is not a day in the week"); 
}
