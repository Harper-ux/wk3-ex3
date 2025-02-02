using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarations

            // the || symbol represents the bool true or false statement, as a value.

            string str; // declare the string.
            int i, len, vowel; // declare int for iteration, string length, vowel count, and string count

            // get user input 

            Console.WriteLine("Enter a string: ");
            str = Console.ReadLine(); // records users answer to question.

            vowel = 0; //int the vowel count at zero
            len = str.Length; // int the string count

            for
                (i = 0; i < len; i++) //loop through each character looking for vowels and increase the number.
            {
                //check the answer
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++; //increases the vowel count.
                }
                }
            Console.WriteLine("The total number of vowels in string is: " + vowel); //final answer 





            }
        }
    }

