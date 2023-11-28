using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassExerciseNumbers
{
    internal class Words
    {
        public static string CapitalizeFirstWords(string str)
        {
            string[] words =str.Split(' ');
            
            string CapString = "";

            

            for (int index=0;index < words.Length; index++)//checks each character in the array
            {
             
                
                  string word = words[index];
                    CapString += char.ToUpper(word[0]);
                

            for (int index2=1;index2 < word.Length; index2++)
                {
                    CapString += word[index2];


                }

            CapString += " ";

            }

            // {
            //    Index index = 0; index =

            //}

            //     char.ToUpper()
            /*Console.WriteLine(char.ToUpper(inputString[index]));
            return inputString.ToUpper*/
            return CapString;
        }
    
    }
    

}
    


