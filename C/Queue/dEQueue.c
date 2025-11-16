#include <stdio.h>
#define SIZE 5
int Q[SIZE];
int front = -1;
int rear = -1;

void enqueueAtBegin(int data){
    if(front>0){
        Q[--front] = data;
        printf("\nInsertion at front successful");
        return;
    }
    printf("\nInsertion at front not possible");
}
void enqueueAtEnd(int data){
    if(rear == SIZE-1){
        printf("\nOverFlow");
        return;
    }else if(front == -1){
        front++;
    }
    Q[++rear] = data;
    printf("\nInsertion at rear successful");
}
int dequeueAtBegin(){
    int data = -1;
    if(front == -1){
        printf("\nUnderFlow");
        return data;
    }else if(rear == front){
        data = Q[front];
        front=-1;
        rear = -1;
    }else{
        data = Q[front];
        front++;
    }
    printf("\nDeletion at front successful");
    return data;
}
int dequeueAtEnd(){
    int data = -1;
    if(rear == -1){
        printf("\nUnderFlow");
        return data;
    }
    data = Q[rear];
    rear--;
    printf("\nDeletion at rear successful");
    return data;
}
void display(){
    if(front == -1){
        printf("\nUnderflow");
    }else{
        printf("\nQueue ->[");
        for(int i=front;i<=rear;i++){
            printf("%d", Q[i]);
            if(i!=rear){
                printf(", ");
            }
        }
        printf("]\n");
    }
}

int main(){

    // Input Restricted Queue(delete from both but insert at rear)
    // enqueueAtEnd(10);
    // display();
    // enqueueAtEnd(20);
    // display();
    // enqueueAtEnd(30);
    // display();
    // enqueueAtEnd(40);
    // display();
    // enqueueAtEnd(50);
    // display();
    // enqueueAtEnd(60);
    // display();

    // dequeueAtBegin();
    // display();
    // dequeueAtEnd();
    // display();
    // dequeueAtBegin();
    // display();
    // dequeueAtEnd();
    // display();
    // dequeueAtBegin();
    // display();
    // dequeueAtEnd();
    // display();

    // Output Restricted Queue(insert from both but delete at front)
    enqueueAtEnd(10);
    display();
    enqueueAtEnd(40);
    display();
    enqueueAtEnd(20);
    display();
    enqueueAtEnd(30);
    display();
    enqueueAtEnd(40);
    display();
    enqueueAtEnd(50);
    display();
    dequeueAtBegin();
    display();
    dequeueAtBegin();
    display();
    dequeueAtBegin();
    display();
    dequeueAtBegin();
    display();
    enqueueAtBegin(30);
    display();
    enqueueAtBegin(40);
    display();
    enqueueAtBegin(50);
    display();
}