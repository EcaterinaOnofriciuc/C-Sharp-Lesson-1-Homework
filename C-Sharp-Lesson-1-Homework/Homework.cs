
namespace C_Sharp_Lesson_1_Homework
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | odd                                  |
          * |--------|--------------------------------------|
          * |  2     | even                                 |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */
            if (number <= 0)
            {
                Console.WriteLine("the value should be greater then zero");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            Console.WriteLine(number % 4 == 0 ? "The number divide to 4" : "The number doesn't divide to 4");
        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */

            switch (day.ToLower())
            {
                case "monday":
                    Console.WriteLine(1);
                    break;
                case "tuesday":
                    Console.WriteLine(2);
                    break;
                case "wednesday":
                    Console.WriteLine(3);
                    break;
                case "thursday":
                    Console.WriteLine(4);
                    break;
                case "friday":
                    Console.WriteLine(5);
                    break;
                case "saturday":
                    Console.WriteLine(6);
                    break;
                case "sunday":
                    Console.WriteLine(7);
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            character = character.ToString().ToLower().FirstOrDefault();
            switch (character)
            {
                case 'a' or 'e' or 'i' or 'o' or 'u':
                    Console.WriteLine($"{character} is a vowel");
                    break;
                case 'b' or 'c' or 'd' or 'f' or 'g' or 'h' or 'j' or 'k' or 'l' or 'm'
                      or 'n' or 'p' or 'q' or 'r' or 's' or 't' or 'v' or 'w' or 'x' or 'y' or 'z':
                    Console.WriteLine($"{character} is a consonant");
                    break;
                default:
                    Console.WriteLine("is not a letter");
                    break;
            }
            if (character is 'a' or 'e' or 'i' or 'o' or 'u')
            {
                Console.WriteLine($"{character} is a vowel");
            }
            else if (character is 'b' or 'c' or 'd' or 'f' or 'g' or 'h' or 'j' or 'k' or 'l' or 'm'
                       or 'n' or 'p' or 'q' or 'r' or 's' or 't' or 'v' or 'w' or 'x' or 'y' or 'z')
            {
                Console.WriteLine($"{character} is a consonant");
            }
            else
            {
                Console.WriteLine("is not a letter");
            }

        }
    }
}
