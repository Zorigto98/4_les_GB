int[] array = {1, -2, 3, 0, 5, 2, 9, -6, 5, 4, -6, 7};
int sumPositive = 0;
int sumNegative = 0;


for (int i=0; i < array.Length; i++)
{
    if (array[i] > 0) sumPositive += array[i];
    else sumNegative -= array[i];
}

Console.WriteLine($"сумма положительных чисел массива =  {sumPositive}");
Console.WriteLine($"сумма отрицательных чисел массива =  {sumNegative}");