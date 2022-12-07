//Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

Console.Write("Введите любое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое целое число: ");
int num8 = Convert.ToInt32(Console.ReadLine());

int[] array = { num1, num2, num3, num4, num5, num6, num7, num8 };

    for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+" ");
        }