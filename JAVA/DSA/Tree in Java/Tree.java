import java.util.ArrayList;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.List;
import java.util.Map;
import java.util.Queue;
import java.util.Stack;
import java.util.TreeMap;
public class Tree 
{
    public static class Node{
        Node left, right;
        int data;
        public Node(int data){
            this.data = data;
        }
    }
    public static Node constructTreeUsingPreoderAndInorder(int preorder[], int preStart, int preEnd, int inorder[], int inStart, int inEnd, HashMap<Integer, Integer>map){
        if(preEnd<preStart || inEnd<inStart){
            return null;
        }
        int rootData = preorder[preStart];
        int rootIndex = map.get(rootData);
        Node root = new Node(rootData);
        int leftTreeSize = rootIndex - inStart;
        int rightTreeSize = inEnd - rootIndex;
        root.left = constructTreeUsingPreoderAndInorder(preorder, preStart+1, preStart+leftTreeSize, inorder, inStart, rootIndex-1, map);
        root.right = constructTreeUsingPreoderAndInorder(preorder, preStart+leftTreeSize+1, preStart+leftTreeSize+rightTreeSize, inorder, rootIndex+1, inEnd, map);
        return root;
    }
    public static Node constructTreeUsingInorderAndPostorder(int inorder[], int inStart, int inEnd, int postorder[], int postStart, int postEnd, HashMap<Integer, Integer>map){
        if(postEnd<postStart || inEnd<inStart){
            return null;
        }
        int rootData = postorder[postEnd];
        int rootIndex = map.get(rootData);
        Node root = new Node(rootData);
        int leftTreeSize = rootIndex - inStart;
        int rightTreeSize = inEnd - rootIndex;
        root.left = constructTreeUsingInorderAndPostorder(inorder, inStart, rootIndex-1, postorder, postStart, postStart+leftTreeSize-1, map);
        root.right = constructTreeUsingInorderAndPostorder(inorder, rootIndex+1, inEnd, postorder, postStart+leftTreeSize, postStart+leftTreeSize+rightTreeSize-1, map);
        return root;
    }
    public static void levelOrderTraversal(Node root, ArrayList<Integer>list){
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
    public static void preorderTraversal2(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        list.add(root.data);
        preorderTraversal2(root.left, list);
        preorderTraversal2(root.right, list);
    }
    public static void postorderTraversal2(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        postorderTraversal2(root.left, list);
        postorderTraversal2(root.right, list);
        list.add(root.data);
    }
    public static void inorderTraversal2(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        inorderTraversal2(root.left, list);
        list.add(root.data);
        inorderTraversal2(root.right, list);
    }
    public static void preorderTraversal(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack<>();
        stack.add(root);
        while(!stack.isEmpty()){
            Node node = stack.pop();
            list.add(node.data);
            if(node.right != null){
                stack.push(node.right);
            }if(node.left != null){
                stack.push(node.left);
            }
        }
    }
    public static void inorderTraversal(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack();
        Node node = root;
        while(node!=null || !stack.isEmpty()){
            while(node != null){
                stack.push(node);
                node = node.left;
            }
            node = stack.pop();
            list.add(node.data);
            node = node.right;
        }
    }
    public static void postorderTraversal(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        Stack<Node>stack = new Stack<>();
        Node node = root;
        while(node!=null || !stack.isEmpty()){
            while(node!=null){
                stack.push(node);
                node = node.left;
            }
            if(stack.peek().right == null){
                Node temp = stack.pop();
                list.add(temp.data);
                while(!stack.isEmpty() && stack.peek().right == temp){
                    temp = stack.pop();
                    list.add(temp.data);
                }
            }else{
                node = stack.peek().right;
            }
        }
    }
    public static int heightOfTreeUsingBFS(Node root){
        if(root==null){
            return 0;
        }
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
            }
            if(!queue.isEmpty()){
                level += 1;
            }
        }
        return level+1;
    }
    public static int heightOfTreeUsingDFS(Node root){
        if(root==null){
            return 0;
        }
        return (1+Math.max(heightOfTreeUsingBFS(root.left),heightOfTreeUsingBFS(root.right)));
    }
    public static int findLongestPathBetween2Nodes(Node root, int arr[]){
        if(root==null){
            return 0;
        }
        int leftHeight = findLongestPathBetween2Nodes(root.left, arr);
        int rightHeight = findLongestPathBetween2Nodes(root.right, arr);
        arr[0] = Math.max(arr[0], findLongestPathBetween2Nodes(root.left, arr)+ findLongestPathBetween2Nodes(root.left, arr));
        return 1+Math.max(leftHeight, rightHeight);
    }
    public static int countNoOfNodesInBinaryTree(Node root){
        if(root==null){
            return 0;
        }
        return (1+countNoOfNodesInBinaryTree(root.left)+countNoOfNodesInBinaryTree(root.right));
    }
    public static int sumOfAllNodesValues(Node root){
        if(root==null){
            return 0;
        }
        return (root.data+sumOfAllNodesValues(root.left)+sumOfAllNodesValues(root.right));
    }
    public static List<Integer>rightViewOfTheTree(Node root){
        List<Integer>res = new ArrayList<>();
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        while(!queue.isEmpty()){
            int size = queue.size();
            Node node = null;
            while(size>0){
                node = queue.poll();
                size--;
                if(node.left!=null){
                    queue.offer(node.left);
                }if(node.right!=null){
                    queue.offer(node.right);
                }
            }
            res.add(node.data);
        }
        return res;
    }
    public static List<Integer>leftViewOfTheTree(Node root){
        List<Integer>res = new ArrayList<>();
        if(root==null){
            return res;
        }
        TreeMap<Integer, Node>map = new TreeMap<>();
        Queue<CustNode>queue = new LinkedList<>();
        queue.offer(new CustNode(root, 0));
        while(!queue.isEmpty()){
            CustNode custNode = queue.poll();
            Node node = custNode.node;
            int level = custNode.val;
            if(!map.containsKey(level)){
                map.put(level, node);
            }
            if(node.left!=null){
                queue.offer(new CustNode(node.left, level+1));
            }if(node.right!=null){
                queue.offer(new CustNode(node.right, level+1));
            }
        }
        for(Map.Entry<Integer, Node>temp:map.entrySet()){
            Node node = temp.getValue();
            res.add(node.data); 
        }
        return res;
    }
    public static List<Integer>topViewOfTheTree(Node root){
        List<Integer>res = new ArrayList<>();
        if(root==null){
            return res;
        }
        TreeMap<Integer, Node>map = new TreeMap<>();
        Queue<CustNode>queue = new LinkedList<>();
        queue.offer(new CustNode(root, 0));
        while(!queue.isEmpty()){
            CustNode custNode = queue.poll();
            Node node = custNode.node;
            int col = custNode.val;
            if(!map.containsKey(col)){
                map.put(col, node);
            }
            if(node.left!=null){
                queue.offer(new CustNode(node.left, col-1));
            }if(node.right!=null){
                queue.offer(new CustNode(node.right, col+1));
            }
        }
        for(Map.Entry<Integer, Node>temp:map.entrySet()){
            Node node = temp.getValue();
            res.add(node.data); 
        }
        return res;
    }
    public static List<Integer>bottomViewOfTheTree(Node root){
        List<Integer>res = new ArrayList<>();
        if(root==null){
            return res;
        }
        TreeMap<Integer, Node>map = new TreeMap<>();
        Queue<CustNode>queue = new LinkedList<>();
        queue.offer(new CustNode(root, 0));
        while(!queue.isEmpty()){
            CustNode custNode = queue.poll();
            Node node = custNode.node;
            int col = custNode.val;
            map.put(col, node);
            if(node.left!=null){
                queue.offer(new CustNode(node.left, col-1));
            }if(node.right!=null){
                queue.offer(new CustNode(node.right, col+1));
            }
        }
        for(Map.Entry<Integer, Node>temp:map.entrySet()){
            Node node = temp.getValue();
            res.add(node.data); 
        }
        return res;
    }
    public static boolean isCousinNode(Node root, int X, int Y){
        if(root==null){
            return false;
        }
        Queue<Node>queue = new LinkedList<>();
        queue.offer(root);
        int childNode = 0;
        while(!queue.isEmpty()){
            int size = queue.size();
            while(size>0){
                int sameParent = 0;
                Node node = queue.poll();
                size--;
                if(node.left!=null){
                    if((node.left.data == X) || (node.left.data == Y)){
                        childNode++;
                        sameParent++;
                    }
                    queue.offer(node.left);
                }if(node.right!=null){
                    if((node.right.data == X) || (node.right.data == Y)){
                        childNode++;
                        sameParent++;
                    }
                    queue.offer(node.right);
                }
                if(sameParent == 2){
                    return false;
                }
            }
            if(childNode == 2){
                return true;
            }if(childNode == 1){
                return false;
            }
        }
        return false;
    }
    public static int depthDiff(Node root){
        if(root==null){
            return 0;
        }
        int leftDiff = depthDiff(root.left);
        int rightDiff = depthDiff(root.right);
        return Math.abs(leftDiff - rightDiff)+1;
    }
    public static void main(String[] args) {
        int preorder[] = {1, 2, 4, 5, 3, 6};
        int inorder[] = {4, 2, 5, 1, 3, 6};
        int postorder[] = {4, 5, 2, 6, 3, 1};
        HashMap<Integer, Integer>map = new HashMap<>();
        for(int i=0;i<inorder.length;i++){
            map.put(inorder[i], i);
        }
        // Node root = constructTreeUsingPreoderAndInorder(preorder, 0, preorder.length-1, inorder, 0, inorder.length-1, map);
        Node root = constructTreeUsingInorderAndPostorder(postorder, 0, postorder.length-1, postorder, 0, postorder.length-1, map);
        ArrayList<Integer>list = new ArrayList<>();
        levelOrderTraversal(root, list);
        // preorderTraversal2(root, list);
        // postorderTraversal2(root, list);
        // inorderTraversal2(root, list);
        // preorderTraversal(root, list);
        // postorderTraversal(root, list);
        // inorderTraversal(root, list);
        System.out.println(list);
        // System.out.println(heightOfTreeUsingDFS(root));
        // int arr[] = new int[1];
        // findLongestPathBetween2Nodes(root, arr);
        // System.out.println(arr[0]);
        // System.out.println(countNoOfNodesInBinaryTree(root));
        // System.out.println(sumOfAllNodesValues(root));
        // List<Integer>list1 = rightViewOfTheTree(root);
        // System.out.println(list1);
        // List<Integer>list1 = topViewOfTheTree(root);
        // System.out.println(list1);
        // List<Integer>list1 = bottomViewOfTheTree(root);
        // System.out.println(list1);
        // List<Integer>list1 = leftViewOfTheTree(root);
        // System.out.println(list1);
        System.err.println(depthDiff(root));
        // System.out.println(isCousinNode(root, 4, 5));
    }
    public static class CustNode{
        Node node;
        int val;
        public CustNode(Node node, int val){
            this.node = node;
            this.val = val;
        }
    }
}
