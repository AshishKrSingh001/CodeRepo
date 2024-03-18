class Books
{
int page_num;
String authorname, name; float price;
public Books()
{
page_num = 50;
authorname = "Andrew Jones";
name = "The Living Ideas";
price = 15.78f;
}
public void displayInfo()
{
System.out.println("The name of the book is:\t" + name);
System.out.println("The price of the book is:\t" + price);
System.out.println("The author name is:\t\t" + authorname);
System.out.println("The total number of pages is:\t" + page_num);
}
}
class PaperBooks extends Books
{
int shippingcharges = 10;
public void printInfo()
{
displayInfo();//Calling the method of Book class.
System.out.println("The total shipping charges are:\t" +
shippingcharges);
}
public static void main(String[] args)
{
PaperBooks pb = new PaperBooks();
pb.printInfo();
//
}
} // End of class