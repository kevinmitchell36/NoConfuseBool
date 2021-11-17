using System;
using System.Collections;
using System.Collections.Generic;

namespace NoConfuseBool
{
    class Program
    {
        static void Main(string[] args)
        {
            GroceryRun groceryRun = new GroceryRun();
            Console.WriteLine("I'm going to the grocery store." );
            IList condition = groceryRun.BreakfastOffer();  
            Console.WriteLine($"I'll make you breakfast {condition[0]} (think: {condition[1]})");
            Console.WriteLine($"I come back from the grocery store with {groceryRun.ComeHomeWith()}" );
            Console.WriteLine($"Am I making you breakfast? (type y or n)");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine(answer);
           
            
        }
    }

    class GroceryRun
    {

        private string[] results = { "just bacon", "just eggs", "both" };
        private string[] questions = { "if I buy bacon or eggs", "if I buy bacon and eggs" };



        public string ComeHomeWith()
        {
            
            Random result = new Random();
            int index = result.Next(results.Length);
            return results[index];
        }

        public IList BreakfastOffer()
        {
            List<string> englishCode = new List<string>();
            Random question = new Random();
            int index = question.Next(questions.Length);
            string code = "bacon && eggs";
            if (questions[index] == "if I buy bacon or eggs")
            {
                code = "bacon || eggs";
            }
            englishCode.Add(questions[index]);
            englishCode.Add(code);
            return englishCode;
        }

        public void Breakfast()
        {
            Console.WriteLine("I'm making you breakfast!");
        }

        public void NoBreakfast()
        {
            Console.WriteLine("I'm not making you breakfast!");
        }
    }
}
