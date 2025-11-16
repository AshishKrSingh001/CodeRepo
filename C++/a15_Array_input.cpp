#include <iostream>
#include <fstream>
using namespace std;
template<typename T>
class Array
{
	T *arr;
	int *size;
	ofstream fout;
	public:
	Array()
	{
		fout.open("Array.num",ios::app);
		size = new int;
		cout<<"Enter size of Array: "<<endl;
		cin>>*size;
		arr = new T[*size];
	}
	void input()
	{
		cout<<"Enter Array element in the File"<<endl;
		
		for(int i=0;i<*size;i++)
		{
			cin>>*(arr+i);
			fout<<*(arr+i)<<"\t";
		}
		fout<<endl;
	}
	~Array()
	{
		delete arr;
		delete size;
	}
};
int main()
{
	Array <int> a;
	a.input();
	return 0;
}