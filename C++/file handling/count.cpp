#include <iostream>
#include <fstream>
#include <cstring>
using namespace std;
void count(int *a,char ch)
{
	switch(ch)
	{
		case '0':a[0]++;break;
		case '1':a[1]++;break;
		case '2':a[2]++;break;
		case '3':a[3]++;break;
		case '4':a[4]++;break;
		case '5':a[5]++;break;
		case '6':a[6]++;break;
		case '7':a[7]++;break;
		case '8':a[8]++;break;
		case '9':a[9]++;break;
		case 'A':a[10]++;break;
		case 'B':a[11]++;break;
		case 'C':a[12]++;break;
		case 'D':a[13]++;break;
		case 'E':a[14]++;break;
		case 'F':a[15]++;break;
		case 'G':a[16]++;break;
		case 'H':a[17]++;break;
		case 'I':a[18]++;break;
		case 'J':a[19]++;break;
		case 'K':a[20]++;break;
		case 'L':a[21]++;break;
		case 'M':a[22]++;break;
		case 'N':a[23]++;break;
		case 'O':a[24]++;break;
		case 'P':a[25]++;break;
		case 'Q':a[26]++;break;
		case 'R':a[27]++;break;
		case 'S':a[28]++;break;
		case 'T':a[29]++;break;
		case 'U':a[30]++;break;
		case 'V':a[31]++;break;
		case 'W':a[32]++;break;
		case 'X':a[33]++;break;
		case 'Y':a[34]++;break;
		case 'Z':a[35]++;break;
		case 'a':a[36]++;break;
		case 'b':a[37]++;break;
		case 'c':a[38]++;break;
		case 'd':a[39]++;break;
		case 'e':a[40]++;break;
		case 'f':a[41]++;break;
		case 'g':a[42]++;break;
		case 'h':a[43]++;break;
		case 'i':a[44]++;break;
		case 'j':a[45]++;break;
		case 'k':a[46]++;break;
		case 'l':a[47]++;break;
		case 'm':a[48]++;break;
		case 'n':a[49]++;break;
		case 'o':a[50]++;break;
		case 'p':a[51]++;break;
		case 'q':a[52]++;break;
		case 'r':a[53]++;break;
		case 's':a[54]++;break;
		case 't':a[55]++;break;
		case 'u':a[56]++;break;
		case 'v':a[57]++;break;
		case 'w':a[58]++;break;
		case 'x':a[59]++;break;
		case 'y':a[60]++;break;
		case 'z':a[61]++;break;
		case ' ':a[62]++;break;
		case '\n':a[63]++;break;
		default:a[64]++;break;
	}
}
class FileContentCount
{
	ifstream fin;
	char ch;
	int a[65];
	int c;
	public:
	FileContentCount(string filename)
	{
		fin.open(filename);
		for(int i=0;i<=64;i++)
		{
			a[i]=0;
		}
	}
	void countOfChars()
	{
		c=0;
		while((ch=fin.get())!=EOF)
		{
			c++;
			cout<<ch;
			count(a,ch);
			
		}
		cout<<endl<<endl;
	}
	void display()
	{
		cout<<"no of Characters: "<<c+a[63]<<endl;;
		for(int i=0,j=48;i<=9;i++,j++)
		{
			cout<<"no of "<<(char)j<<"\'s: "<<a[i]<<endl;
		}
		for(int i=10,j=65;i<=35;i++,j++)
		{
			cout<<"no of "<<(char)j<<"\'s: "<<a[i]<<endl;
		}
		for(int i=36,j=97;i<=61;i++,j++)
		{
			cout<<"no of "<<(char)j<<"\'s: "<<a[i]<<endl;
		}
		cout<<"no of Space\'s: "<<a[62]<<endl;
		cout<<"no of Line\'s: "<<a[63]+1<<endl;
		cout<<"no of Special Symbol\'s: "<<a[64]<<endl;
		
	}
	~FileContentCount()
	{
		fin.close();
	}
};
int main(int argc,char*argv[])
{
	string str;
	if(argc>2 || argc<2)
	{
		str="count.cpp";
		cout<<str<<endl;
	}
	else
	{
		str=argv[1];
		cout<<str<<endl;
	}
	FileContentCount f(str);
	//FileContentCount f("Data.cpp");
	f.countOfChars();
	f.display();
}