using System;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Linq;

namespace Survey_HM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SurveyClass> Squestions = new List<SurveyClass>();

            //Survey question1 = new Survey();
            //Survey question2 = new Survey();
            //Survey question3 = new Survey();

            //Console.WriteLine(question1.GetHashCode());
            //Console.WriteLine(question2.GetHashCode());
            //Console.WriteLine(question3.GetHashCode());

            string nextq = "y";

            while (nextq == "y")
            {
                SurveyClass question = new SurveyClass();

                Console.WriteLine("Name:");
                question.Name = Console.ReadLine();

                Console.WriteLine("CNP:");
                question.CNP = Console.ReadLine();

                Console.WriteLine("Age:");
                question.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Gender:");
                question.Gender = Console.ReadLine();

                Console.WriteLine("Birth Month:");
                question.Month = Console.ReadLine();

                Squestions.Add(question);

                Console.WriteLine("Do you have another client? y/n");
                nextq = Console.ReadLine();

            }
            foreach (var item in Squestions)
            {
                Console.WriteLine($"Name: {item.Name}, CNP:{item.CNP}, Age:{item.Age}, Gender:{item.Gender}, Borth Month:{item.Month}");
            }

        }
    }
}
