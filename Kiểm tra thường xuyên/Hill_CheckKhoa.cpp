#include<bits/stdc++.h>
using namespace std;

int khoa[2][2];

int gcd(int a, int b)
{
    if (a==0) return b;
    else if (b==0) return a;
    else return gcd(b, a%b);
}

int soNghichDao(int a, int m)
{
    int y = 0, x = 1;
    int m0 = m;
    if (m==1) return 0;
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

int det(int k[2][2])
{
    return k[0][0] * k[1][1] - k[0][1] * k[1][0];
}

int main()
{
    string s1, s2;
    cout<<"Nhap xau thu nhat: "; getline(cin, s1);
    cout<<"Nhap xau thu hai: "; getline(cin, s2);
    cout<<"Nhap khoa: ";
    for (int i = 0; i<2; i++)
        for (int j = 0; j<2; j++)
            cin>>khoa[i][j];
    for (int i = 0; i<2; i++)
        for (int j = 0; j<2; j++)
            cout<<khoa[i][j]<<" ";

    while (det(khoa)==0 || gcd(det(khoa), 26)!=1 || gcd(khoa[0][0], 26) != 1 ||
    gcd(khoa[0][1], 26) != 1 || gcd(khoa[1][0], 26) != 1 || gcd(khoa[1][1], 26) != 1)
    {
        cout<<"Khoa khong hop le!"<<endl<<"Nhap lai khoa: ";
        for (int i = 0; i<2; i++)
            for (int j = 0; j<2; j++)
                cin>>khoa[i][j];
    }
   // cout<<maHoa(s1)<<endl<<giaiMa(s2);
}
