using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections.Generic;
using DSA;

class Hello{
    static void Main(string[] args){
        
        /* int[] myArray = {84,85,86,87,85,90,85,83,23,45,84,1,2,0};    
        foreach(var item in UseArray.findTopTwoScores(myArray)){
            Console.Write(item + ", ");
        }; */

        /* ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Insert(0,9);
        arrayList.Add(4);
        foreach (var item in arrayList)
        {
            Console.Write(item + ", ");
        }
        Console.WriteLine(arrayList[2]);
        Console.WriteLine(arrayList.Count); */

       /*  int[] myArray = {1,2,3,4,6};
        DSA.UseArray.findMissingNumberInArray(myArray);

        Console.Write(3^1^1); */

        /* int[] arr = {1, 1, 2, 2, 3, 4, 5};
        int[] duplicatArray = DSA.UseArray.removeDuplicates(arr);
        foreach(int item in duplicatArray){
            Console.Write(item + ", ");
        } */

        /* SinglyLinkedList sll = new SinglyLinkedList();
        sll.createSinglyLinkedList(6);
        Console.Write("head: "+sll.head.value+" tail: "+sll.tail.value); */

        /* int[] prices = {7, 8, 5, 3, 6, 4,8,10,12,5};
        Console.WriteLine( DSA.UseArray.maxProfit(prices)); */

        /* int[] nums = {2,7,11,15};
        int target = 9;
        foreach(int i in DSA.UseArray.twoSum(nums,target)){
            Console.Write(i +", ");
        } */
        
        /* int[] array1 = {1,2,3,4,5};
        int[] array2 = {5,1,2,3,4,};
        Console.WriteLine(DSA.UseArray.permutation(array1,array2)); */

        /* int a = 10;
        int b = 2;
        (a, b) = (b, a);
        Console.Write("a: "+a+"\nb: "+b); 
        int c = 5, d=7;
        c=c^d;
        d=c^d;
        c=c^d;
        Console.Write("\nc: "+c+"\nd: "+d); */
       
       int[][] matrix = {
        new int[]{1,2,3},
        new int[]{4,5,6},
        new int[]{7,8,9}
       };
       /* DSA.UseArray.rotateMatrix(matrix);
       for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                System.Console.Write("{0}{1}", matrix[i][j], j == (matrix[i].Length - 1) ? "" : " ");
            }
            System.Console.WriteLine();
        } */

        /* int temp = 7;
        Console.Write(7/2); */
    }      
}