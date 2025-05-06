int[] nums = { 3, 2, 2, 3 };
int val = 3;
int k = RemoveElement(nums, val);
Console.WriteLine($"There are {k} elements that are not {val}");
for(int i = 0; i < k; i++)
{
    Console.Write(nums[i]+ " ");
}


int RemoveElement(int[] nums, int val)
{
    var numList = new List<int>();
    foreach (int num in nums)
    {
        if(!(num == val)) numList.Add(num);
    }
    for (int i = 0; i < numList.Count; i++)
    {
        nums[i] = numList[i];
    }
    return numList.Count;
}