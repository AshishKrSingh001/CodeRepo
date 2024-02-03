#include <iostream>
#include <fstream>
using namespace std;
class APerson
{
	protected:
	char* name;
	int age;
	int id,roll;
	string course;
	double fees;
	public:
	virtual void input()=0;
	virtual void output()=0;
};
class CStudent:public APerson
{
	public:
	void input();
	void output();
	
};
inline void CStudent::input()
{
	cout<<"Enter your name: "<<endl;
	gets(name);
	cout<<"Enter your age: "<<endl;
	cin>>age;
	cout<<"Enter your ID: "<<endl;
	cin>>id;
	cout<<"Enter your course: "<<endl;
	cin>>course;
	cout<<"Enter your Roll no: "<<endl;
	cin>>roll;
	cout<<"Enter your fees: "<<endl;
	cin>>fees;
}
inline void CStudent::output()
{
	ofstream fout("Data.txt",ios::app);
	fout<<"Name: "<<name<<endl<<"Age: "<<age<<endl<<"Id: "<<id<<endl<<"Course: "<<course<<endl<<"Roll no: "<<roll<<endl<<"Fess: "<<fees<<endl<<endl;
	cout<<endl<<"Name: "<<name<<endl<<"Age: "<<age<<endl<<"Id: "<<id<<endl<<"Course: "<<course<<endl<<"Roll no: "<<roll<<endl<<"Fess: "<<fees<<endl<<endl;
	fout.close();
}
int main()
{
	CStudent stud;
	stud.input();
	stud.output();
	
	
}