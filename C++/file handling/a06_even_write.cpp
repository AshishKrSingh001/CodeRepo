#include <iostream>
#include <fstream>
using namespace std;

int main() {
  // Create and open a text file
  ofstream fout("A");
	int n,num;
	cout<<"How many number you want to enter: "<<endl;
	cin>>n;
    for(int i=1;i<=n;i++)
    {
        cout<<"Enter no: "<<endl;
        cin>>num;
        fout<<num<<endl;
    }
  
  fout.close();
}
