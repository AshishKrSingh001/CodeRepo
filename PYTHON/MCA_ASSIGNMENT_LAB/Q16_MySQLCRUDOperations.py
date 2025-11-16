import mysql.connector

conn = mysql.connector.connect(host="localhost", user="root", password="yourpassword", database="testdb")
cur = conn.cursor()

cur.execute("CREATE TABLE IF NOT EXISTS students (roll INT PRIMARY KEY, name VARCHAR(50), marks INT)")

# Insert multiple
cur.executemany("INSERT INTO students VALUES (%s, %s, %s)", [(1, "Ashish", 90), (2, "John", 85)])
conn.commit()

# Display
cur.execute("SELECT * FROM students")
for r in cur.fetchall():
    print(r)

# Update
cur.execute("UPDATE students SET marks=95 WHERE roll=1")
conn.commit()

# Delete
cur.execute("DELETE FROM students WHERE roll=2")
conn.commit()

# Search
cur.execute("SELECT * FROM students WHERE roll=1")
print("Search:", cur.fetchone())

conn.close()
