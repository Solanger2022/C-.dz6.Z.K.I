/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */ 

Console.Write($"Введите первую координату b1: "); 
 
int firstСoordinate = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"Введите вторую координату b2: "); 

int secondСoordinate = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"Введите первую координату k1: "); 

int thirdСoordinate = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"Введите первую координату k2: "); 

int fourthСoordinate = Convert.ToInt32(Console.ReadLine()); 
 
int intersectionPointX = (firstСoordinate-secondСoordinate)/(fourthСoordinate-thirdСoordinate); 

int intersectionPointY = (fourthСoordinate*firstСoordinate-thirdСoordinate*secondСoordinate)/(fourthСoordinate-thirdСoordinate) ;

Console.WriteLine($"координаты точки пересечения : ({intersectionPointX},{intersectionPointY})");






