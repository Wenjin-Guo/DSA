using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DSA
{
    public class Recursion
    {
        public int factorial(int n){
            
            if(n<1){
                return -1;
            }
            if(n==0||n==1){
                return 1;
            }else{
                return n*factorial(n-1);
            }
            
        }

        public int fibonacci(int n){
            if(n<0){
                return -1;
            }
            if(n==0){
                return 0;
            }
            if(n==1){
                return 1;
            }
            return fibonacci(n-1)+fibonacci(n-2);
        }

        public int findMaxNumRec(int[] sampleArray){
            //regular function expression
            /* int size = sampleArray.Length;
            return findMax(sampleArray,size);
            int findMax(int[] sampleArray, int n){
                if(n==1){
                    return sampleArray[0];
                }
                return Math.Max(sampleArray[n-1],findMax(sampleArray,n-1));
            } */
            //local function example
            /* int size = sampleArray.Length;
            return findMax(sampleArray,size);
            int findMax(int[] sampleArray,int n)=>
                n==1 ? sampleArray[0] :
                Math.Max(sampleArray[n-1],findMax(sampleArray,n-1)); */
            //lambda expression example
            int size = sampleArray.Length;
            Func<int[],int,int> findMax = null;
            findMax = (sampleArray,size)=>
                size==1?sampleArray[0]:
                Math.Max(sampleArray[size-1],findMax(sampleArray,size-1));
            return findMax(sampleArray,size);
        }

        //give a positive number return the sum of each digits in the number
        public int sumOfDigits(int n){
            if(n<0){
                return 0;
            }
            if(n<10){
                return n;
            }
            return n%10 +sumOfDigits(n/10);
        }

        public double powerOfNumber(int baseNumber, int times){
            double temp = 1/baseNumber;
            if(times<0){
                return temp*powerOfNumber(baseNumber,times+1);
            }
            if(times==0){
                return 1;
            }
            return baseNumber * powerOfNumber(baseNumber,times-1);
        }

        //find the greatest common divisor
        public int gcd(int a, int b){
            if(a<=0||b<=0){
                return -1;
            }
            if(a>=b){
                return solution(a, b);
            }
            else{
                return solution(b,a);
            }
            int solution(int a, int b)=>b==0 ? a: solution(b,a%b); 
        }

        //convert decimal to binary
        public int decimalToBinary(int a){
            if(a==0){
                return 0;
            }
            return a%2 + 10*decimalToBinary(a/2);
        }

        public int power(int baseNumber, int exponent){
            if(exponent==0){
                return 1;
            }
            if(exponent==1){
                return baseNumber;
            }
            return baseNumber*power(baseNumber,exponent-1);
        }
    }
}