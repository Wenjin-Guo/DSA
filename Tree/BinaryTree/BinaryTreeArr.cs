using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class BinaryTreeArr
    {
        String[] arr {get;set;}
        int lastUsedIndex{get;set;}

        public BinaryTreeArr(int size){
            arr = new string[size+1];
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
            if(index>lastUsedIndex||index<0){
                return;
            }else{
                Console.Write(arr[index]+" ");
                preOrder(2*index+1);
                preOrder(2*index+2);
            }
        }
    }
}