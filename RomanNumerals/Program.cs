int RomanToInt(string s) {
    int num = 0;
    for(int i = 0; i < s.Length; i++) {
        switch(s[i]) {
            case 'I': 
                if(i+1 < s.Length && s[i+1] == 'V') {
                    num += 4;
                    i++;
                    continue;
                } else if (i+1 < s.Length && s[i+1] == 'X') {
                    num += 9;
                    i++;
                    continue;
                } else {
                    num ++;
                    continue;
                }

            case 'V':
                num += 5;
                continue;

            case 'X':
                if(i+1 < s.Length && s[i+1] == 'L') {
                    num += 40;
                    i++;
                    continue;
                } else if (i+1 < s.Length && s[i+1] == 'C') {
                    num += 90;
                    i++;
                    continue;
                } else {
                    num += 10;
                    continue;
                }

            case 'L':
                num += 50;
                continue;

            case 'C':
                if(i+1 < s.Length && s[i+1] == 'D') {
                    num += 400;
                    i++;
                    continue;
                } else if (i+1 < s.Length && s[i+1] == 'M') {
                    num += 900;
                    i++;
                    continue;
                } else {
                    num += 100;
                    continue;
                }

            case 'D':
                num += 500;
                continue;
            
            case 'M':
                num += 1000;
                continue;
        }
    
    }
    return num;
} 


string s = "XVIII";
int num = RomanToInt(s);
