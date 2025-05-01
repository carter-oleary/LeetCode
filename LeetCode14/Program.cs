string[] strs = ["a", "a", "b"];
Console.WriteLine(LongestCommonPrefix(strs));

string LongestCommonPrefix(string[] strs)
{
    string prefix = strs[0];
    for(int i = 1; i <  strs.Length; i++)
    {
        string s = strs[i];
        Console.WriteLine($"String: {s}");
        int shorter = Math.Min(s.Length, prefix.Length);
        if (shorter == 0) return "";
        for(int j = 0; j < shorter; j++)
        {
            Console.WriteLine($"{s[j]} {prefix[j]}");
            if (s[j] != prefix[j])
            {
                if (j == 0) return "";
                prefix = prefix.Substring(0, j);
                break;
            } else if(shorter == 1)
            {
                prefix = prefix[0].ToString();
                break;
            }
            prefix = prefix.Substring(0, shorter);
        }
        

        
    }
    return prefix;
}