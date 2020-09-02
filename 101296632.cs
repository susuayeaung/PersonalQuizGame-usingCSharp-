//COMP1202, Student Id: 101296632, Last Name: Aung, First Name: Su Su Aye
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace COMP1202_S20_Assg1_101296632
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, fullName, correctAns = "", answer = "";
            int totalScore = 0, score = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, attempt = 0;
            double percentageScore, fullMark = 100.0;
            DateTime date;

            // Getting the info of the user
            WriteLine("*****Welcome to the Harry Potter Film Series cast members' Personal Quiz!!!***** \n");
            WriteLine("Please enter your last name: ");
            lastName = ReadLine();
            WriteLine("Please enter your first name: ");
            firstName = ReadLine();
            fullName = firstName + " " + lastName;

            // Quiz 1
            Write("\n What is Daniel Radcliffe hobby? \n reading \n swimming \n travelling \n driving \n Ans: ");
            answer = ReadLine();
            correctAns = "reading";
            attempt = GetAttempt(answer, correctAns);
            score = GetScore(attempt);
            totalScore += score;
            WriteLine("\n Congratulation!!! You have got " + score + " scores. \n");
            count1 = attempt;

            // Quiz 2
            Write("What is Rupert Grint favorite music type? \n pop \n hiphop \n rock \n jazz \n Ans: ");
            answer = ReadLine();
            correctAns = "pop";
            attempt = GetAttempt(answer, correctAns);
            score = GetScore(attempt);
            totalScore += score;
            WriteLine("\n Congratulation!!! You have got " + score + " scores. \n");
            count2 = attempt;

            // Quiz 3
            Write("What is Emma Watson favorite TV show? \n Modern Family \n Friends \n Best Room Wins \n New Girl \n Ans: ");
            answer = ReadLine();
            correctAns = "Friends";
            attempt = GetAttempt(answer, correctAns);
            score = GetScore(attempt);
            totalScore += score;
            WriteLine("\n Congratulation!!! You have got " + score + " scores. \n");
            count3 = attempt;

            // Quiz 4
            Write("What is Tom Felton favorite TV serie? \n American Idol \n The Mask Singer \n The X Factor \n American Got Talent \n Ans: ");
            answer = ReadLine();
            correctAns = "The Mask Singer";
            attempt = GetAttempt(answer, correctAns);
            score = GetScore(attempt);
            totalScore += score;
            WriteLine("\n Congratulation!!! You have got " + score + " scores. \n");
            count4 = attempt;

            // Quiz 5
            Write("What is JK Rowling favorite vacation spot? \n England \n Italy \n France \n New Zealand \n Ans: ");
            answer = ReadLine();
            correctAns = "England";
            attempt = GetAttempt(answer, correctAns);
            score = GetScore(attempt);
            totalScore += score;
            WriteLine("\n Congratulation!!! You have got " + score + " scores. \n\n\n");
            count5 = attempt;

            percentageScore = Convert.ToDouble(totalScore) / fullMark * 100.0; // Calculate the percentage of the total marks
            date = DateTime.Now; // To get the current date and time with datetime method

            // display the progress report on the screen
            WriteLine("*****Congratulation!!! Here is your result!!!***** \n");
            WriteLine("\t Current date and time: " + date);
            WriteLine("\t User Fullname: " + fullName);
            WriteLine("\t Marks scored for the quiz: " + totalScore);
            WriteLine("\t Percentage score: " + percentageScore + "%");
            WriteLine("\t Number of attempts for each question are as follow.");
            WriteLine("\t Question 1: " + count1);
            WriteLine("\t Question 2: " + count2);
            WriteLine("\t Question 3: " + count3);
            WriteLine("\t Question 4: " + count4);
            WriteLine("\t Question 5: " + count5);

            ReadKey();
        }
    
        static int GetScore(int attempt) // for finding the score
        {
            int score = 0;
            if (attempt == 1)
            {
                score = 20;
            }
            else if (attempt == 2)
            {
                score = 10;
            }
            else if (attempt == 3)
            {
                score = 5;
            }
            else if (attempt == 4)
            {
                score = 0;
            }
            return score;
        }
        static int GetAttempt(string answer, string correctAns) // for finding the attempts to get the score
        {
            string value = "a";
            int attempt = 0;
            for (attempt = 0; value != correctAns && attempt < 5; attempt++)
            {
                if (answer == correctAns)
                {
                    value = correctAns;
                }
                else
                {
                    Write("\n Sorry it is not a correct answer. Please try again. \n Ans: ");
                    answer = ReadLine();
                }
            }
            return attempt;
        }
    }
}
