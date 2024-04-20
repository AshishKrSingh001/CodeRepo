class Rectangle {
  int? _length;
  int? _breadth;

  Rectangle(this._length, this._breadth);

//getter
  int? get length => _length;
  int? get breadth => _breadth;


//setters;
  set setLength(int l) => this._length = l;
  set setBreadth(int b) => this._breadth = b;
}

void main() {
  Rectangle rec = Rectangle(10, 20);

  //Getters;
  print(rec.length);
  print(rec.breadth);

  // Setters;
  rec.setLength = 50;
  rec.setBreadth = 40;

  //Getters;
  print(rec.length);
  print(rec.breadth);
}
