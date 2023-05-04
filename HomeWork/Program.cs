/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
void CheckPali(int number)
{ int digit1 = number/10000;
  int digit5 = number %10;
  if (digit1 == digit5)
  {
     int digit2 = number/1000 %10;
     int digit4 = number/10 %10;
  
  
     if (digit2 == digit4)
        Console.WriteLine("This number is palindrome");
  }
 else
        Console.WriteLine("This number is not a palindrome");
        
}

    Console.WriteLine("Input 5 digits number: ");
    int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100000 || num < 10000)
    Console.WriteLine("its not 5 digit number!");
else
    CheckPali(num);
    
*/
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)+(z1-z2)*(z1-z2));
    
    return lengthAB;
}

Console.WriteLine("Input X coordinat of A : ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of A : ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of A : ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinat of B : ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B : ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of B : ");
int zCoordB = Convert.ToInt32(Console.ReadLine());


double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Distnce AB is {dist:f3}");

*/
/*

Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


void CubFinder1 (int numberN)
{   
    int current_i = 1;
    while(current_i<=numberN)
    { 
      double res = Math.Pow(current_i,3);
      Console.Write($"{res:f0}, ");
      current_i ++;
    }
        Console.WriteLine("\b\b.");
}

void CubFinder2(int numberN)
{
    int current_i = 1;
    while (current_i >= numberN)
    {
        double res = Math.Pow(current_i,3);
        Console.Write($"{res:f0}, ");
        current_i --;
    }
    Console.WriteLine("\b\b.");    
}
Console.WriteLine("Input number: ");
int user_numberN = Convert.ToInt32(Console.ReadLine());

if (user_numberN > 0)
    CubFinder1(user_numberN);
else 
   CubFinder2(user_numberN); 

