#include <iostream>
#include <fstream>
#include <string.h>
using namespace std;

int main() {
  // Create and open a text file
  ifstream fin("file1.txt");
	int roll;
    string name;
    char ch;
    while(fin.eof()==0)
    {
        fin>>name>>roll;
		if(strcmp(name.c_str(),"anish")==0)
        cout<<name<<"\t"<<roll<<endl;
    }
  
  fin.close();
}
