class Base_1
{
    String name;
    int age,id;
    Base_1()
    {
        name="Ashish";
        age=20;
        id=13089;
    }
    Base_1(String name)
    {
        this();
        this.name=name;
    }
    Base_1(String name,int id)
    {
        this(name);
        this.id=id;
    }
    Base_1(String name,int id,int age)
    {
        this(name,id);
        this.age=age;
    }
    void output()
    {
        System.out.println("Name: "+name+"\nId: "+id+"\nAge: "+age);
    }
}
class Derived_1 extends Base_1
{
    int phy,chem,math;
    Derived_1()
    {
        phy=70;
        chem=75;
        math=80;
    }
    Derived_1(int phy)
    {
        this();
        this.phy=phy;
    }
    Derived_1(int phy,int chem)
    {
        this(phy);
        this.chem=chem;
    }
    Derived_1(int phy,int chem,int math)
    {
        this(phy,chem);
        this.math=math;
    }  
    void output()
    {
        super.output();
        System.out.println("Physics: "+phy+"\nChemistry: "+chem+"\nMath: "+math);
    }  
}
class Main
{
    public static void main(String[] args) 
    {
        Base_1 B1 = new Base_1();
        System.out.println("1.");
        B1.output();
        System.out.println("\n\n2.");
        Base_1 B2 = new Base_1("Ashish kumar");
        B2.output();
        System.out.println("\n\n3.");
        Base_1 B3 = new Base_1("Ashish kumar singh",100);
        B3.output();
        System.out.println("\n\n4.");
        Base_1 B4 = new Base_1("Ashish singh",101,20);
        B4.output();
        System.out.println("\n\n");
    
        Derived_1 D1 = new Derived_1();
        System.out.println("1.");
        D1.output();
        System.out.println("\n\n2.");    
        Derived_1 D2 = new Derived_1(90);
        D2.output(); 
        System.out.println("\n\n3.");   
        Derived_1 D3 = new Derived_1(91,92);
        D3.output(); 
        System.out.println("\n\n4.");   
        Derived_1 D4 = new Derived_1(93,94,95);
        D4.output(); 
        System.out.println("\n\n");   
        
    }
}
