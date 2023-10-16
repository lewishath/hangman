using System;
namespace hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            guessfivetimes();
        }
        static string player1word()
        {
            string word;
            bool valid = true;
            do
            {
                Console.WriteLine("PLAYER 1: enter a 4 letter word (lower case)");
                word = Console.ReadLine();
                word = word.ToLower();
                if (word.Length != 4)
                {
                    Console.WriteLine("INVALID");
                    valid = true;
                }
                else if (word.Length == 4)
                {
                    break;
                }
            } while (valid == true);
            return word;
        } 
        static string player2guess()
        {
            string a;
            bool b = false;
            do
            {
                Console.WriteLine("PLAYER 2: enter a letter (lower case)");
                a = Console.ReadLine();
                if (a.Length != 1)
                {
                    b = true;
                    break;
                }
                else
                {
                    b = false;
                }
            } while (b == true);
            return a;
        }
        static void guessfivetimes()
        {
           string word = player1word();
           Console.Clear();
            
            string newword = "1234";
            for (int i = 0; i < 5; i++)
            {
                string a = player2guess();
                if (a[0] == word[0])
                {
                    newword = newword.Replace(newword[0], a[0]);
                }
                else if (a[0] == word[1])
                {
                    newword = newword.Replace(newword[1], a[0]);
                }
                else if (a[0] == word[2])
                {
                    newword = newword.Replace(newword[2], a[0]);
                }
                else if (a[0] == word[3])
                {
                    newword = newword.Replace(newword[3], a[0]);
                }
                Console.WriteLine(newword);
                if (newword == word)
                {
                    Console.WriteLine($"WINNER: PLAYER 2. word = {word}");
                    Console.ReadKey();
                    Console.Clear();
                }               
            }
            if (newword != word)
            {
                Console.WriteLine($"WINNER: PLAYER 1. word = {word}");
            }
            else if (newword == word)
            {
                Console.WriteLine($"WINNER: PLAYER 2. word = {word}");
            }
            Console.ReadKey();
        }
    }
}
