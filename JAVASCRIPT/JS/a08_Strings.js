const name = "Ashish"
const repCount = 50

//console.log(name + repCount + "Value")

console.log(typeof(name))

console.log("Hello")
//console.log("${name} is my name and count of repo is ${repCount}")

console.log("length : " + name.length)
console.log("name[0] : " + name[0])
console.log("name.toUpperCase() : "+ name.toUpperCase())
console.log("name.toLowerCase() : "+ name.toLowerCase())
console.log("name.charAt(0) : "+ name.charAt(0))
console.log("name.indexOf('h') : "+ name.indexOf('h'))

const newName = name.substring(0,3)
console.log("name.subString(0,3) : "+ newName)

let str = "   aks   "
console.log(str)
console.log("str.trim() : "+ str.trim())

const anotherName = name.slice(0,3)
console.log("name.slice(0,3) : "+ anotherName)

const url = "https://ashish.com/ashis/20kumar/20singh"
console.log("url : " + url)

const newurl = url.replace('%20','_')
console.log("url.replace('%20','_') : " + newurl)

console.log("url.includes('ashish'): " + url.includes('ashish'))
console.log("url.includes('ashishh'): " + url.includes('ashishh'))

console.log("url.split('/')" + url.split('/'))
console.log(url[0])