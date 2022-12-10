// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
zapolnenie(mass);
Console.WriteLine("Массив: ");
PrintArray(mass);

void zapolnenie(int[] mass)
{
    for(int i = 0; i < n; i++)
    {
        mass[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int i = 0; i < mass.Length; i++)
{
if (mass[i] % 2 == 0)
count++;
}
Console.WriteLine("четных" + " " + count);


void PrintArray(int[] mass)
{
    for(int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
        Console.WriteLine();
}
