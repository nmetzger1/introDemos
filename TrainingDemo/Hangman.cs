using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDemo
{
    internal class Hangman
    {
        string[] Library = new string[] { "volleyball", "chess", "train", "blueberry" };
        char[] answer;
        char[] display;
        int correctLetters = 0;


        public void PlayHangman()
        {
            int lives = 5;
            answer = selectedWord().ToCharArray();            
            display = new char[answer.Length];

            //Display Puzzle
            for (int i = 0; i < answer.Length; i++)
            {
                display[i] = '_';
            }

            Console.WriteLine(display);


            //Get User Guess
            while(lives > 0 && correctLetters < answer.Length)
            {
                Console.WriteLine("Guess a letter");
                char guess = Console.ReadLine().ToCharArray()[0];
                if (isCorrect(answer, guess))
                {
                    Console.WriteLine("Good job!");
                    Console.WriteLine(display);
                }
                else
                {
                    lives--;
                    Console.WriteLine("Incorrect. You have {0} live(s) left", lives);
                }


            }
            if(lives == 0)
            {
                Console.Write("Sorry you lose.  The correct answer was: ");
                Console.Write(answer);
            }
            else
            {
                Console.WriteLine("You win!");
            }
            

           
        }

        private string selectedWord()
        {
            Random random = new Random();

            return Library[random.Next(Library.Length)];
        }

        private bool isCorrect(char[] answer, char letter)
        {
            bool correct = false;
            
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == letter)
                {
                    display[i] = letter;
                    correct = true;
                    correctLetters++;
                }
            }

            return correct;
        }    
    }
}
