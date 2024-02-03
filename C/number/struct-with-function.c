// #include<stdio.h>
// stuct Account
// {
//     char ac-no[20], ac-type[20], ac-name[20];
//     float blance;
// };
// void getInput();
// void debit();
// void credit();
// void getmini struct();
// stuct Account ac;// global stucture varibale.
// void main()
// {
//     int choice;
//     get Input();
//     do
//     {
//         printf("Enter choice\n Press 1 for debit\n Press 2 for credit\n Press 3 for get mini stmt\n Press 4 for exit\n");
//         scanf("%d",&choice);
//     switch (choice)
//     {
//         case 1:
//         debit(); break;
//          case 2:
//         credit(); break;
//          case 3:
//         getmini stmt(); break;
//          case 4:
//         exit(0);
//         default;
//         parintf("Invalid choice\n");
//     }
        
//     } 
//     while (choice>=1&&choice<=4);
//     void getInput()
//     {
//         printf("Enter a/c no, a/c name, a/c type and balance");
//         scanf("%s%s%s%f",ac. ac-no,ac.ac-name, ac.ac-type,&ac.balance);
//     }
//     void debit()
//     {
//         int amt;
//         Printf("How much amount to be debited?");
//         scanf("%d",&amt);
//         if(amt<=ac.balance)
//         ac.balance=ac.balance-amt;
//         else
//         Printf("Insufficient fund\n");
//     }
//     void credit()
//     {
//         int amt;
//         Printf("How much amount to be credited?");
//         scanf("%d",&amt);
//         ac.balance=ac.balance + amt;
//     }
// }

# include<stdio.h>
struct student
{
    int rollno;
    char nm[20],cs[20]
    float fee;
};
void getInput(struct student s)
{
    printf("Enter rollno, name, course & fee");
    scanf("%d%s%s%f", &s.rollno,s.nm, s.cs,&s.fee);

}
struct student print Record()
{
    struct student s;
    printf("Rollno=%d\n Name=%s\n course=%s\n fee=%f\n",s.rollno, s.nm, s.cs, s.fee);
    return(s);
}
void main()
{
    struct student s;
    getInput(s);
    s=print Record();
}
