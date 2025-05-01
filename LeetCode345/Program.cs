string[] strings = { "IceCream", "leetcode"};
foreach (string s in strings)
{
    Console.WriteLine(ReverseVowels(s));
}

string ReverseVowels(string s)
{
    var charIndices = new List<int>();
    string lower = s.ToLower();
    char[] reverse = s.ToCharArray();
    for (int i = 0; i < lower.Length; i++)
    {
        switch (lower[i])
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                charIndices.Add(i);
                continue;
            default: continue;
        }
    }
    for(int i = 0; i < charIndices.Count / 2; i++)
        {
        char temp = reverse[charIndices[i]];
        reverse[charIndices[i]] = reverse[charIndices[charIndices.Count - 1 - i]];
        reverse[charIndices[charIndices.Count - 1 - i]] = temp;
    }
    return new string(reverse);
}
