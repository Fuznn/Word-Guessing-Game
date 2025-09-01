using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessingGame
{
    internal class GameFunctions
    {
        public static string[] Bank = new string[]
        {
            "Computer",
            "Programming",
            "Array",
            "Builder",
            "Constant"
        };
        public static string[] BankHint = new string[]
        {
            "An electronic device for storing and processing data",
            "The process of creating software applications",
            "A data structure that holds a fixed number of values",
            "A person or (could be) software that creates or construct something",
            "A value that cannot be changed during program execution"
        };
        public static string[] ObfuscatedBank = new string[Bank.Length];
        public int CurrentIndex = 0;
        public string CurrentWord;
        public string CurrentWordHint;
        public static void Obfuscator()
        {
            for(int i = 0; i < Bank.Length; i++)
            {
                StringBuilder obfuscate = new StringBuilder(Bank[i]);
                for (int j = 1; j < obfuscate.Length - 1; j++)
                {
                    obfuscate[j] = '_';
                }
                ObfuscatedBank[i] = obfuscate.ToString();
            }
        }
        
        public bool CheckGuess(string guess)
        {
            CurrentWord = Bank[CurrentIndex];
            if (guess.ToLower() == CurrentWord.ToLower())
            {
                MessageBox.Show("Correct! The word was: " + CurrentWord, 
                    "Correct Guess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentIndex++;
                return true;
            } 
                return false;
        }
        public void GetHint()
        {
            CurrentWordHint = BankHint[CurrentIndex];
            MessageBox.Show("Hint: " + CurrentWordHint, "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool IsGameOver => CurrentIndex >= Bank.Length;
    }
}
