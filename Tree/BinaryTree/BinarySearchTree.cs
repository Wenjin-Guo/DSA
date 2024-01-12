using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSA;

namespace DSA
{
    public class BinarySearchTree
    {
        BinarySearchNode root{get;set;}

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
            insert(root, value);
        }


    }
}