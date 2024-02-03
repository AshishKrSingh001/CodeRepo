#include <iostream>
#include <fstream>
using namespace std;
template<typename T>
class Array
{
	T *num;
	ifstream fin;
	public:
	Array(string name)
	{
		fin.open(name);
		num = new T;
	}
	void output()
	{
		cout<<"Array element in the File"<<endl;
		
		while(!fin.eof())
		{
			fin>>*num;
			cout<<*num<<"\t";
		}
		cout<<endl;
	}
	~Array()
	{
		delete num;
	}
};
int main(int argc,char*argv[])
{
	string str;
	if(argc>2 || argc<2)
	{
		str="Array.num";
	}
	else
	{
		str=argv[1];
	}
	Array <int> a(str);
	a.output();
	return 0;
}