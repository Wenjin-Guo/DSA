using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSA;

namespace DSA
{
    public class BinarySearchTree
    {
        public BinarySearchNode root{get;set;}

        public BinarySearchTree(){
            this.root=null;
        }

        //Insert Method
        private BinarySearchNode insert(BinarySearchNode currentNode, int value){
            if(currentNode==null){
                BinarySearchNode newNode = new BinarySearchNode();
                newNode.value=value;
                Console.WriteLine("The value successfully inserted.");
                return newNode;
            }else if(value<=currentNode.value){
                currentNode.left= insert(currentNode.left, value);
                return currentNode;
            }else{
                currentNode.right= insert(currentNode.right, value);
                return currentNode;
            }
        }

        public void insert(int value){
            root=insert(root, value);
        }

        //preOrder traversal
        public void preOrder(BinarySearchNode node){
            if(node==null){
                return;
            }
            Console.Write(node.value+" ");
            preOrder(node.left);
            preOrder(node.right);
        }

        //inOrder Traversal
        public void inOrder(BinarySearchNode node){
            if(node==null){
                return;
            }
            inOrder(node.left);
            Console.Write(node.value+" ");
            inOrder(node.right);
        }

        //postOrder Traversal
        public void postOrder(BinarySearchNode node){
            if(node==null){
                return;
            }
            postOrder(node.left);
            postOrder(node.right);
            Console.Write(node.value+" ");
        }

        //levelOrder Traversal
        public void levelOrder(){
            Queue<BinarySearchNode> queue = new Queue<BinarySearchNode>();
            queue.Enqueue(root);
            while(queue.Any()){
                BinarySearchNode presentNode = queue.Dequeue();
                Console.Write(presentNode.value+" ");
                if(presentNode.left!=null){
                    queue.Enqueue(presentNode.left);
                }
                if(presentNode.right!=null){
                    queue.Enqueue(presentNode.right);
                }
            }
        }

        //search in binary search tree
        public BinarySearchNode search(BinarySearchNode node, int value){
            if(node==null){
                Console.WriteLine("value "+value+" not found in BST");
                return null;
            }else if(node.value==value){
                Console.WriteLine("value "+value+" found in BST");
                return node;
            }else if(value<node.value){
                return search(node.left,value);
            }else{
                return search(node.right, value);
            }
        }

        //Minimum node
        public static BinarySearchNode minimumNode(BinarySearchNode root){
            if(root.left==null){
                return root;
            }
            return minimumNode(root.left);
        }

        //delete node in Binary search tree
        //case1: no child
        //case2: one child
        //case3: 2 children : find min in right-subtree -> 
        //                    copy the value in targetted node ->
        //                    delete duplicate from right-subtree
        //OR                  find max in left ->
        //                    copy the value in targetted node ->
        //                    delete duplicate from left-subtree
        public BinarySearchNode deleteNode(BinarySearchNode root,int value){
            if(root==null){   //base condition, no value found
                Console.WriteLine("Value not found in BST");
                return null;
            }else if(value<root.value){  //
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
                    BinarySearchNode temp = root;
                    root = root.right;
                    temp = null;
                }else if(root.right == null){
                    BinarySearchNode temp = root;
                    root = root.left;
                    temp = null;
                }
                //case 3: 2 children
                else{
                    BinarySearchNode temp = minimumNode(root.right);
                    root.value = temp.value;
                    root.right = deleteNode(root.right,temp.value);
                }

            }
            return root;
        }
    }
}