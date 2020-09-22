using System;
using System.Collections.Generic;

namespace MathGames
{
    class Program
    {
        Random rand = new Random();
        Dictionary<int, string> operations = new Dictionary<int, string> {
            { 1, "Addition"},
            { 2, "Subtraction" },
            { 3, "Multiplication" },
            { 4, "Division" }
        };
        int probType = 0;
        int numProb = 0;
        int score = 0;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.SetupGame();
            if (program.probType == 1)
            {
                program.Addition(program.numProb);
            }
            else if (program.probType == 2)
            {
                program.Subtraction(program.numProb);
            }
            else if (program.probType == 3)
            {
                program.Multiplication(program.numProb);
            }
            else if (program.probType == 4)
            {
                program.Division(program.numProb);
            }
            Console.Clear();
            Console.WriteLine($"You got {program.score} problems correct out of {program.numProb}");
            Console.ReadKey();
        }

        public void SetupGame()
        {
            Console.WriteLine("Welcome to Math Games\n-------------------------\n");
            Console.WriteLine("To add, enter 1");
            Console.WriteLine("To subtract, enter 2");
            Console.WriteLine("To multiply, enter 3");
            Console.WriteLine("To divide, enter 4\n");
            Console.Write("Choose your problem type: ");
            probType = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter the number of problems between 1 and 12: ");
            numProb = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"\nYou are doing {operations[probType]} and you have {numProb} problems");
            Console.WriteLine("To begin your test, press any key");
            Console.ReadKey();
        }
        public void Addition(int numProb)
        {
            for (int i = 0; i < numProb; i++)
            {
                Console.Clear();
                int leftOperand = rand.Next(1, 100);
                int rightOperand = rand.Next(1, 100);
                Console.Write($"{leftOperand}+{rightOperand}= ");
                int answer = Int32.Parse(Console.ReadLine());
                int realAnswer = leftOperand + rightOperand;
                if(answer == (leftOperand + rightOperand))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer was: {realAnswer}\nYou said: {answer}");
                }
                Console.ReadKey();
            }
        }
        public void Subtraction(int numProb)
        {
            for (int i = 0; i < numProb; i++)
            {
                Console.Clear();
                int leftOperand = rand.Next(1, 101);
                int rightOperand = rand.Next(1, 101);
                if (leftOperand < rightOperand)
                {
                    Console.Write($"{rightOperand}-{leftOperand}= ");
                    int answerTwo = Int32.Parse(Console.ReadLine());
                    int realAnswerTwo = rightOperand - leftOperand;
                    if (answerTwo == (rightOperand - leftOperand))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer was: {realAnswerTwo}\nYou said: {answerTwo}");
                    }
                }
                else
                {
                    Console.Write($"{leftOperand}-{rightOperand}= ");
                    int answer = Int32.Parse(Console.ReadLine());
                    int realAnswer = leftOperand - rightOperand;
                    if (answer == (leftOperand - rightOperand))
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, the correct answer was: {realAnswer}\nYou said: {answer}");
                    }
                }
                Console.ReadKey();
            }
        }
        public void Multiplication(int numProb)
        {
            for (int i = 0; i < numProb; i++)
            {
                Console.Clear();
                int leftOperand = rand.Next(1, 11);
                int rightOperand = rand.Next(1, 11);
                Console.Write($"{leftOperand}*{rightOperand}= ");
                int answer = Int32.Parse(Console.ReadLine());
                int realAnswer = leftOperand * rightOperand;
                if (answer == (leftOperand * rightOperand))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer was: {realAnswer}\nYou said: {answer}");
                }
                Console.ReadKey();
            }
        }
        public void Division(int numProb)
        {
            for (int i = 0; i < numProb; i++)
            {
                Console.Clear();
                float leftOperand = rand.Next(1, 100);
                float rightOperand = rand.Next(1, 11);
                Console.Write($"{leftOperand}/{rightOperand}= ");
                float answer = float.Parse(Console.ReadLine());
                float realAnswer = leftOperand / rightOperand;
                if (realAnswer - answer > -.1 && realAnswer - answer < .1)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer was: {realAnswer}\nYou said: {answer}");
                }
                Console.ReadKey();
            }
        }
    }
}
