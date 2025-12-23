A = [
    [1, 2],
    [3, 5],
]
B = [
    [1, 5],
    [5, 7],
]
C = [
    [0, 0],
    [0, 0],
    ]

for i in range(len(A)):
    for j in range(len(B[0])):
        C[i][j] = 0
        for k in range(len(B)):
            C[i][j] += A[i][k] * B[k][j]

print(C)