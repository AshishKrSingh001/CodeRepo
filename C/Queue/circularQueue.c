#include <stdio.h>
#define SIZE 5
int Q[SIZE];
int front = -1;
int rear = -1;

void enqueue(int data){
    if((front == 0 && rear == SIZE-1) || (front == rear+1)){
        printf("\nOverflow");
        return;
    }else if(front == -1){
        front++;
    }
    rear = (++rear)%SIZE;
    Q[rear] = data;
    printf("\nInsertion Successful");
}
int dequeue(){
    if(front == -1){
        printf("\nUnderflow");
        return -1;
    }else if(front == rear){
        int data = Q[rear];
        front = -1;
        rear = -1;
        printf("\nDeletion Successful");
        return data;
    }
    int data =Q[front];
    front = (++front)%SIZE;
    printf("\nDeletion Successful");
    return data;
}
void display(){
    if(front == -1){
        printf("\nUnderflow");
    }else if(front <= rear){
        printf("\nQueue ->[");
        for(int i=front;i<=rear;i++){
            printf("%d", Q[i]);
            if(i!=rear){
                printf(", ");
            }
        }
        printf("]\n");
    }else{
        printf("\nQueue ->[");
        for(int i=front;i<SIZE;i++){
            printf("%d, ", Q[i]);
        }
        for(int i=0;i<front;i++){
            printf("%d", Q[i]);
            if(i!=front-1){
                printf(", ");
            }
        }
        printf("]\n");
    }
}

int main(){
    printf("Hello world");
    enqueue(10);
    display();
    enqueue(20);
    display();
    enqueue(30);
    display();
    enqueue(40);
    display();
    enqueue(50);
    display();
    enqueue(60);
    display();
    dequeue();
    display();
    dequeue();
    display();
    enqueue(10);
    display();
    enqueue(20);
    display();
    enqueue(30);
    display();
    enqueue(40);
    display();
    enqueue(50);
    display();
    enqueue(60);
    display();
    dequeue();
    display();
    dequeue();
    display();
    dequeue();
    display();
    dequeue();
    display();
    dequeue();
    display();
    dequeue();
    display();
    enqueue(60);
    display();
    return 0;
}