// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
zapolnenie(mass);


void zapolnenie(int[] mass)
{
    for(int i = 0; i < n; i++)
    {
        mass[i] = new Random().Next(1,1000);
    }
}
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
if (mass[i] % 2 == 0)
count++;
}
Console.WriteLine("четных" + " " + count);
