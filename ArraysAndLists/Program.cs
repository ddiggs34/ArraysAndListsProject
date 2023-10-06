using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] { 0, 1,2,3,4,5,6,7,8,9,10};//can also just go in [] - practicing though

            
            /* Create two Lists of type int. - 
             * Name one List "evens"
             * 
             *
             * Name the other List "odds"
             */

            var evens = new List<int>(); //LIST OF EVENS - DONE
            var odds = new List<int>(); // LIST OF ODD - DONE

            /* Using either a foreach or for loop, -- DONE
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */


            foreach (var num in numbers)
            {
                if (num > 0 && num % 2 == 0 )
                {
                    evens.Add(num);
                }

                else
                    odds.Add(num);               
                
            }



            foreach (var number in evens)

            { Console.WriteLine($"{number} is even");
            
            }

            foreach (var number in odds)

            { Console.WriteLine($"{number} is odd"); 
            }
            




            for (int num = 0; num < numbers.Length; num++)
            {
                numbers[num] = (numbers[num] += num);

                /* Now using foreach or for loops,
            * display each List of even and odd numbers
            

                
            * Try to be creative in your display
            */
                


            }











        }





                    



                

            }


        }

            


            

            
            

           
        
    

