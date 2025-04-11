bool IsPalindrome(int x) {
    if(x < 0) return false;
    if(x < 10) return true;
    if(x < 100) {
        return x%11 == 0;
    }
    string s = x.ToString();
    for(int i = 0; i < s.Length/2; i++) {
        if(s[i] != s[s.Length - 1 - i]) return false;
    }
    return true;
}

bool fun = IsPalindrome(121);
System.Console.WriteLine(fun);