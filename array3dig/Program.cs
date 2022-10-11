//Console.WriteLine("Введите колличество элементов массива");
//int N = Convert.ToInt32(Console.Read());
int N=7;
int countEven = 0, countOdd = 0;
int[] array = new int [N]; // N - вводится пользователем с клавиатуры

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999); // генерация трехзначных чисел
    Console.WriteLine(array[i]);
    if (array[i]  % 2 == 0) countEven++;
    else countOdd++;
}

Console.WriteLine($"Колличество четных чисел  {countEven}");
Console.WriteLine($"Колличество нечетных чисел  {countOdd}");