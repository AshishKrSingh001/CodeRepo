#include <iostream>
using namespace std;

class person
{
    protected:
    string name;
    int age;

};
class cricketPlayer:private person
{
    public:
    cricketPlayer(string name,int age)
    {
        this->name = name;
        this->age = age;
    }
    ~cricketPlayer()
    {
        cout<<"Player Name: "<<name<<endl<<"Age: "<<age<<endl;
    }
};
int main()
{
    cricketPlayer player1("Virat kohli",34);
    return 0;
}