// Online Java Compiler
// Use this editor to write, compile and run your Java code online

class PrintAllSubsequencesOfString
{
    public static void main(String[] args) 
    {
        String inp = "ABCD";
        String out = "";
        printAllSubsequencesOfString(inp, 0, inp.length(),out);
    }
    public static void printAllSubsequencesOfString(String s, int index, int n,String res)
    {
        if(index == n)
        {
            System.out.println(res);
            return;
        }
        printAllSubsequencesOfString(s, index+1, s.length(),res+s.charAt(index));
        printAllSubsequencesOfString(s, index+1, s.length(),res);
    }
}