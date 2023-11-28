using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseNumbers
{
    internal static class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            //int[] mynumbers = { 2, 1, 7, 4, 9, 5,};
           // Array.Sort(numbers);

              int current = numbers[0];
            //int current = numbers.Min(x => x);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > current)
                current = numbers[i];
            }
                return current;
         
            /* return numbers.Max();
            return numbers.Min();*/
        }
        public static int SecondBiggest(int[] numbers)
        {
            int BigNumber = BiggestNumber(numbers);
            int SecondNumber = 0;

            int current = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            { if (numbers[i] < BigNumber && numbers[i] > SecondNumber) 
                    SecondNumber = numbers[i];
              }
            return SecondNumber;


            return SecondBiggest(numbers);
        
        
        
        
        
        
        }

    }
    
    
        
    }

