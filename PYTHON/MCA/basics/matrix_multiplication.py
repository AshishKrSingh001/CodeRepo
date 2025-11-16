# list1 = [[1, 2, 3], [4, 5, 6]]
# list2 = [[1, 2], [4, 5], [7, 8]]
list1 = []
list2 = []
arow = int(input("Enter the row of matrix 1"))
acol = int(input("Enter the col of matrix 1"))
brow = int(input("Enter the row of matrix 2"))
bcol = int(input("Enter the col of matrix 2"))
print("Enter element for matrix1")
for i in range(arow):
    list=[]
    for j in range(acol):
        list.append(int(input()))
    list1.append(list)
print("Enter element for matrix2")
for i in range(brow):
    list=[]
    for j in range(bcol):
        list.append(int(input()))
    list2.append(list)
res =[]
for i in range(len(list1)):
    list = []
    for j in range(len(list2[0])):
        list.append(0)
    res.append(list)
for i in range(len(list1)):
    for j in range(len(list2[0])):
        res[i][j] = 0
        for k in range(len(list2)):
            res[i][j]+=list1[i][k]*list2[k][j]
print(res)
