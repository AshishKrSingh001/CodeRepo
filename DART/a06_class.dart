class Circle
{
  double? radius;

  Circle(this.radius);
  
  void perimeter()
  {
    print('Perimeter of a Circle ${2*radius*3.14}');
  }
  void area()
  {
    print('Area of a Circle: ${3.14*radius*radius}');
  }
}
void main()
{
  print('hello');
  
  Circle cir = Circle();
  print('Radius of a CIrcle: ${cir.radius}');
  cir.area();
  cir.perimeter();
}