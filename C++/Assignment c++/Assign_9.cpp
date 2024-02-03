#include <iostream>
using namespace std;

class Train
{
    protected:
    int f_seat,s_seat,t_seat;
    public:
    void set_no_of_Seat(int First_Class_Seat,int Second_Class_Seat,int Third_Class_Seat)
    {
        f_seat = First_Class_Seat;
        s_seat = Second_Class_Seat;
        t_seat = Third_Class_Seat;
    }
    void Display()
    {
        cout<<"\n\nFirst_Class_Seat: "<<f_seat<<endl<<"Second_Class_Seat: "<<s_seat<<endl<<"Third_Class_Seat: "<<t_seat<<endl;
    }
};
class Reservation:public Train
{
    private:
    int f_booked,s_booked,t_booked;
    public:
    void set_booked_ticket(int First_Class_Seat,int Second_Class_Seat,int Third_Class_Seat)
    {
        f_booked = First_Class_Seat;
        s_booked = Second_Class_Seat;
        t_booked = Third_Class_Seat;
    }
    void set_cancled_ticket(int First_Class_Seat,int Second_Class_Seat,int Third_Class_Seat)
    {
        f_booked = f_booked-First_Class_Seat;
        s_booked = s_booked-Second_Class_Seat;
        t_booked = s_booked-Third_Class_Seat;
    }
    void Display()
    {
        cout<<"\n\nFirst_Class_Booked_Seat: "<<f_booked<<endl<<"Second_Class_Booked_Seat: "<<s_booked<<endl<<"Third_Class_Booked_Seat: "<<t_booked<<endl;
    }
};
int main()
{
    Reservation res;
    res.set_no_of_Seat(100,200,300);
    res.Train::Display();
    res.set_booked_ticket(90,190,284);
    res.Display();
    res.set_cancled_ticket(10,10,50);
    res.Display();
    return 0;
}