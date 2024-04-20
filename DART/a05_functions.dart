void main()
{
  final name = printStuff();
  print(disp());
  print(disp().$1);
  print(disp().$2);
  
  print(disp1().age);
}

void printStuff() => print('hi');

(int ,String) disp()
{
  return(10,'Ashish');
}

({int age ,String name}) disp1()
{
  return(age:10,name:'Ashish');
}