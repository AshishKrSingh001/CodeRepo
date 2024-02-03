#include <iostream>
#include <fstream>
using namespace std;
template<typename T>
class Array_input
{
	T *arr;
	int size;
	ofstream fout;
	public:
	Array_input(string name,T *arr,int size)
	{
		this->arr=arr;
		this->size=size;
		fout.open(name,ios::app);
		
		arr = new T[size];
	}
	void input()
	{
		cout<<"Enter Array element in the File"<<endl;
		
		for(int i=0;i<size;i++)
		{
			cin>>*(arr+i);
			fout<<*(arr+i)<<"\t";
		}
		fout<<endl;
	}
	~Array_input()
	{
		delete arr;
	}
};
template<typename T>
class Array_output
{
	T *arr;
	ifstream fin;
	public:
	Array_output(string name,T *arr)
	{
		this->arr=arr;
		fin.open(name);
		arr = new T;
	}
	void output()
	{
		cout<<"Array element in the File"<<endl;
		
		for(int i;!fin.eof();i++)
		{
			fin>>*(arr+i);
			cout<<*(arr+i)<<"\t";
		}
		cout<<endl;
	}
	~Array_output()
	{
		delete arr;
	}
};
template<class T>
void Array_display(T arr,int size)
{
	cout<<"Array: "<<endl;
	for(int i;i<size;i++)
	{
		cout<<*(arr+i)<<"\t";
	}
	cout<<endl;
}
int main()
{
	int *arr,size;
	cout<<"Enter size of Array: "<<endl;
	cin>>size;
		
	Array_input<int> ai("Array.num",arr,size);
	Array_output<int> ao("Array.num",arr);
	Array_display(arr,size);
	return 0;
}