class Employee
{
    private int empId;
    private String eName,address,phoneNo,emailId;
    Employee(String name,int id)
    {
        this.eName = name;
        this.empId = id;
    }
    public void setAddress(String add)
    {
        this.address = add;
    }
    public void setPhoneNumber(String no)
    {
        this.phoneNo = no;
    }
    public void setEmail(String email)
    {
        this.emailId = email;
    }
	public void Display()
	{
		System.out.printf("Employee ID: %d\nEmployee Name: %s\nAddress: %s\nPhone Number: %s\nEmail ID: %s\n",empId,eName,address,phoneNo,emailId);
	}

}
class Customer
{
    private String cName,AccNo,address,phoneNo,emailId;
    Customer(String name,String a_cc)
    {
        this.AccNo = a_cc;
        this.cName = name;
    }
    public void setAddress(String add)
    {
        this.address = add;
    }
    public void setPhoneNumber(String no)
    {
        this.phoneNo = no;
    }
    public void setEmail(String email)
    {
        this.emailId = email;
    }
	public void Display()
	{
		System.out.printf("Customer Name: %s\nCustomer ID: %s\nAddress: %s\nPhone Number: %s\nEmail ID: %s\n",cName,AccNo,address,phoneNo,emailId);
	}
}
class ServeYourMoney
{
    private int bankId;
    ServeYourMoney(int bankId)
    {
        this.bankId = bankId;
    }
	public void Display()
	{
		System.out.println("Bank ID: "+bankId);
	}
    
}

public class ExerciseFour
{
    public static void main(String[] args) 
    {
        ServeYourMoney sym = new ServeYourMoney(101);
		sym.Display();
		
        Employee e1 = new Employee("Ashish", 13089);
        e1.setAddress("Kurji, Patna");
        e1.setEmail("Ashish@gamil.com");
        e1.setPhoneNumber("1234567899");
		e1.Display();
		
		Customer cus = new Customer("Shiv","123456789");
		cus.setAddress("Kurji, Patna");
        cus.setEmail("Ashish@gamil.com");
        cus.setPhoneNumber("1234567899");
		cus.Display();
        
    }
}
