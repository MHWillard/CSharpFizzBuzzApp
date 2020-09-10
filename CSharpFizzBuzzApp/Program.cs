using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFizzBuzz {
    class Program {
        public static void Main(string[] args) {
            //the below method gets the value of PrepareFizzbuzz and uses it as the returned argument for PerformFizzBuzz
            PerformFizzBuzz(PrepareFizzBuzz());
        }

        //PrepareFizzBuzz creates a List of 1-100 and returns it, which is then use as PerformFizzBuzz's argument.
        public static List<int> PrepareFizzBuzz() {
            List<int> FBArray = new List<int>();
            for (int i = 1; i < 101; i++) {
                //add to array
                FBArray.Add(i);
            }
            return FBArray;
        }

        //PerformFizzBuzz iterates through each item and runs a check for if the number is divisible by 3, 5, or both, printing the appropriate statement.
        public static void PerformFizzBuzz(List<int> FBArray) {
            foreach (int item in FBArray) {
                if (item % 15 == 0) {
                    Console.Write("FizzBuzz ");
                }
                else if (item % 3 == 0) {
                    Console.Write("Fizz ");
                }
                else if (item % 5 == 0) {
                    Console.Write("Buzz ");
                }
                else {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
