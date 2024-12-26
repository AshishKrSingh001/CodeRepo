import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Queue;
public class GraphTraversal 
{   
    public static void main(String[] args) 
    {
        ArrayList<ArrayList<Integer>>list = new ArrayList<>();
        for(int i=0;i<9;i++){
            list.add(new ArrayList<>());
        }
        list.get(0).add(2);list.get(0).add(6);list.get(0).add(7);
        list.get(1).add(2);list.get(1).add(4);list.get(1).add(8);
        list.get(2).add(0);list.get(2).add(1);list.get(2).add(3);
        list.get(3).add(2);
        list.get(4).add(1);
        list.get(5).add(7);
        list.get(6).add(0);
        list.get(7).add(0);list.get(7).add(5);
        list.get(8).add(1);

        ArrayList<Integer>res = new ArrayList<>();
        // graphTraversalUsingDFS(list, res);
        graphTraversalUsingBFS(list, res);
        System.out.println(res);
    }
    public static void graphTraversalUsingBFS(ArrayList<ArrayList<Integer>>list, ArrayList<Integer>res){
        boolean visitedArray[] = new boolean[list.size()];
        Queue<Integer>queue = new LinkedList<>();
        visitedArray[0] = true;
        queue.offer(0);
        while(!queue.isEmpty()){
            int node = queue.poll();
            res.add(node);
            for(int neighbour : list.get(node)){
                if(!visitedArray[neighbour]){
                    visitedArray[neighbour] = true;
                    queue.add(neighbour);
                }
            }
        }
    }
    public static void graphTraversalUsingDFS(ArrayList<ArrayList<Integer>>list, ArrayList<Integer>res){
        boolean visitedArray[] = new boolean[list.size()];
        for(int i=0;i<visitedArray.length;i++){
            if(!visitedArray[0]){
                dfs(i, visitedArray, list, res);
            }
        }
    }
    public static void dfs(int node, boolean[]visitedArray,ArrayList<ArrayList<Integer>>list, ArrayList<Integer>res){
        visitedArray[node] = true;
        res.add(node);
        for(int neighbour: list.get(node)){
            if(!visitedArray[neighbour]){
                dfs(neighbour, visitedArray, list, res);
            }
        }
    }
}
