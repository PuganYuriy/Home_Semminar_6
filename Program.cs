// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите сколько целых чисел будут посчитаны: ");
int x  = Convert.ToInt32(Console.ReadLine()); 
int [] arrai = new int[x];
for (int i = 0; i < arrai.Length; i++)
{
    Console.Write("Введите целое число: ");
    arrai[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (var i in arrai)
{
    Console.Write(i + ", ");
}
Console.Write("-> ");
int positiveNumber = 0;

for (int i = 0; i < arrai.Length; i++)
{
    if (arrai[i] > 0)
    {
        positiveNumber = positiveNumber + 1;
    }
    else {};
}
Console.Write(positiveNumber);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// x = (b2 -b1)/(k1 - k2), y = k2 * x + b2