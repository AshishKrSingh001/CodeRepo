class SampleClass 
{
    private int counter = 10;
    public void display()
    {
        System.out.println("Value of counter: "+counter);
    }
    public static void main(String[] args) 
    {
        SampleClass obj = new SampleClass();
        obj.display();
    }
    
}
