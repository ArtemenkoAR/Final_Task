string[] array1 = new string[5] { "Hello", "2", "world", ":-)", "Ufa" };
string[] array2 = new string[array1.Length];

void SecondArray(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
            arr2[j] = arr1[i];
        j++;
    }
}

void PrintArray(string[] arr3)
{
    for (int i = 0; i < arr3.Length; i++)
    {
        Console.Write($"{arr3[i]} ");
    }
}

SecondArray(array1, array2);
PrintArray(array2);
