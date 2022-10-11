int N=10;

int[] array = new int [N];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10); // генерация трехзначных чисел
    Console.WriteLine(array[i]);
}

int min = 999999, max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным значениями массива = {max - min}");