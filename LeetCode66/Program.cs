using System.Numerics;

int[] ints = PlusOne([9,8,7,6,5,4,3,2,1,0]);
foreach(int i in ints)
{
    Console.Write(i);
}

int[] PlusOne(int[] digits)
{
    BigInteger num = 0;
    for (int i = 0; i < digits.Length; i++)
    {
        num += digits[i];
        if(i != digits.Length - 1) num *= 10;
    }
    num++;
    Console.WriteLine(num);
    string s = num.ToString();
    Console.WriteLine(s);
    if (s.Length > digits.Length) digits = new int[s.Length];
    for (int i = 0; i < digits.Length; i++)
    {
        digits[i] = (int)s[i] - 48;
    }
    return digits;
}