#include<bits/stdc++.h>
using namespace std;

int a, b;

int soND(int a, int m)
{
    int y = 0, x = 1;
    while(a>1)
    {
        int q = a/m;
        int t = m;
        m = a%m;
        a = t;
        t = y;
        y = x - q*y;
        x = t;
    }
    if (x<0) x += 26;
    return x;
}

string maHoa(string banRo)
{
    string s;
    for (int i = 0; i<banRo.length(); i++)
    {
        if (isupper(banRo[i]))
            s += (char)(((a * (banRo[i] - 'A') + b) % 26) + 'A');
        else s += (char)(((a * (banRo[i] - 'a') + b) % 26) + 'a');
    }
    return s;
}
string giaiMa(string banMa)
{
    string s;
    int a_inv = soND(a, 26);
    for (int i = 0; i<banMa.length(); i++)
    {
        if (isupper(banMa[i]))
            s += (char)((a_inv * ((banMa[i] - 'A') - b + 26) % 26) + 'A');
        else s += (char)((a_inv * ((banMa[i] - 'a') - b + 26) % 26) + 'a');
    }
    return s;
}
int main()
{
    string s1, s2;
    getline(cin, s1);
    getline(cin, s2);
    cin>>a>>b;
    cout<<maHoa(s1)<<endl<<giaiMa(s2);
}
