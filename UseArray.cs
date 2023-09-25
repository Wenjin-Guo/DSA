using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class UseArray
    {
        /* int[,] arr; 
        int[,] arr = new int[2,2];
        int[,] arr= {{1,2},{3,4}};
        for(int row=0;row<arr.GetLength(0);row++){
            for(int col=0; col<arr.GetLength(1);col++){
                Console.Write(arr[row,col]);
            }
        } */

        /* int[] arr = new int[5];
        int[] arr = {1, 2, 3, 4, 5};
        for(int row=0;row<arr.Length;row++){
            Console.Write(arr[row]);
        } */

        /* int[] myArray = {84,85,86,87,85,90,85,83,23,45,84,1,2,0};
        int firstScore = int.MinValue;
        int secondScore = int.MinValue;

        foreach(int i in myArray){
            if(i>firstScore){
                secondScore = firstScore;
                firstScore = i;
            }else if(i>secondScore && i<firstScore){
                secondScore = i;
            }
        }
        Console.Write(firstScore+","+secondScore); */

        public static int findMissingNumberInArray(int[] arr){
            //Write Java function called findMissingNumberInArray that takes an integer array containing n-1 unique elements from a range of 1 to n, with one missing number, and returns the missing number.
            //myArray = {1,2,3,4,6}
            //findMissingNumberInArray(myArray, 6) // 5
            // Hint: Use the formula (n * (n + 1)) / 2 which  calculates the sum of the first n natural numbers.
            int n = arr.Length +1;
            int expectedSum = (n*(n+1))/2;
            int actualSum = 0;
    
            foreach(int i in arr){
                actualSum +=i;
            }
            Console.WriteLine("The missing number is " +(expectedSum-actualSum)+".");
            return expectedSum-actualSum;
        }   

        public static int[] removeDuplicates(int[] arr){
            //Write a function which takes integer array as a parameter and returns a new integer array with unique elements. (remove duplicates)
            // example: removeDuplicates({1, 1, 2, 2, 3, 4, 5})
            // output: [1, 2, 3, 4, 5]
            return new int[2];
        } 
    }
}
