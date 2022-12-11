// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 69.4 -22 0.4 78] ->56

Console.WriteLine("Введите длину массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[n];
for (int i = 0; i < mass.Length; i++)
{
    Console.Write($"Введите элемент массива, можно с запятой {i}: ");
    mass[i] = Convert.ToDouble (Console.ReadLine());
}
double max = 0;
double min = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
        {
            max = mass[i];
        }
    if (mass[i] < min)
        {
            min = mass[i];
        }
}
Console.WriteLine($"Максимальное = {max}, минимальное = {min}");

double Raznica (double[] mass)
{
    double raz = 0;
    for (int i = 0; i < mass.Length; i++)
    {
    raz = max - min;
    }    
        return raz;
}
Console.WriteLine($"Разница: {Raznica(mass)}");
