
import java.io.*;
class ArrayException
{private int i,j,temp;        
	public void Sorting(int a[],int size)
	{
            for(i=0;i<size-1;i++)
		    {
			    for(j=i+1;j<size;j++)
			    {
				    if(a[i]>a[j])
				    {
					    temp = a[i];
					    a[i] = a[j];
					    a[j] = temp;
				    }
                    }
            }
	}
	public void Display(int a[],int size)
	{
            System.out.println("\nArray Element:");
            for(int element:a)
            {
                System.out.printf("%d\t",element);
            }
            System.out.printf("\n");
    }
	
    
}

 public class a142_Exception2 
{
    
    static public void main(String []args)
	{
        int size,i,j;
        
        try 
        {
            DataInputStream ds = new DataInputStream(System.in);
            System.out.println("Enter Size of an Array:");
            size = Integer.parseInt(ds.readLine());
            int a[] = new int[size];
            System.out.printf("Enter %d Array element:\n",size);
            for(i=0;i<size;i++)
            {
                a[i] = Integer.parseInt(ds.readLine());
            }
            ArrayException obj = new ArrayException();
		    obj.Display(a,size);
		    obj.Sorting(a,size);
		    obj.Display(a,size);
        }
        catch(NumberFormatException n)
        {
            System.out.println("Invalid input "+n);
        }
        catch(ArrayIndexOutOfBoundsException e)
        {
            System.out.println("Check Index of array element "+ e);
        }
        catch(NegativeArraySizeException n)
        {
            System.out.println("Negative Array size "+n);
        }
        catch (IOException e) 
        {
            System.out.println(e);
        }
        catch(Exception e)
        {}
        finally
	    {
		    System.out.println("Thanks");
	    }
		
	}
}
