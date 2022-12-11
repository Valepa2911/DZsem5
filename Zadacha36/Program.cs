// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
for (int i = 0; i < mass.Length; i++)
{
    Console.Write($"Введите элемент массива {i}: ");
    mass[i] = Convert.ToInt32 (Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < mass.Length; i++)
{
if (i % 2 != 0)
sum += mass[i];
}
Console.WriteLine("Сумма нечетных=" + " " + sum);
