// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



// int [] CreateArray(int size, int minValue, int maxValue)
// {
//     int [] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return array;
// }

// void Showarray(int [] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();   
// }


// int SummArray(int [] array)
// {
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//             summ ++;
//     }
//     return summ;
// }


// Console.Write("Введите длину строки: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateArray(size, min, max);
// Showarray(array);
// Console.WriteLine($"Кол-во элементов > 0: {SummArray(array)}");

////////////////////////////////////////////////////////////////////////

// Экспериментальный вариант:
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(i => i > 0);

// Console.WriteLine($"Кол-во элементов > 0: {count}");

///////////////////////////////////////////////////////////////////////

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами : ({x};  {y})");