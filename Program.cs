// Урок 6. Двумерные массивы и рекурсия
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите сколько целых чисел будут посчитаны: ");
// int x  = Convert.ToInt32(Console.ReadLine()); 
// int [] arrai = new int[x];
// for (int i = 0; i < arrai.Length; i++) // создаёт цикл "for" для заполнения массива с клавиатуры
// {
//     Console.Write("Введите целое число: ");
//     arrai[i] = Convert.ToInt32(Console.ReadLine());
// }
// foreach (var i in arrai) // создаёт цикл "foreach" для вывода массива в консоль
// {
//     Console.Write(i + ", ");
// }
// Console.Write("-> ");
// int positiveNumber = 0; // создаёт переменную для подсчета положительных элементов

// for (int i = 0; i < arrai.Length; i++) // создаёт цикл "for" для прохода по индексам массива
// {
//     if (arrai[i] > 0) // сравнивает элемент массива
//     {
//         positiveNumber = positiveNumber + 1;
//     }
//     else {};
// }
// Console.Write(positiveNumber);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// x = (b2 -b1)/(k1 - k2), y = k2 * x + b2

Console.WriteLine("Введите точку x1: ");
double x1  = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите точку y1: ");
double y1  = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите точку x2: ");
double x2  = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Введите точку y2: ");
double y2  = Convert.ToDouble(Console.ReadLine()); 

Console.Write ("Первый отрезок: x1= " + x1 + ", y1= "  + y1 + ", Второй отрезок: x2= " + x2 + ", y2= " + y2 + " -> ");
if (x1 == x2) 
    { 
        if (y1 == y2)
        {
            Console.Write ("прямые совпадаут");
        }
        else
        {
            Console.Write ("прямые паралельны");
        }
    }    
else 
    {
        double x = (x1 - x2) / (y2 - y1);
        double y = y1 * x + x1;
        Console.Write ("точка перечечения является: (" + x + " " + y + ")");
    }