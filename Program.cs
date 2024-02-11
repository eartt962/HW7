// // Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // Использовать рекурсию, не использовать циклы.

// // N = 5 => 1 2 3 4 5
// Console.Write("Введите первое число: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // start = M, end = N
// void ShowNumbers(int start, int end)
// {
//     if (start == end) // базовый случай
//     {
//         Console.Write(start); 
//         return;  
//     }
//     Console.Write(start + " "); // 1
//     ShowNumbers(start + 1, end);
// }
// ShowNumbers(M, N);

// // Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Ack(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ack(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return Ack(m - 1, Ack(m, n - 1));
//     }
//     return - 1;
// }
// int result = Ack(m, n);
// Console.WriteLine(result);



// // Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// int[] array = {3, 8, 15, 6, 77, 0};
// int size = array.Length;
// void ShowArray (int[] arr, int size)
// {
//     if (size == 0)
//     {
//         Console.Write(arr[size]);
//         return;
//     }
//     Console.Write(arr[size] + " ");
//     ShowArray(array, size - 1);
// }
// ShowArray(array, size - 1);
// Console.Write(ShowArray);
