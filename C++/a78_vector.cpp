/*
	Modifiers:
	{
		push_back():
			It add element at the end.
			
		pop_back():
			It deletes the last element.
			
		insert():
			Inserts new elements before specified position.
			
		erase():
			Removes the elements from the container from the specified range.
			
		swap():
			It swaps the content between vectors.
			
		assign():
			It assigns new value to the vector.
			
		clear():
			It is used to remove all elements.
	}
	
	Iterators:
	{
		begin():
			It returns the iterator to the beginning.
			
		end():
			It returns the iterator to the end.
	}
	
	Capacity:
	{
		size():
			It rreturns the number of elements in the vector.
			
		max_size():
			It returns maximum size of vector.
			
		resize():
			It changes the size.
			
		capacity():
			Return size allocated storage capacity.
			
		empty():
			It tests whether the vector is empty.
	}
*/

#include <iostream>
#include <vector>

using namespace std;

class vectorEx
{
	public:
	vector<int>n;
	vectorEx()
	{
		cout<<"Hi <Constructor>"<<endl;
	}
	void vectorInput()
	{
		int x;
		cout<<"Vector intput"<<endl<<"Enter 5 elements"<<endl;
		for(int i=0;i<5;i++)
		{
			cin>>x;
			n.push_back(x);
		}
	}
	void vectorOutput()
	{
		cout<<"Vector output"<<endl;
		for(int i=0;i<n.size();i++)
		{
			cout<<n[i]<<"\t";
		}
		cout<<endl;
	}
	~vectorEx()
	{
		cout<<"Bye <Destructor>"<<endl;
	}
};

int main(int argc,char*argv[])
{
	vectorEx *v_Ex = new vectorEx();
	v_Ex->vectorInput();
	v_Ex->vectorOutput();
	cout<<"Size of the vector"<<v_Ex->n.size()<<endl;
	cout<<"Max Size of the vector"<<v_Ex->n.max_size()<<endl;
	cout<<"capacity of the vector"<<v_Ex->n.capacity()<<endl;
	cout<<"empptyness of the vector"<<v_Ex->n.empty()<<endl;
	
	v_Ex->n.pop_back();
	v_Ex->vectorOutput();
	//v_Ex->n.push_back();
	v_Ex->vectorOutput();
	v_Ex->n.assign(2,10);
	v_Ex->vectorOutput();
	delete v_Ex;
	return 0;
}
