dict1 = {
    "name":"Ashish Kumar Singh",
    "id":13089,
    "roll_no":33,
    "fees":347000.0
}
print(dict1)
print(type(dict1))
print(len(dict1))

print("Name:\t",dict1["name"])
print("Id:\t",dict1["id"])
print("Roll no:",dict1["roll_no"])
print("Fees:\t",dict1["fees"])

print("*******************")
print("Name:\t",dict1.get("name"))
print("Id:\t",dict1.get("id"))
print("Roll no:",dict1.get("roll_no"))
print("Fees:\t",dict1.get("fees"))

x = dict1.keys()
print(x)

y = dict1.values()
print(y)

z = dict1.items()
print(z)

dict1.update({"id":222})
print(dict1)

dict1["salary"] = 0
print(dict1)

dict1.pop("salary")
print(dict1)

dict1.popitem()
print(dict1)
#dict1.clear()
print(dict1)
dict2 = dict1
print(dict2)
dict3 = dict1.copy()
print(dict3)