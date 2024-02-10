using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace DSA
{
    public class AVLTree
    {
        AVLNode root;

        //constructor
        public AVLTree(){
            this.root=null;
        }

        //preOrder traversal
        public void preOrder(AVLNode node){
            if(node==null){
                return;
            }
            Console.Write(node.value+" ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //inOrder traversal
        public void inOrder(AVLNode node){
            if(node==null){
                return;
            }
            inOrder(node.left);
            Console.Write(node.value+" ");
            inOrder(node.right);
        }

        //postOrder traversal
        public void postOrder(AVLNode node){
            if(node==null){
                return;
            }
            postOrder(node.left);
            postOrder(node.right);
            Console.Write(node.value+" ");
        }

        //levelOrder traversal
        public void levelOrder(){
            Queue<AVLNode> queue = new Queue<AVLNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                AVLNode temp = queue.Dequeue();
                Console.Write(temp.value+ " ");
                if(temp.left!=null){
                    queue.Enqueue(temp.left);
                }
                if(temp.right!=null){
                    queue.Enqueue(temp.right);
                }
            }
        }

        //search method
        public AVLNode search(AVLNode node, int value){
            if(node==null){
                Console.WriteLine(value+" is not found in AVLTree");
                return null;
            }else if(node.value==value){
                Console.WriteLine(value+" has found in AVLTree");
                return node;
            }else if(node.value>value){
                return search(node.left,value);
            }else{
                return search(node.right,value);
            }
        }


        //getHeight 
        public int getHeight(AVLNode node){
            if(node==null){
                return 0;
            }else{
                return node.height;
            }
        }

        //rotateRight
        private AVLNode rotateRight(AVLNode disbalancedNode){
            AVLNode newRoot = disbalancedNode.left;
            disbalancedNode.left = disbalancedNode.left.right;
            newRoot.right = disbalancedNode;
            disbalancedNode.height = 1+Math.Max(getHeight(disbalancedNode.left),getHeight(disbalancedNode.right));
            newRoot.height = 1+Math.Max(getHeight(newRoot.left),getHeight(newRoot.right));
            return newRoot;
        }

        //rotateLeft
        private AVLNode rotateLeft(AVLNode disbalancedNode){
            AVLNode newRoot = disbalancedNode.right;
            disbalancedNode.right = disbalancedNode.right.left;
            newRoot.left  = disbalancedNode;
            disbalancedNode.height = 1+Math.Max(getHeight(disbalancedNode.left),getHeight(disbalancedNode.right));
            newRoot.height = 1+Math.Max(getHeight(newRoot.left),getHeight(newRoot.right));
            return newRoot;
        }


        //getBalance
        public int getBalance(AVLNode node){
            if(node==null){
                return 0;
            }
            return getHeight(node.left)-getHeight(node.right);
        }

        
        //insertNode method
        private AVLNode insertNode(AVLNode node, int value){
            if(node==null){
                AVLNode newnode = new AVLNode();
                newnode.value = value;
                newnode.height=1;
                return newnode;
            }else if(value<node.value){
                node.left = insertNode(node.left,value);
            }else{
                node.right = insertNode(node.right,value);
            }
            node.height = 1+Math.Max(getHeight(node.left),getHeight(node.right));
            int balance = getBalance(node);
            //leftleft condition
            if(balance>1 && value<node.left.value){
                return rotateRight(node);
            }
            //leftRight condition
            if(balance>1 && value>node.left.value){
                node.left = rotateLeft(node.left);
                return rotateRight(node);
            }
            //rightRight condition
            if(balance<-1 && value>node.right.value){
                return rotateLeft(node);
            }
            //rightLeft condition
            if(balance <-1 && value<node.right.value){
                node.right = rotateRight(node.right);
                return rotateLeft(node);
            }

            return node;
        } 

        public void insert(int value){
            root = insertNode(root,value);
        }

        //Minimum node
        public static AVLNode minimumNode(AVLNode root){
            if(root.left==null){
                return root;
            }
            return minimumNode(root.left);
        }

        //delete node in AVLTree
        //case1: no child
        //case2: one child
        //case3: 2 children : find min in right-subtree -> 
        //                    copy the value in targetted node ->
        //                    delete duplicate from right-subtree
        //OR                  find max in left ->
        //                    copy the value in targetted node ->
        //                    delete duplicate from left-subtree
        //After deletion, check the balance
        //identify rotation condition, and do the rotation
        private AVLNode deleteNode(AVLNode root,int value){
            if(root==null){   //base condition, no value found
                Console.WriteLine("Value not found in BST");
                return null;
            }
            if(value<root.value){  //
                root.left = deleteNode(root.left,value);
            }else if(value>root.value){
                root.right = deleteNode(root.right,value);
            }else{ //Wohoo found the node, get ready to be deleted
                //case 1:
                if(root.left==null&& root.right==null){
                    root = null;
                }
                //case 2:
                else if(root.left==null){
                    root = root.right;
                }else if(root.right == null){
                    root = root.left;
                }
                //case 3: 2 children
                else{
                    AVLNode temp = minimumNode(root.right);
                    root.value = temp.value;
                    root.right = deleteNode(root.right,temp.value);
                }
            }

            int balance = getBalance(root);
            //leftleft condition
            if(balance>1 && value<root.left.value){
                return rotateRight(root);
            }
            //leftRight condition
            if(balance>1 && value>root.left.value){
                root.left = rotateLeft(root.left);
                return rotateRight(root);
            }
            //rightRight condition
            if(balance<-1 && value>root.right.value){
                return rotateLeft(root);
            }
            //rightLeft condition
            if(balance <-1 && value<root.right.value){
                root.right = rotateRight(root.right);
                return rotateLeft(root);
            }
            return root;
        }

        public void delete(int value){
            deleteNode(root,value);
        }
    }
}