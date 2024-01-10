using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryTreeArr
    {
        public String[] arr {get;set;}
        public int lastUsedIndex{get;set;}

        public BinaryTreeArr(int size){
            arr = new string[size];
            this.lastUsedIndex = 0;
            Console.WriteLine("Blank Tree of size "+size+" has been created");
        }
        
        //isFull
        public bool isFull(){
            if(arr.Length-1==lastUsedIndex){
                return true;
            }else{
                return false;
            }
        }

        //insert method
        //index start from 0
        //left child = 2*index+1
        //right child = 2*index+2
        public void insert(String value){
            if(!isFull()){
                arr[lastUsedIndex] = value;
                lastUsedIndex++;
                Console.WriteLine("The value of "+value+ " has been inserted");
            }else{
                Console.WriteLine("The BT is full");
                extendCapacity();
                arr[lastUsedIndex] = value;
                lastUsedIndex++;
                Console.WriteLine("The BT capacity has extended, and the value of "+value+ " has been inserted");
            }
        }

        //extend array capacity
        private void extendCapacity(){
            String[] temp = new string[arr.Length*2];
            for(int i=0;i<arr.Length;i++){
                temp[i] = arr[i];
            }
            arr=temp;
        }

        //preOrder Traversal
        public void preOrder(int index){
            if(index>=lastUsedIndex||index<0){
                return;
            }else{
                Console.Write(arr[index]+" ");
                preOrder(2*index+1);
                preOrder(2*index+2);
            }
        }

        //inOrder Traversal
        public void inOrder(int index){
            if(index>=arr.Length||arr[index]==null||index<0){
                return;
            }else{
                inOrder(2*index+1);
                Console.Write(arr[index]+" ");
                inOrder(2*index+2);
            }
        }

        //postOrder Traversal
        public void postOrder(int index){
            if(index>=arr.Length||arr[index]==null||index<0){
                return;
            }else{
                postOrder(2*index+1);
                postOrder(2*index+2);
                Console.Write(arr[index]+" ");
            }
        }

        //levelOrder Traversal
        public void levelOrder(){
            for(int i=0;i<lastUsedIndex;i++){
                Console.Write(arr[i]+" ");
            }
        }

        //use levelOrder traversal to do the search 
        public int searchNode(String value){
            for(int i=0;i<lastUsedIndex;i++){
                if(arr[i]==value){
                    Console.WriteLine(value+" exists at the location: "+i);
                    return i;
                }
            }
            Console.WriteLine("The value does not exist in BT.");
            return -1;
        }

        //use levelOrder traversal find the location of the value to delete, and swap with the deepest node, then delete the deepest node
        public void deleteNode(String value){
            for(int i=0;i<lastUsedIndex;i++){
                if(arr[i]==value){
                    (arr[i],arr[lastUsedIndex-1])=(arr[lastUsedIndex-1],arr[i]);
                    arr[lastUsedIndex-1]=null;
                    lastUsedIndex--;
                    Console.WriteLine(value+" deleted in the BT");
                    return;
                }
            }
            Console.WriteLine(value+" does not exists in the BT");
        }
    }
}