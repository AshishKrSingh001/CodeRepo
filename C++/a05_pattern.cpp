#include <iostream>
using namespace std;
int main()
{
    int i,j,s=9;

    cout<<"pattern 1:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=1;j<=i;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 2:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=1;j<=i;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 3:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 4:"<<endl;
      for(i=s;i>0;i--)
    {
        for(j=1;j<=i;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 5:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=1;j<=i;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 6:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 7:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 8:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 9:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 10:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

     cout<<endl<<"Pattern 11:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

     cout<<endl<<"Pattern 12:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 13:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 14:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 15:"<<endl;
    for(i=1;i<=s;i++)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        for(j=i-1;j>=1;j--)
        {
            cout<<j;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 16:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<"*";
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 17:"<<endl;
    for(i=s;i>=1;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=i;j++)
        {
            cout<<j;
        }
        for(j=i-1;j>=1;j--)
        {
            cout<<j;
        }
        cout<<endl;
    }


    cout<<endl<<"Pattern 18:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s-i;j>=1;j--)
        {
            cout<<' ';
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<i;
        }
        cout<<endl;
    }

    cout<<endl<<"Pattern 19:"<<endl;
    for(i=s;i>0;i--)
    {
        for(j=s;j>i;j--)
        {
            cout<<j;
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<i;
        }
        for(j=i+1;j<=s;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }
    for(i=2;i<=s;i++)
    {
        for(j=s;j>i;j--)
        {
            cout<<j;
        }
        for(j=1;j<=2*i-1;j++)
        {
            cout<<i;
        }
        for(j=i+1;j<=s;j++)
        {
            cout<<j;
        }
        cout<<endl;
    }


    return 0;
}