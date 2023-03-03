/* Задача 1. Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.

Console.Write("Введите число: ");
string number = Console.ReadLine();

void MyNumber(string number)
{
if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("Введенное число является полиндромом");
  }
  else Console.WriteLine("Введенное число не является не палиндромом");
}
if (number!.Length == 5)
{
  MyNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/

/* Задача 2. Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

double FindLengh(double x1, double y1, double z1, double x2, double y2, double z2) 

{ 
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); 
    return Math.Round(res, 2); 
} 
Console.Write("Введите координату Х1 точки А: "); 
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координаты У1 точки А: "); 
double y1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координаты Z1 точки А: "); 
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Х2 точки В: "); 
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите координаты У2 точки В: "); 
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты Z2 точки В: "); 
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = FindLengh(x1, y1, z1, x2, y2, z2); 
System.Console.Write($"Расстояние между точками А и В = {distance}"); 
*/

/* Задача 3. Напишите программу, которая принимает 
на вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
  Console.Write($"[{Math.Pow(i, 3)}]");
}
*/
