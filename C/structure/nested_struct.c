#include <stdio.h>

struct dob
{
    int dd,mm,yyyy;
};
struct employee
{
    int emp_id;
    char name[20],post[10];
    float salary;
    struct dob b;
}emp;

void main()
{
    printf("Enter Employee_ID, Name, Post & Salary:\n ");
    scanf("%d%s%s%f",&emp.emp_id,emp.name,emp.post,&emp.salary);
    printf("Enter date of birth:(date/month/year):\n");
    scanf("%d%d%d",&emp.b.dd,&emp.b.mm,&emp.b.yyyy);

    printf("Employee_ID=%d\nName=%s\nPost=%s\nSalary=%f\nDate of birth=%d/%d/%d\n",emp.emp_id,emp.name,emp.post,emp.salary,emp.b.dd,emp.b.mm,emp.b.yyyy);

}