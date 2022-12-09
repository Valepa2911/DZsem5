// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] mass = new int[20];
Random random = new Random();
res = 0;

for (int i = 0; i < mass.Length; i++)
{
    if (i % 2 == 0)
            res = res + mass[i];
       
Console.Write("Четные" + count);
}
void Zapolnenie(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
{
    mass[i] = random.Next(100, 1000);
}
  
     Console.Write(" " + mass);
}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i]+", ");
    }
}