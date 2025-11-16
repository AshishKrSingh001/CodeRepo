import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;
import java.util.Queue;
import java.util.Stack;
import java.util.TreeMap;
public class BinaryTreeExample 
{
    public static class Node{
        int data;
        Node left, right;
        public Node(int data){
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
    public static void main(String[] args) {
        int preorder[] = {1, 2, 4, 5, 3, 6};
        int inorder[] = {4, 2, 5, 1, 3, 6};
        int postorder[] = {4, 5, 2, 6, 3, 1};
        HashMap<Integer, Integer>map = new HashMap<>();
        for(int i=0;i<inorder.length;i++){
            map.put(inorder[i], i);
        }
        // Node root = constructTreeUsingPreorderInorder(preorder, 0, preorder.length-1, inorder, 0, inorder.length-1, map);
        Node root = contructTreeUsingInorderPostorder(inorder, 0, inorder.length-1, postorder, 0, postorder.length-1, map);
        ArrayList<Integer>list = new ArrayList<>();
        // preorderTraversalIterative(root, list);
        // System.out.println("Preorder Traversal:->"+list);
        // list = new ArrayList<>();
        // postorderTraversalIterative(root, list);
        // System.out.println("Postorder Traversal:->"+list);
        // list = new ArrayList<>();
        // inorderTraversalIterative(root, list);
        // System.out.println("Inorder Traversal:->"+list);
        // list = new ArrayList<>();
        levelorderTraversalIterative(root, list);
        System.out.println("Level-Order Traversal:->"+list);

        // preorderTraversalRecurr(root, list);
        // System.out.println("Preorder Traversal:->"+list);
        // list = new ArrayList<>();
        // postorderTraversalRecurr(root, list);
        // System.out.println("Postorder Traversal:->"+list);
        // list = new ArrayList<>();
        // inorderTraversalRecurr(root, list);
        // System.out.println("Inorder Traversal:->"+list);

        // list = new ArrayList<>();
        // printLeftViewOfTree(root, list);
        // System.out.println("Left View:->"+list);
        // list = new ArrayList<>();
        // printRightViewOfTree(root, list);
        // System.out.println("Right View:->"+list);
        // list = new ArrayList<>();
        // printTopViewOfTree(root, list);
        // System.out.println("Top View:->"+list);
        // list = new ArrayList<>();
        // printBottomViewOfTree(root, list);
        // System.out.println("Bottom View:->"+list);

        // System.out.println(heightOfTreeUsingBFS(root));
        // System.out.println(heightOfTreeUsingDFS(root));
        // int diameter[] = new int[1];
        // diameterOfTree(root, diameter);
        // System.out.println(diameter[0]);
        // System.out.println(countNoOfNodes(root));
        // System.out.println(sumOfNodesValues(root));
        // System.out.println(isCousinNode(root, 5, 6));

        list = new ArrayList<>();
        printZigZackViewTraversal(root, list);
        System.out.println("ZigZack View:->"+list);
    }
    public static void printZigZackViewTraversal(Node root, ArrayList<Integer>list){
        if(root==null){
            return;
        }
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        int height = 1;
        Stack<Integer>stack;
        while(!queue.isEmpty()){
            int size = queue.size();
            stack = new Stack<>();
            while(size>0){
                size--;
                Node node = queue.poll();
                if(height%2 == 0){
                    stack.push(node.data);
                }else{
                    list.add(node.data);
                }
                if(node.left!=null){
                    queue.offer(node.left);
                }if(node.right!=null){
                    queue.offer(node.right);
                }
            }
            if(!queue.isEmpty()){
                height++;
            }
            while(!stack.isEmpty()){
                list.add(stack.pop());
            }
        }
    }
    public static void printTopViewOfTree(Node root, ArrayList<Integer>list){
        if(root==null){
            return;
        }
        class CustomNode{
            Node node;
            int col;
            public CustomNode(Node node, int col){
                this.node = node;
                this.col = col;
            }
        }
        TreeMap<Integer, Integer>tmap = new TreeMap<>();
        Queue<CustomNode>queue = new LinkedList<>();
        queue.offer(new CustomNode(root, 0));
        while(!queue.isEmpty()){
            CustomNode custNode = queue.poll();
            Node node = custNode.node;
            int col = custNode.col;
            if(!tmap.containsKey(col)){
                tmap.put(col, node.data);
            }
            if(node.left!=null){
                queue.offer(new CustomNode(node.left, col-1));
            }if(node.right!=null){
                queue.offer(new CustomNode(node.right, col+1));
            }
        }
        for(Map.Entry<Integer, Integer>entry:tmap.entrySet()){
            list.add(entry.getValue());
        }

    }
    public static void printBottomViewOfTree(Node root, ArrayList<Integer>list){
        if(root==null){
            return;
        }
        class CustomNode{
            Node node;
            int col;
            public CustomNode(Node node, int col){
                this.node = node;
                this.col = col;
            }
        }
        TreeMap<Integer, Integer>tmap = new TreeMap<>();
        Queue<CustomNode>queue = new LinkedList<>();
        queue.offer(new CustomNode(root, 0));
        while(!queue.isEmpty()){
            CustomNode custNode = queue.poll();
            Node node = custNode.node;
            int col = custNode.col;
            tmap.put(col, node.data);
            if(node.left!=null){
                queue.offer(new CustomNode(node.left, col-1));
            }if(node.right!=null){
                queue.offer(new CustomNode(node.right, col+1));
            }
        }
        for(Map.Entry<Integer, Integer>entry:tmap.entrySet()){
            list.add(entry.getValue());
        }

    }
    public static void printLeftViewOfTree(Node root, ArrayList<Integer>list){
        if(root==null){
            return;
        }
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        while(!queue.isEmpty()){
            int size = queue.size();
            boolean flag = false;
            while(size>0){
                size--;
                Node node = queue.poll();
                if(!flag){
                    list.add(node.data);
                    flag = true;
                }
                if(node.left!=null){
                    queue.offer(node.left);
                }if(node.right!=null){
                    queue.offer(node.right);
                }
            }
        }

    }
    public static void printRightViewOfTree(Node root, ArrayList<Integer>list){
        if(root==null){
            return;
        }
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        while(!queue.isEmpty()){
            int size = queue.size();
            Node node = null;
            while(size>0){
                size--;
                node = queue.poll();
                if(node.left!=null){
                    queue.offer(node.left);
                }if(node.right!=null){
                    queue.offer(node.right);
                }
            }
            list.add(node.data);
        }

    }
    public static boolean isCousinNode(Node root, int X, int Y){
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        int isChildFound = 0;
        while(!queue.isEmpty()){
            int size = queue.size();
            while(size>0){
                size--;
                int isParentFound = 0;
                Node node = queue.poll();
                if(node.left!=null){
                    if(node.left.data == X || node.left.data == Y){
                        isChildFound++;
                        isParentFound++;
                    }
                    queue.offer(node.left);
                }
                if(node.right!=null){
                    if(node.right.data == X || node.right.data == Y){
                        isChildFound++;
                        isParentFound++;
                    }
                    queue.offer(node.right);
                }
                if(isParentFound == 2){return false;}
            }
            if(isChildFound == 2){return true;}
            if(isChildFound == 1){return false;}
        }
        return false;
    }
    public static int sumOfNodesValues(Node root){
        if(root==null){
            return 0;
        }
        return(root.data + sumOfNodesValues(root.left) + sumOfNodesValues(root.right));
    }
    public static int countNoOfNodes(Node root){
        if(root==null){
            return 0;
        }
        return(1 + countNoOfNodes(root.left) + countNoOfNodes(root.right));
    }
    public static int diameterOfTree(Node root, int[]max){
        if(root==null){
            return 0;
        }
        int left = diameterOfTree(root.left, max);
        int right = diameterOfTree(root.right, max);
        max[0] = Math.max(max[0],left+right);
        return 1+Math.max(left, right);
    }
    public static int heightOfTreeUsingDFS(Node root){
        if(root==null){
            return 0;
        }
        int left = heightOfTreeUsingBFS(root.left);
        int right = heightOfTreeUsingBFS(root.right);
        return 1+Math.max(left, right);
    }
    public static int heightOfTreeUsingBFS(Node root){
        int level = 0;
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        while(!queue.isEmpty()){
            int size = queue.size();
            while(size>0){
                Node node = queue.poll();
                size--;
                if(node.left!=null){
                    queue.offer(node.left);
                }if(node.right!=null){
                    queue.offer(node.right);
                }
            }if(!queue.isEmpty()){
                level++;
            }
        }
        return level+1;
    }
    public static Node contructTreeUsingInorderPostorder(int in[], int inStart, int inEnd, int post[], int postStart, int postEnd, HashMap<Integer, Integer>map){
        if(inEnd<inStart || postEnd<postStart){
            return null;
        }
        int rootData = post[postEnd];
        int rootIndex = map.get(rootData);
        Node root = new Node(rootData);
        int leftTreeSize = rootIndex - inStart;
        int rightTreeSize = inEnd - rootIndex;
        root.left = contructTreeUsingInorderPostorder(in, inStart, rootIndex-1, post, postStart, postStart+leftTreeSize-1, map);
        root.right = contructTreeUsingInorderPostorder(in, rootIndex+1, inEnd, post, postStart+leftTreeSize, postStart+leftTreeSize+rightTreeSize-1, map);
        return root;
    }
    public static Node constructTreeUsingPreorderInorder(int pre[], int preStart, int preEnd, int in[], int inStart, int inEnd, HashMap<Integer, Integer>map){
        if(preEnd<preStart || inEnd<inStart){
            return null;
        }
        int rootData = pre[preStart];
        int rootIndex = map.get(rootData);
        Node root = new Node(rootData);
        int leftTreeSize = rootIndex - inStart;
        int rightTreeSize = inEnd - rootIndex;
        root.left = constructTreeUsingPreorderInorder(pre, preStart+1, preEnd+leftTreeSize, in, inStart, rootIndex-1, map);
        root.right = constructTreeUsingPreorderInorder(pre, preStart+leftTreeSize+1, preStart+leftTreeSize+rightTreeSize, in, rootIndex+1, inEnd, map);
        return root;
    }
    public static void preorderTraversalRecurr(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        list.add(root.data);
        preorderTraversalRecurr(root.left, list);
        preorderTraversalRecurr(root.right, list);
    }
    public static void postorderTraversalRecurr(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        postorderTraversalRecurr(root.left, list);
        postorderTraversalRecurr(root.right, list);
        list.add(root.data);
    }
    public static void inorderTraversalRecurr(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        inorderTraversalRecurr(root.left, list);
        list.add(root.data);
        inorderTraversalRecurr(root.right, list);
    }
    public static void preorderTraversalIterative(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack();
        stack.push(root);
        while(!stack.isEmpty()){
            Node node = stack.pop();
            list.add(node.data);
            if(node.right!=null){
                stack.push(node.right);
            }if(node.left!=null){
                stack.push(node.left);
            }
        }
    }
    public static void postorderTraversalIterative(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack();
        Node node = root;
        while(node!=null || !stack.isEmpty()){
            while(node!=null){
                stack.push(node);
                node = node.left;
            }
            if(stack.peek().right != null){
                node = stack.peek().right;
            }else{
                Node tempNode = stack.pop();
                list.add(tempNode.data);
                while(!stack.isEmpty() && stack.peek().right==tempNode){
                    tempNode = stack.pop();
                    list.add(tempNode.data);
                }
            }
        }
    }
    public static void inorderTraversalIterative(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack();
        Node node = root;
        while(node!=null || !stack.isEmpty()){
            while(node!=null){
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            list.add(node.data);
            node = node.right;
        }
    }
    public static void levelorderTraversalIterative(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        while(!queue.isEmpty()){
            Node node = queue.poll();
            list.add(node.data);
            if(node.left!=null){
                queue.offer(node.left);
            }if(node.right!=null){
                queue.offer(node.right);
            }
        }
    }
}
