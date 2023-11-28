using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseNumbers
{
    internal class NumberCounter
    {
        public static string CountNumbers(int[] othernumbers) 
        {
            int NegativeCounter = 0;
            int PositiveCounter = 0;
            for (int i = 0; i < othernumbers.Length; i++)
             
            {
                int number = othernumbers[i];
                if (number < 0)
                {  NegativeCounter++; }
                else if (number > 0) 
                {  PositiveCounter++; }
            
            
            
            }
            return "Total pos count is: " + PositiveCounter + " Total neg count is: " + NegativeCounter;
        }
    }
}
