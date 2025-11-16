import java.util.ArrayList;
import java.util.HashMap;
import java.util.HashSet;
public class BSTExample 
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
    public static void main(String[] args) 
    {
        int preorder[] = {5, 3, 2, 4, 6, 7};
        int inorder[] = {2, 3, 4, 5, 6, 7};
        HashMap<Integer, Integer>map = new HashMap<>();
        for(int i=0;i<inorder.length;i++){
            map.put(inorder[i], i);
        }
        Node root = constructTreeUsingPreorderInorder(inorder, 0, inorder.length-1, preorder, 0, preorder.length-1, map);
        ArrayList<Integer>list = new ArrayList<>();
        inorderTraversal(root, list);
        System.out.println("In-Order Traversal:-> "+list);
        // insertNodeInBSTIterative(root, 6);
        // root = insertNodeInBST(root, 6);
        // list = new ArrayList<>();
        // inorderTraversal(root, list);
        // System.out.println("In-Order Traversal After Insertion:-> "+list);

        // root = deleteNodeInBST(root, 1);
        // list = new ArrayList<>();
        // inorderTraversal(root, list);
        // System.out.println("In-Order Traversal After Deletion:-> "+list);
        // System.out.println(getHeightOfBST(root));
        // System.out.println(isValidBST(root, Integer.MIN_VALUE, Integer.MAX_VALUE));
        // System.out.println(is2SumPresent(root, 9));
        // Node node = kthSmallestElement(root, 5);
        // System.out.println(node.data);

        
    }
    public static Node lowestCommonFactor(Node root, Node P, Node Q){
        if(root == null || root == P || root == Q){
            return root;
        }
        if(root.data<P.data && root.data<Q.data){
            return lowestCommonAncestor(root.left, P, Q);
        }else if(root.data>P.data && root.data>Q.data){
            return lowestCommonAncestor(root.right, P, Q);
        }
        return root;
    }
    static int pos = 0;
    public static Node kthSmallestElement(Node root, int k){
        if(root == null){
            return null;
        }
        Node leftNode = kthSmallestElement(root.left, k);
        if(leftNode != null){
            return leftNode;
        }

        pos++;
        if(pos == k){
            return root;
        }

        Node rightNode = kthSmallestElement(root.right, k);
        if(rightNode != null){
            return rightNode;
        }
        return null;


    }
    public static boolean is2SumPresent(Node root, int k){
        HashSet<Integer>set = new HashSet<>();
        return isPresent(root, k, set);
    }
    public static boolean isPresent(Node root, int K, HashSet<Integer>set){
        if(root == null){
            return false;
        }
        if(set.contains(K-root.data)){
            return true;
        }
        set.add(root.data);
        boolean isLeftValid = isPresent(root.left, K, set);
        boolean isRightValid = isPresent(root.right, K, set);
        return(isLeftValid || isRightValid);
    }
    public static boolean isValidBST(Node root, int min, int max){
        if(root == null){
            return true;
        }
        if(root.data <= min || root.data >= max){
            return false;
        }
        boolean isLeftValid = isValidBST(root.left, min, root.data);
        boolean isRightValid = isValidBST(root.right, root.data, max);
        return(isLeftValid && isRightValid);
    }
    public static Node deleteNodeInBST(Node root, int val){
        if(root == null){
            return null;
        }
        if(root.data > val){
            root.left = deleteNodeInBST(root.left, val);
        }else if(root.data < val){
            root.right = deleteNodeInBST(root.right, val);
        }else{
            // [root.data == val]
            if(root.left == null && root.right == null){
                return null;
            }else if(root.left == null){
                return root.right;
            }else if(root.right == null){
                return root.left;
            }else{
                // [root.left != null && root.right != null]
                Node node = findSuccessorNodeForDeletion(root.right);
                root.data = node.data;
                root.right = deleteNodeInBST(root.right, node.data);
            }
        }
        return root;

    }
    public static Node findSuccessorNodeForDeletion(Node node){
        while(node.left != null){
            node = node.left;
        }
        return node;
    }
    public static Node insertNodeInBST(Node root, int val){
        if(root == null){
            return new Node(val);
        }
        if(root.data>val){
            root.left = insertNodeInBST(root.left, val);
        }else{
            root.right = insertNodeInBST(root.right, val);
        }
        return root;
    }
    public static Node insertNodeInBSTIterative(Node root, int value){
        if(root == null){
            return new Node(value);
        }
        Node node = root;
        while(node != null){
            if(node.data>value){
                if(node.left == null){
                    node.left = new Node(value);
                    break;
                }
                node = node.left;
            }else{
                if(node.right == null){
                    node.right = new Node(value);
                    break;
                }
                node = node.right;
            }
        }
        return root;
    }
    public static Node lowestCommonAncestor(Node root, Node P, Node Q){
        if(root == null || root == P || root == Q){
            return root;
        }
        Node left = lowestCommonAncestor(root.left, P, Q);
        Node right = lowestCommonAncestor(root.right, P, Q);
        if(left == null){
            return right;
        }if(right == null){
            return left; 
        }
        return root;
    }
    public static int getHeightOfBST(Node root){
        if(root == null){
            return 0;
        }
        int leftHeight = getHeightOfBST(root.left);
        int rightHeight = getHeightOfBST(root.right);
        if(leftHeight == -1 || rightHeight == -1){
            return -1;
        }
        if(Math.abs(leftHeight-rightHeight)>1){
            return -1;
        }
        return Math.max(leftHeight, rightHeight)+1;
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
    public static void inorderTraversal(Node root, ArrayList<Integer>list){
        if(root == null){
            return;
        }
        inorderTraversal(root.left, list);
        list.add(root.data);
        inorderTraversal(root.right, list);
    }
}
