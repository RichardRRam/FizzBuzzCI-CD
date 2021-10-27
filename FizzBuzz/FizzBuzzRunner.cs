using System;

namespace FizzBuzz
{
    public class FizzBuzzRunner
    {
        int divisorOne;
        int divisorTwo;
        string divisorOneWord;
        string divisorTwoWord;

        public FizzBuzzRunner(int divisorOne, string divisorOneWord, int divisorTwo,  string divisorTwoWord)
        {
            //Edge cases for divisors sice you can not Divide by 0
            //Set to default Values - 3 and 5
            if (divisorOne == 0)
                divisorOne = 3;

            if (divisorTwo == 0)
                divisorTwo = 5;

           //Initalize all properties of FizzBuzzRunner
            this.divisorOne = divisorOne;
            this.divisorTwo = divisorTwo;

            //Trim the strings to make sure there is no leading or trailing spaces
            this.divisorOneWord = divisorOneWord.Trim();
            this.divisorTwoWord = divisorTwoWord.Trim();
        }

        public string Run(int upperBounds)
        {
            //Make sure the upper bounds is not negative or 0 to prevent infinite loop
            if (upperBounds < 1)
                upperBounds = 1;

            string output = "";

            for (int i = 1; i <= upperBounds; i++)
            {
                //Call getString method to get the current string by the current i value
                output += getString(i);

                //Add new Line to make the output clearn
                output += "\n";
            }
            return output;
        }

        public string getString(int value)
        {
            string output = "";

            //Check if value is divisible by first divisor
            if (value % divisorOne == 0)
                output += divisorOneWord;

            //Check if value is divisible by the second divisor
            if (value % divisorTwo == 0)
                output += divisorTwoWord;
            
            //If divisible by both the corresponding string will the a combination of both words. 
            //Example: divisible by 3 and 5 means divisible by 15 therefore result will the FizzBuzz

            //If not divisible by either then return the number
            if (output == "")
                return value.ToString();
            
            return output;
        }
    }
}
