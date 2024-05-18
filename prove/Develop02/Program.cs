using System;
using System.Net;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        List<string> actions = new List<string> { "Write", "Display", "Load", "Save", "Quit" };
        string action = "";
        Journal journal = new Journal();

        while (action != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices? ");

            for (int i = 0; i < actions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {actions[i]}");
            }

            Console.WriteLine();
            Console.Write("Please enter an action: ");
            action = Console.ReadLine();

            if (action == "1")
            {
                Entry entry = new Entry();
                Console.WriteLine(entry.getPrompt());
                Console.Write(">");

                entry.setResponse(Console.ReadLine());
                journal.SaveEntry(entry);


            }

            else if (action == "2")
            {
                journal.dispayEnteries();

            }

            else if (action == "3")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                journal.clearEntries();

                foreach (string line in lines)
                {
                    string[] parts = line.Split("/,");

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    Entry entry = new Entry(prompt, response, DateTime.Parse(date));

                    journal.SaveEntry(entry);
                }

            }

            else if (action == "4")
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    journal.getEntries().ForEach(entry =>
                    {
                        outputFile.WriteLine($"{entry.getDate()}/,{entry.getPrompt()}/,{entry.getResponse()}");
                    });


                }

            }

        }
    }
}


