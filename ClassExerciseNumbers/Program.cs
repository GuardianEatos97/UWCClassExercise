using System.Diagnostics.Metrics;

namespace ClassExerciseNumbers
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /* int[] mynumbers = { 9, 1, 7, 4, 2, 5 };
             int biggest = Numbers.BiggestNumber(mynumbers);
             int Secondbiggest = Numbers.SecondBiggest(mynumbers);
             Console.WriteLine(biggest);
             Console.WriteLine(Secondbiggest);*/

            /*string inputString = "I hope you had a good weekend";
            string capitalstring = Words.CapitalizeFirstWords(inputString);
            Console.WriteLine(capitalstring);*/

            /*  int[] numbers = { 2, 4, 6, 9 };
              bool isOddNumber = OddNumbers.CheckOddNumbers(numbers);
              if (isOddNumber)
              {
               Console.WriteLine("The array contains an odd number");
              }
              else 
              {
               Console.WriteLine("The array does not contain an odd number");
              } */

            /*  String letters = "Hello World";
              string RemovedVowelString = Vowels.RemoveAllTheVowels(letters);
              Console.WriteLine(RemovedVowelString); 
            */

              int[] othernumbers = { -1, 2, 4, 6, 9 };
             // int ReturnedValue = NumberCounter.CountNumbers(othernumbers);
            //Console.WriteLine(ReturnedValue);
            Console.WriteLine(NumberCounter.CountNumbers(othernumbers));

            string sentence = "Learning Programming Is Cool";
            Console.WriteLine(LongestWord.BiggestWord(sentence));
        }

    }
}