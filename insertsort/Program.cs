static int insertionSort(int[] arr)
{
    int i, key, j;
    for (i = 1; i < arr.Length; i++)
    {
        key = arr[i];
        j = i - 1;

        while (j >= 0 && arr[j] < key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }


    return 0;
}

int[] mass_chils = new int[10];
Random random = new Random();
Console.Write("Вот массив: \t");
for (int i = 0; i < mass_chils.Length; i++)
{
    mass_chils[i] = random.Next(100);
    Console.Write($"{mass_chils[i]} \t");
}

insertionSort(mass_chils);
Console.WriteLine();
Console.Write("вот метод сортироки или результат: \t");
for (int p = 0; p < mass_chils.Length; p++)
{
    Console.Write(mass_chils[p] + "\t");
}

Console.ReadLine();