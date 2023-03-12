using System;

namespace Student_list_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("How many students?");
            var userinput = Console.ReadLine();
            string[] name = new string[20];
            string[] note = new string[2];
            for (int i = 0; i < Int32.Parse(userinput); i++)
                //stringet atalakitjuk int-be
            {
                var name[i] = ReadFromConsole("Student's name:");
                var note[i] = ReadFromConsole("Student's note:");

            }
            for (int i = 1; i < Int32.Parse(userinput); i++)
            {
                Console.WriteLine(name[i], note[i]);
            }
        }

        static string ReadFromConsole(string question)
        {
            var text = "";
            while (text == "")
            {
                Console.WriteLine(question);
                text = Console.ReadLine();
            }
            return text;
        }
        

    }
}
