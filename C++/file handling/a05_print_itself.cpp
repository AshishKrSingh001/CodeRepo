#include <iostream>
#include <fstream>
using namespace std;
int main(int argc,char*argv[]) 
{
	if(argc>2 || argc<2)
	{
		cout<<"Invalid command!"<<endl;
		return 0;
	}
  // Create and open a text file
  ifstream fin(argv[1]);
    char ch;
	int c=0,c1=0;
	if((ch=fin.get())==EOF)
		cout<<"0 lines"<<endl;
	else
	{
		while((ch=fin.get())!=EOF)
	{
		cout<<ch;
		c1++;
		if(ch=='\n')
			c++;
	}
	cout<<endl<<endl<<"no of lines: "<<c+1<<endl<<"no of characters: "<<c1+c<<endl;
	}
  fin.close();
}
