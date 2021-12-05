using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Work05_BullsAndCows
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"INPUT.txt";
            string s = File.ReadAllText(input);
            string[] words = s.Split(' ');
            string text1 = words[0]; 
            string text2 = words[1];
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i] == text2[i])
                    bulls++;
                for (int j = 0; j < text2.Length; j++)
                {
                    
                    if (text1[i] == text2[j] && text1[i] != text2[i])
                        cows++;
                }
            }
            string result = (bulls + " " + cows).ToString();
            string output = @"OUTPUT.txt";
            File.WriteAllText(output, result);
        }
    }
}
