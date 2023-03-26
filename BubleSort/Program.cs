//Buble Sort
var arr = new List<int>() { 2, 5, 3, 8, 6 };

for (int i = 0; i < arr.Count; i++)
{
    for (int j = i + 1; j < arr.Count; j++)
    {
        if (arr[i] > arr[j])
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
    Console.Write($"{arr[i]} ");
}

