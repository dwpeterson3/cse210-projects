using System;
using System.Runtime.CompilerServices;
// To exceed requirements in this program: I added a Library Class that holds a ScriptureGenerator() method. The Library class holds a list of scripture objects that when the user
// begins the program it will create a new scripture object from the library class and call the ScriptureGenerator() method to randomly choose from the list of scriptures. 
class Program
{
    static void Main(string[] args)
    {   
        string input = " "; 
        Library library = new Library();

        Scripture scripture = library.ScriptureGenerator();
        
        scripture.Display();

        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");


        while (!scripture.IsFullyHidden() && input != "quit")
        
        { 
            input = Console.ReadLine(); 
            if (input == "quit") break;

            if(string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords();
                Console.Clear();
                scripture.Display();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            }
        }
    }


}