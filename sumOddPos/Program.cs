int N=20;
int sum = 0;
int[] array = new int [N];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 99); // генерация трехзначных чисел
    Console.WriteLine(array[i]);
    if (i%2 != 0) sum += array[i]; 
}

Console.WriteLine($"Сумма чисел массива стоящих на нечетной позиции {sum}");