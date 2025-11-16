#include <iostream>
#include <string.h>

using namespace std;

int main()
{
	char str[50] = "my name is ashish";
	char sr[20]="my";
	/*cout<<"Enter a String"<<endl;
	cin>>str;
	cout<<"Enter a word"<<endl;
	cin>>sr;*/
	int i,j=0,count=0;
	for(i=0;i<strlen(str);i++)
	{
		if(str[i]==sr[j++])
			count++;
		else if(j==strlen(sr))
		{
			count=0;j=0;
			if(str[i]==' ')
				if(str[i+1]==sr[j++] && j<=strlen(sr))
					count++;
		}
	}
	if(count==strlen(sr))
		cout<<"Matched";
	else
		cout<<"Not matched";
	return 0;
}