console.log(Math)

console.log(Math.abs(4))
console.log(Math.abs(-4))

console.log(Math.round(4.555))
console.log(Math.floor(4.955))
console.log(Math.ceil(4.155))


console.log(Math.min(1,2,3,4,5,6,9,8,7))


console.log(Math.max(1,2,3,4,5,6,9,8,7))

console.log(Math.round(Math.random()*10))


const min = 5
const max = 9

let value
let rvalue = Math.random
value = (rvalue > min && rvalue < max)? rvalue:(min > rvalue)?max:min
console.log(value)