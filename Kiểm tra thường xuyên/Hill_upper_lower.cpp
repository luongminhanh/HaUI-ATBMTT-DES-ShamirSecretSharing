#include<bits/stdc++.h>
using namespace std;

int khoa[10][10];

int soND(int a, int m)
{
    int m0 = m;
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
    if (x<0) x += m0;
    return x;
}

void nhan2mt(int vecto[], int khoa[][10], int kq[])
{
    for (int i = 0; i<2; i++)
    {
        int s = 0;
        for (int j = 0; j<2; j++)
            s += vecto[j] * khoa[j][i];
        kq[i] = s%26;
    }
}

void khoaND(int khoand[][10])
{
    int a = khoa[0][0], b = khoa[0][1], c = khoa[1][0], d = khoa[1][1];
    int det = a*d - b*c;
    int detnd = (soND(det, 26));
    khoand[0][0] = (detnd * d) % 26;
    khoand[0][1] = (detnd * -b) % 26;
    khoand[1][0] = (detnd * -c)%26;
    khoand[1][1] = (detnd * a) % 26;
    if (khoand[0][1] < 0) khoand[0][1] += 26;
    if (khoand[1][0] < 0) khoand[1][0] += 26;
}

string maHoa(string banRo)
{
    string s;
    int i= 0;
    while (i < banRo.length())
    {
        int vecto[10], kq[10];
        for (int j = 0; j<2; j++)
            if (isupper(banRo[i+j]))
                vecto[j] = banRo[i+j] - 65;
            else vecto[j] = banRo[i+j] - 97;
        nhan2mt(vecto, khoa, kq);
        for (int j = 0; j<2; j++)
            if (isupper(banRo[i+j]))
                s += (char)(kq[j] + 65);
            else s += (char)(kq[j] + 97);
        i += 2;
    }
    return s;
}
/*
string maHoa(string banRo)
{
    string s;
    int i= 0;
    while (i < banRo.length())
    {
        int vecto[10], kq[10];
        bool hopLe = true;
        for (int j = 0; j<2; j++)
        {
            if (i+j >= banRo.length())
            {
                hopLe = false;
                break;
            }
            if (isupper(banRo[i+j]))
                vecto[j] = banRo[i+j] - 65;
            else if (islower(banRo[i+j]))
                vecto[j] = banRo[i+j] - 97;
            else
            {
                hopLe = false;
                break;
            }
        }
        if (hopLe)
        {
            nhan2mt(vecto, khoa, kq);
            for (int j = 0; j<2; j++)
            {
                if (isupper(banRo[i+j]))
                    s += (char)(kq[j] + 65);
                else if (islower(banRo[i+j]))
                    s += (char)(kq[j] + 97);
            }
        }
        i += 2;
    }
    return s;
}
*/

string giaiMa(string banMa)
{
    string s;
    int i = 0;
    int khoand[10][10];
    khoaND(khoand);
    while(i<banMa.length())
    {
        int vecto[10], kq[10];
        for (int j = 0; j<2; j++)
            if (isupper(banMa[i+j]))
                vecto[j] = banMa[i+j] - 65;
            else vecto[j] = banMa[i+j] - 97;
        nhan2mt(vecto, khoand, kq);
        for (int j = 0; j<2; j++)
            if (isupper(banMa[i+j]))
                s += (char)(kq[j] + 65);
            else s += (char)(kq[j] + 97);
        i += 2;
    }
    return s;
}
int main()
{
    string s1, s2;
    getline(cin, s1);
    getline(cin, s2);
    for (int i = 0; i<2; i++)
        for (int j = 0; j<2; j++)
            cin>>khoa[i][j];
    int khoand[10][10];
    khoaND(khoand);
    for (int i = 0; i<2; i++)
        for (int j = 0; j<2; j++)
            cout<<khoand[i][j]<<" ";
    cout<<maHoa(s1)<<endl<<giaiMa(s2);
    cout<<soND(13, 26)<<endl;
}

//UpcsGGIlan
//dzva3V

//YguLiixzanaZ
//Otcuouywcwan
