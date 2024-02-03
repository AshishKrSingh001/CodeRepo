#include <iostream>
#include <fstream>
using namespace std;
int main()
{
	
	ifstream fin("A");
	ofstream fout("B");
	int n;
	while(fin.eof()==0)
    {
        fin>>n;
        if(n%2==0)
        {
            fout<<n<<endl;
        }
    }
    fin.close();
    fout.close();
	
}