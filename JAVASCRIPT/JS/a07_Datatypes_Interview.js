/*
		Premitives Datatypes:
			String
			Number
			Boolean
			Symbol
			null
			undefined
			BigInt
*/

/*
		Non-Primptive Datatypes:
			Array
			Objects
			Functions
*/

//Symbol
const id = Symbol('1230')
const id1 = Symbol('1230')

console.log(id)
console.log(typeof id)
console.log(id1)
console.log(typeof id1)

//Array
let arr1 = ["Ashish","Suraj","Anish"]

//Objects
let obj = {
	id:101,
	name:"Ashish"
}

//Functions
const hello = Function()
{
	console.log("Hello")
}
hello()
	