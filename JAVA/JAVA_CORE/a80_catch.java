import java.util.Scanner;
class AgeException extends Exception{
	AgeException(String msg){
		super(msg);//calling a constructor of super class.
	}

}
class people{
	int age;
	Scanner ds=new Scanner(System.in);
	void getInput()throws AgeException{
		System.out.println("put age of person=");
		age=ds.nextInt();
	    if(age<18) {
			AgeException e=new AgeException("Not eligible to vote");
			throw e;//throw new IllegalAgeException("not eligible to vote);
			
	    }
	}

    void validateAge() {
		if(age>18)
			System.out.println("eligible to vote");
    }
    public static void main(String args[]) {
		people obj=new people();
		try {
			obj.getInput();
			obj.validateAge();
		}
        catch(AgeException e) {
			System.out.println(e);
		}
		
	    
    }
		
}