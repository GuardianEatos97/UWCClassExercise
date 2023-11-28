using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseNumbers
{
    internal class OddNumbers
    {
        public static bool CheckOddNumbers(int[] numbers)

        {
            for (int i = 0; i < numbers.Length; i++) 
            {
              int number = numbers[i];

              if (number % 2 > 0)
              {
                return true;
              }
              else 
              if (number % 2 < 0)
                { 
                    return false; 
                }
            }
            
         return false;
        }


    }
}
