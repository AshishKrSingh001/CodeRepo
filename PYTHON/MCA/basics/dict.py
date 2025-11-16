dict = {
    "Name":"Ashish",
    "Age":50,
    "City":"Kishanganj",
    "Marks":{"python":99, "C":89},
    (1,2,3):"tuple"
}
print(dict)
print(dict['Name'])
dict['Class']='MCA'

print(dict)

dict['Marks']['Java']=88
print(dict)
print(dict[(1,2,3)])
print(dict.keys())
print(dict.values())
print(dict["Marks"].keys())
print(dict["Marks"].values())
print(dict.items())
print(dict["Marks"].items())
print(dict.get("Name"))
print(dict.get((1,2,3)))