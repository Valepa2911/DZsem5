// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
zapolnenie(mass);
PrintArray(mass);


void zapolnenie(int[] mass)
{
    for(int i = 0; i < n; i++)
    {
        mass[i] = new Random().Next(1,1000);
    }
}
void PrintArray(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
        Console.WriteLine();
}

int sum = 0;
for (int i = 0; i < mass.Length; i++)
{
if (i % 2 != 0)
sum += mass[i];
}
Console.WriteLine("Сумма нечетных=" + " " + sum);
