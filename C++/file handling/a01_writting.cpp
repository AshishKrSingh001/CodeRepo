#include <iostream>
#include <fstream>
using namespace std;

int main() {
  // Create and open a text file
  ofstream fout("file1.txt",ios::app);
	int roll;
    string name;
    char ch;
    do
    {
        cout<<"Enter name and roll no: "<<endl;
        cin>>name>>roll;
        fout<<name<<"\t"<<roll<<"\n";
        cout<<"repeate(any char)|terminate(n)"<<endl;
        cin>>ch;
    }while(ch!='n' && ch!='N');
  
  fout.close();
}
