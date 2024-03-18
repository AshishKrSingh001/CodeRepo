interface camera
{
    void takesnap();
    void recordVideo();
    default void record4kvideo()
    {
        greet();
        System.out.println("Recording in 4K");
    }
    private void greet()
    {
        System.out.println("Good morning");
    }
}
interface wifi
{
    String[] getNetwork();
    void connectionOfNetwork(String n);
}
class myCellPhone
{
    void calling(int ph_number)
    {
        System.out.println("Calling "+ph_number);
    }
    void picking_call(int ph_number)
    {
        System.out.println("picking call of "+ph_number);
    }
    void viewcall()
    {
        System.out.println("connecting...");
    }
}
class mySmartPhone extends myCellPhone implements wifi,camera
{
     public void takesnap()
    {
        System.out.println("Taking snap");
    }
    public void recordVideo()
    {
        System.out.println("Recording video");
    }
    public String[] getNetwork()
    {
        System.out.println("Getting network");
        String[] list = {"Airtel","jio","VI"};
        return list;
    }
    public void connectionOfNetwork(String n)
    {
        System.out.println("Connecting to "+n);
    }
    public void record4kvideo()//This will override default method
    {
        System.out.println("Recording in 4K overriding");
    }
}
public class a123_default_methods
{
    public static void main(String[] args)
    {
        mySmartPhone ms = new mySmartPhone();
        String[] arr = ms.getNetwork();
        for(String element:arr)
        {
            System.out.println(element);
        }
        ms.connectionOfNetwork("Airtel");
        ms.record4kvideo();
        ms.takesnap();
        ms.calling(11111);
    }
}
