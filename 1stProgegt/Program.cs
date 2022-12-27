// // // Принимает значене на ввод (5 значное число) и проверяет, является ли оно полиндромом
// Console.Clear();
// int number = int.Parse(Console.ReadLine());
// int temp = number;
// int rev = 0;
//     while(number > 0)
//     {
//         rev = ((rev*10) + (number%10));
//         number = numer/10;
//         Console.Write($"rev = {rev}");
//         Console.Write($"number = {number}");
//     }
//     if (temp == rev)
//     {
//         Console.Write($"Да? число {temp} палиндром");
//     }
//     else
//     {
//         Console.Write($"Нет, число {temp} не палиндром");
//     }

// // //Задача 21 Напишите программу, которая принимает на вход координаты 3х точек и находит расстояние между ними в 3D пространсве

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

// Console.WriteLine($"d={d:f2}");


// Принимает входящее число N и выдает таблицу кубов числе от 1 до N

Console.Clear();
Console.WriteLine("Таблица кубов числе от 1 до N");
Console.WriteLine();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.Write($"Таблица кубов чисел от до {N}: ");

for(int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}
