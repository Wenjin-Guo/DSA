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
        }; 
        Console.WriteLine();
        Console.Write(string.Join(", ",UseArray.findTopTwoScores(myArray))); */
       

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
       
       /* int[][] matrix1 = {
        new int[]{1,2,3,4,5},
        new int[]{11,12,13,14,15},
        new int[]{21,22,23,24,25},
        new int[]{31,32,33,34,35},
        new int[]{41,42,43,44,45},
       };
       int[][] matrix = {
        new int[]{1,2,3,4},
        new int[]{5,6,7,8},
        new int[]{9,10,11,12},
        new int[]{13,14,15,16}
       };
       int[][] matrix2={
        new int[]{1,2},
        new int[]{3,4}
       };
       DSA.UseArray.rotateMatrix(matrix);
       DSA.UseArray.printJaggedArray(matrix); */

        /* int temp = 7;
        Console.Write(7/2); */

        /* int[] array = {1,2,3,4,5};
        DSA.UseArray.reverse(array); */

        /* List<int> numbers = new List<int>() { 5, 6, 4 };
        // Violates IDE0180.
        int temp = numbers[0];
        numbers[0] = numbers[1];
        numbers[1] = temp;
        // Fixed code.
        Console.WriteLine(numbers[1]);
        (numbers[0], numbers[1]) = (numbers[1], numbers[0]);
        Console.WriteLine(numbers[1]);
        Console.Write(string.Join(", ",numbers)); */
        
        /* SinglyLinkedList linkedList = new SinglyLinkedList();
        linkedList.createSinglyLinkedList(1);
        linkedList.printSinglyLinkedList();
        linkedList.insertInLinkedList(9,0);
        linkedList.insertInLinkedList(2,1);
        linkedList.insertInLinkedList(3,3);
        linkedList.insertInLinkedList(4,4);
        linkedList.insertInLinkedList(5,9); 
        linkedList.insertInLinkedList(00,0);
        linkedList.printSinglyLinkedList();
        linkedList.insertInLinkedList(100,3);
        linkedList.printSinglyLinkedList();
        linkedList.deleteNode(10);
        linkedList.printSinglyLinkedList();
        Console.WriteLine("\nTail value: "+linkedList.tail.value);
        Console.WriteLine("Head Value: "+linkedList.head.value);
        Console.WriteLine("Size: "+linkedList.size); */

        /* LinkedList<int> lls = new LinkedList<int>();
        lls.AddLast(1);
        lls.AddLast(2);
        lls.AddLast(3);
        lls.AddLast(4);
        lls.AddLast(5);
        foreach(int i in lls){
            Console.Write("   {0}", i);
        }
        lls.Clear();
        Console.Write("\n - - - - - - ");
        foreach(int i in lls){
            Console.Write("   {0}", i);
        } */

        /* CircularSinglyLinkedList csll = new CircularSinglyLinkedList();
        csll.createCSLL(1);
        csll.insertInCSLL(2,1); 
        csll.insertInCSLL(3,2);
        csll.insertInCSLL(4,3);
        csll.insertInCSLL(5,4);
        csll.insertInCSLL(6,5);
        Console.WriteLine("head value: "+csll.head.value);
        csll.printCSLL();
        Console.WriteLine("tail value: "+csll.tail.value);
        Console.WriteLine("size value: "+csll.size);
        csll.insertInCSLL(12,3);
        csll.printCSLL();
        Console.WriteLine("Index value: "+csll.getNode(3).value);
        Console.WriteLine("Index next-value: "+csll.getNode(2).next.value);
        csll.deleteNode(7);
        csll.printCSLL();
        Console.WriteLine("head value: "+csll.head.value);
        Console.WriteLine("head value: "+csll.tail.next.value);
        Console.WriteLine("tail value: "+csll.tail.value);
        Console.WriteLine("size value: "+csll.size); */

        /* DoublyLinkedList dll = new DoublyLinkedList();
        dll.createDoublyLinkedList(1);
        dll.insertInDLL(2,1);
        dll.insertInDLL(0,0);
        dll.printDLL();
        dll.insertInDLL(0,1);
        dll.printDLL();
        dll.insertInDLL(3,3);
        dll.insertInDLL(4,4);
        dll.insertInDLL(6,6);
        dll.insertInDLL(5,5);
        dll.insertInDLL(12,4);
        dll.printDLL();
        dll.reversePrintDLL();
        Console.WriteLine("head value: "+dll.head.value);
        Console.WriteLine("tail value: "+dll.tail.value);
        Console.WriteLine("tail prev-value: "+dll.tail.prev.value);
        Console.WriteLine("size value: "+dll.size);
        Console.WriteLine("Index value: "+dll.getValue(4));
        Console.WriteLine("Index prev-value: "+dll.getNode(5).prev.value);
        Console.WriteLine("Index next-value: "+dll.getNode(3).next.value);
        dll.searchNode(5);
        dll.searchNode(120);
        dll.deleteNode(1); dll.printDLL();
        dll.deleteDLL();
        dll.printDLL(); */

        CircularDoublyLinkedList cdll = new CircularDoublyLinkedList();
        cdll.createCDLL(1);
        cdll.insertInCDLL(3,1);
        cdll.printCDLL();
        cdll.insertInCDLL(2,1);
        cdll.printCDLL();
        cdll.insertInCDLL(0,0);
        cdll.insertInCDLL(8,3);
        cdll.insertInCDLL(0,0);
        cdll.insertInCDLL(0,0);
        cdll.insertInCDLL(0,0);
        cdll.printCDLL();
    }      
}