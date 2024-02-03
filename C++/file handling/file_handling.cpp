#include <iostream>
#include <fstream>
using namespace std;

class Input
{
    ofstream fout;
	public:
    Input(const string file)
    {
        fout.open(file);
    }
    void operation()
    {
        int n;
        double num;
        cout<<"How many number you want to enter: "<<endl;
        cin>>n;
        cout<<"Enter "<<n<<" number to a file: "<<endl;
        for(int i=0;i<n;i++)
        {
            cin>>num;
            fout<<num<<endl;
        }
    }
    ~Input()
    {
        fout.close();
    }
};

class Output
{
    ifstream fin;
    ofstream fout1;
    ofstream fout2;
	public:
    Output(const string file,const string oddfile,const string evenfile)
    {
        fin.open(file);
        fout1.open(oddfile);
        fout2.open(evenfile);
    }
    void operation()
    {
        double num;
        while(!fin.eof())
        {
            fin>>num;
            if((int)num%2==0)
            fout1<<num<<endl;
            else
            fout2<<num<<endl;
        }
    }
    ~Output()
    {
        fin.close();
        fout1.close();
        fout2.close();
    }
};
 
int main()
{
    Input in("A.abc");
    in.operation();
    Output out("A.abc","B.abc","C.abc");
    out.operation();
	return 0;
}