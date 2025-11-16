import java.util.ArrayList;
import java.util.List;
class Graph{
    class Pair{
        int node;
        int weight;
        public Pair(int node, int weight){
            this.node = node;
            this.weight = weight;
        }
        public String toString(){
            return "("+node +"->"+ weight+")";
        }
    }
    int adjMatrix[][];
    List<List<Integer>>adjList;
    List<List<Pair>>adjListWeighted;
    public Graph(int nodes){
        adjMatrix = new int[nodes][nodes];
        adjList = new ArrayList<>();
        adjListWeighted = new ArrayList<>();
        for(int i=0;i<nodes;i++){
            adjList.add(new ArrayList<>());
            adjListWeighted.add(new ArrayList<>());
        }
    }
    public void addElementInList(int edges[][], boolean isDirected){
        for(int edge[]: edges){
            int u = edge[0];
            int v = edge[1];
            if(!isDirected){
                adjList.get(v).add(u);
            }
            adjList.get(u).add(v);
        }
    }
    public void addElementInMatrix(int edges[][], boolean isDirected){
        for(int edge[]: edges){
            int u = edge[0];
            int v = edge[1];
            if(!isDirected){
                adjMatrix[v][u] = 1;
            }
            adjMatrix[u][v] = 1;
        }
    }
    public void addElementInListInWeighted(int edges[][], boolean isDirected){
        for(int edge[]: edges){
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            if(!isDirected){
                adjListWeighted.get(v).add(new Pair(u, w));
            }
            adjListWeighted.get(u).add(new Pair(v, w));
        }
    }
    
    public void addElementInMatrixInWeighted(int edges[][], boolean isDirected){
        for(int edge[]: edges){
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            if(!isDirected){
                adjMatrix[v][u] = w;
            }
            adjMatrix[u][v] = w;
        }
    }
    public void printMatrix(){
        System.out.println("Adjancecy Matrix: ");
        for(int row[]: adjMatrix){
            for(int col: row){
                System.out.print(col +" ");
            }System.out.println("");
        }
    }
    public void printList(){
        System.out.println("Adjancecy List: "+adjList);
        System.out.println("Adjancecy List Weighted: "+adjListWeighted);
    }
}
public class MatrixRepresentationOfGraphExample{
    public static int[] countDegree(int edges[][], int nodes){
        int degrees[] = new int[nodes];
        for(int edge[]: edges){
            int u = edge[0];
            int v = edge[1];
            degrees[u]++;
            degrees[v]++;
        }
        return degrees;
    }
    public static void main(String[] args) 
    {
        /*
        // UnWeighted
        int edges1[][] = {{0, 1}, {0, 2}, {1, 3}};
        // Directed Graph
        Graph graph2 = new Graph(4);
        graph2.addElementInMatrix(edges1, true);
        graph2.printMatrix();
        graph2.addElementInList(edges1, true);
        graph2.printList();
        // Undirected Graph
        System.out.println("\n");
        Graph graph1 = new Graph(4);
        graph1.addElementInMatrix(edges1, false);
        graph1.printMatrix();
        graph1.addElementInList(edges1, false);
        graph1.printList();
        */

        // Weighted
        int edges[][] = {{0, 1, 10}, {0, 2, 20}, {1, 3, 18}};
        // Directed Graph
        Graph graph3 = new Graph(4);
        graph3.addElementInMatrixInWeighted(edges, true);
        graph3.addElementInList(edges, true);
        graph3.addElementInListInWeighted(edges, true);
        graph3.printMatrix();
        graph3.printList();
        // Undirected Graph
        System.out.println("\n");
        Graph graph4 = new Graph(4);
        graph4.addElementInMatrixInWeighted(edges, false);
        graph4.addElementInList(edges, false);
        graph4.addElementInListInWeighted(edges, false);
        graph4.printMatrix();
        graph4.printList();        
        
        int degrees[] = countDegree(edges, 4);
        for(int i=0;i<degrees.length;i++){
            System.out.print(i +"->"+degrees[i]);
            if(i!=degrees.length-1){
                System.out.print(", ");
            }
        }System.out.println("");
    }
}
