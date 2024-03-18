import java.util.Scanner;

class library
{
    String [] books;
    int no_of_books;
    library()
    {
        this.books = new String[100];
        this.no_of_books = 0;
    }
    public void addBook(String book)
    {
        this.books[no_of_books] = book;
        no_of_books++;
        System.out.println(book+" has been added");
    }
    public void issueBook(String book)
    {
        for(int i=0;i<this.books.length;i++)
        {
            if(this.books[i].equalsIgnoreCase(book))
            {
                System.out.println("Book has been issued");
                this.books[i] = null;
                return;
            }
        }
        System.out.println("This book doesn't exists");
    }
    public void returnBook(String book)
    {
        addBook(book);
    }
    public void availableBook()
    {
        System.out.println("Available books are");
        for(String book:this.books)
        {
            if(book == null)
            {
                continue;
            }
            System.out.println("* "+book);
        }
    }

}
public class a111_online_library
{
    public static void main(String[] args)
    {
        //Ypu have to implement a library using java class library;
        //Methods: addBook, issueBook, returnBook, availableBook
        // Properties: Array to store the available books
        library lib = new library();
        lib.addBook("C++");
        lib.availableBook();
        lib.issueBook("c++");
        lib.availableBook();
        lib.returnBook("c++");
        lib.availableBook();



    }
}
