import numpy as np
import pandas as pd

arr = np.array([[1, 2, 3], [4, 5, 6]])
row_sum = arr.sum(axis=1)
col_sum = arr.sum(axis=0)
print("Row sum:", row_sum)
print("Col sum:", col_sum)

df = pd.DataFrame(arr, columns=['A','B','C'])
df_norm = (df - df.min()) / (df.max() - df.min())
print(df_norm)
