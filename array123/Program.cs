int N=123;
int count = 0;
int[] array = new int [N]; 

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 200); 
    Console.WriteLine(array[i]);
    if (array[i] >=10 && array[i]<=99) count++;
}

Console.WriteLine($"Колличество элементов масива лежащих в интервале [0, 99]  {count}");