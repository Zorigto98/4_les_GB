int N=5;

int[] array = new int [N];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10); // генерация трехзначных чисел
    Console.WriteLine(array[i]);
}

for (int i = 0; i < array.Length/2; i++)
{
    int Multi = 1;
    Multi = array[i] * array[(array.Length-1)-i];
    Console.WriteLine($"Произведение {i+1} элемента и {array.Length-i} элемента = {Multi}");
}