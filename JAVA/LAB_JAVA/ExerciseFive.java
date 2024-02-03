class Grocery
{
    private int weight;
    public void WeightNow(int weight)
    {
        this.weight = weight;
    }
    public void checkWeight()
    {
        System.out.println("Weight: "+weight);
    }
    public static void main(String[] args) 
    {
        Grocery G = new Grocery();
        G.WeightNow(45);
        G.checkWeight();
    }
}
