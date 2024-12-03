
import java.util.ArrayList;
import java.util.List;

public class LC118_PascalsTrangle 
{
    public static void main(String[] args){
        List<List<Integer>>trangle = generate(5);
        for(List<Integer>list:trangle)
        {
            System.out.println(list);
        }
    }
    public static List<List<Integer>>generate(int numRows){
        List<List<Integer>>trangle = new ArrayList<>();

        List<Integer>firstRow = new ArrayList<>();
        firstRow.add(1);
        trangle.add(firstRow);
        for(int i=1;i<numRows;i++){
            List<Integer>prevRow = trangle.get(i-1);
            List<Integer>currentRow = new ArrayList<>();

            currentRow.add(1);
            for(int j=1;j<i;j++){
                currentRow.add(prevRow.get(j-1)+prevRow.get(j));
            }
            currentRow.add(1);
            trangle.add(currentRow);
        }
        return trangle;
    }    
}
