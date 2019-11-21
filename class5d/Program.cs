using System;
using System.Collections.Generic;

namespace class5d
{
    class QuizQandA<T, U>
    {
        public string Question { get; private set; }
        public U Answer { get; private set; }
        public List<T> Options { get; private set; }

        public bool isMulti { get; private set; }

        public QuizQandA(string question, U answer, List<T> options, bool multi)
        {
            Question = question;
            Answer = answer;
            Options = options;
            isMulti = isMulti;
        }
    }

    public class Program
    {
        static void PrintQuestionAndOptions<T>(string question, List<T> options, bool isMulti)
        {
            Console.WriteLine(question);

            {
                //if (options[0].GetType() == typeof(int))
                //    Console.WriteLine("These are Integers");
                //else if (options[0].GetType() == typeof(bool))
                //    Console.WriteLine("These are Booleans");

                foreach (T option in options)
                {
                    Console.WriteLine("\t" + option);
                }
                if (isMulti)
                    Console.WriteLine("\tNone of Above. ");
            }
        }
        public static void Main()
        {
            QuizQandA<int, string> question1 = new QuizQandA<int, string>("How many kids does Phil have?", "None of the above", new List<int>() { 1, 2, 3, 4 }, true);
            QuizQandA<bool, bool> question2 = new QuizQandA<bool, bool>("Does he love them equally?", false, new List<bool>() { true, false }, false);

            PrintQuestionAndOptions(question1.Question, question1.Options, question1.isMulti);
            PrintQuestionAndOptions(question2.Question, question2.Options, question2.isMulti);

            Console.ReadLine();
        }

    }
}
