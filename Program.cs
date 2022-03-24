/*44) WAP to display no of vowels present in the given word.
    Input : inputString
    Display : Vowels are not  present
	     for more than one vowel, {NO of Vowels} are present.
	     for single vowel, Only one vowel is present.
*/
using System;

namespace _44_display_the_no_of_vowels_present_in_a_given_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] inputstring = new char[100];
            int i, vowels, x;

            vowels = 0;

            // Enter the length of the string
            Console.WriteLine("Please enter the  Number Of Words :\n");
            x = int.Parse(Console.ReadLine());

            // Enter the string
            Console.WriteLine("Enter string Name :\n");
            for (i = 0; i < x; i++)
            {
                inputstring[i] = Convert.ToChar(Console.Read());
            }

            // Iterating the string
            for (i = 0; inputstring[i] != '\0'; i++)
            {

                // Check if the character is a vowel
                if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
                    inputstring[i] == 'i' || inputstring[i] == 'o' ||
                    inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' ||
                    inputstring[i] == 'O' || inputstring[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }


            }
            // Display the count of vowels and consonant
            Console.WriteLine("\n Number of vowels Are Present = " + vowels);
            Console.ReadLine();
        }
    }
}
