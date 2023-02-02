// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    double a = new Random().Next(1, 10);
    double b = new Random().Next(1, 10);
    
    System.Console.WriteLine(a + "," + b);

   System.Console.WriteLine(degreeAB(a, b));

    
   static double degreeAB(double a, double b)
        {
          double degree = 0;
          degree = Math.Pow(a, b);

          return degree;
        }
