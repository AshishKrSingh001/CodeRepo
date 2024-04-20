void main() { 
   var a = null; 
   var b = 12; 
   var res = a ?? b; 
   print(res); 
  
   var a1 = 10; 
   var res1 = a1 > 12 ? "value greater than 10":"value lesser than or equal to 10"; 
   print(res1); 
}