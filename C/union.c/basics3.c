#include <stdio.h>

union employee
{
    int emp_id;
    char e_name[20],e_post[20];
    float e_sal;
};

void main()
{
    union employee emp;
    printf("Enter Employee ID, NAME, POST, SALARY:\n");
    scanf("%d%s%s%f",&emp.emp_id,emp.e_name,emp.e_post,&emp.e_sal);

    printf("Employee DETAILS\nID: %d\nNAME: %s\nPOST: %s\nSALARY: %f\n",emp.emp_id,emp.e_name,emp.e_post,emp.e_sal);
    printf("\nEmployee DETAILS\nID: %u\nNAME: %u\nPOST: %u\nSALARY: %u\n",emp.emp_id,emp.e_name,emp.e_post,emp.e_sal);
    printf("\nEmployee DETAILS\nID: %p\nNAME: %p\nPOST: %p\nSALARY: %p\n",emp.emp_id,emp.e_name,emp.e_post,emp.e_sal);
}