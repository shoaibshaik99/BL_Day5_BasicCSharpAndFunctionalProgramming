﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Day5AssignmentFunctionalProgramming
{
    internal class VowelOrConsonent
    {
        public static void VC()
        {
            Console.Write("Enter an alphber to check if it's a vowel or a consonent: ");
            char alphabet = char.Parse(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' ||
                alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is a vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is a consonent");
            }


        }
    }
}
