
import java.util.HashMap;
import java.util.Objects;


class MyCollege{
    int regNo;
    private int hashCode;
    MyCollege(int regNo){
        this.regNo = regNo;
        this.hashCode = Objects.hashCode(regNo);
    }

    @Override
    public int hashCode() {
        return hashCode;
    }

    @Override
    public boolean equals(Object obj) {
        MyCollege college = (MyCollege) obj;
        return this.regNo == college.regNo;
    }
}

class MyRanking{
    int rank;
    MyRanking(int rank){
        this.rank = rank;
    }

    @Override
    public String toString() {
        return ""+this.rank;
    }

    @Override
    public boolean equals(Object obj) {
        MyRanking r = (MyRanking) obj;
        return this.rank == r.rank;
    }
}
public class HashMap_CustomClass 
{
    public static void main(String[] args) 
    {
        HashMap<MyCollege,MyRanking> collegeRankingMap2 = new HashMap<>();
        collegeRankingMap2.put(new MyCollege(111),new MyRanking(1));
        collegeRankingMap2.put(new MyCollege(312),new MyRanking(2));
        collegeRankingMap2.put(new MyCollege(457),new MyRanking(3));
        System.out.println(collegeRankingMap2.get(new MyCollege(111)));
        System.out.println(collegeRankingMap2.containsValue(new MyRanking(1)));
    }    
}
