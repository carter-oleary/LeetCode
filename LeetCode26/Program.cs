int[] arr = { 1, 1, 2 };
int k = RemoveDuplicates(arr);
for(int i = 0; i < k; i++)
{
    Console.Write(arr[i] + " ");
}

int RemoveDuplicates(int[] arr)
{
    List<int> result = new List<int>();
    foreach (int value in arr)
    {
        if(!result.Contains(value)) result.Add(value);
    }
    for(int i = 0; i < result.Count; i++)
    {
        arr[i] = result[i];
    }
    return result.Count;
}