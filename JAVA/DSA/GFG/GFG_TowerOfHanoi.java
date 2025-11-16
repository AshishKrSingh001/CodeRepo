public class GFG_TowerOfHanoi 
{
    public long toh(int n, int from, int to, int aux) 
    {
        return 0;
    }
    public void towerOfHanoi(int n, int from, int to, int aux, long[]moves)
    {
        if(n==0)
        {
            return;
        }
        moves[0]++;

        towerOfHanoi(n-1, from, aux, to, moves);

        System.out.println("move disk "+n+" from rod "+from+" to rod "+to);
        
        towerOfHanoi(n-1, aux, to, from, moves);
    }
}
