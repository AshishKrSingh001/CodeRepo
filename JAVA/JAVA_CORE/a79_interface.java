class student {
	int roll;
	void getroll(int n) {
		roll=n;
	}
	void putroll() {
		System.out.println("Roll="+roll);
	}

}
class test extends student{ 
	float mark1,mark2;
	void getmarks(float m1,float m2) {
		mark1=m1;
		mark2=m2;
	}void putmarks(){
		System.out.println("Marks1="+mark1+"\nMarks2="+mark2);
				
	}
}
interface sports{
	float sportsmark=60.0f;
	void putsports();
}
class result extends test implements sports{
	float total;
	public void putsports() {
		System.out.println("Sportsmarks="+sportsmark);
	}
	void display() {
		total=mark1+mark2+sportsmark;
		putroll();
		putsports();
		System.out.println("Total marks="+total);
	}
	public static void main(String[] args) {
		result aa=new result();
		aa.getroll(17);
		aa.getmarks(41.3f, 23.6f);
		aa.display();
		
	}
}