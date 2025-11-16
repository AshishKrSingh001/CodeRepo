#include <iostream>
#include <fstream>
using namespace std;

int main() {
  // Create and open a text file
  ofstream fout("file2");
  ifstream fin("file1");
	int roll;
    string name;
    char ch;
    while(fin.eof()==0)
	{
		fin>>name>>roll;
		fout<<name<<"\t"<<roll<<endl;
	}
  
  fout.close();
  fin.close();
}
