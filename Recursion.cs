using System;
using System.Collections.Generic;
using System.Linq;
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
            return fibonacci(n-1)+fibonacci(n-2);
        }
    }
}