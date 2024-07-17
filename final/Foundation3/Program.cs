using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3616 Jill Street", "Idaho Falls", "Idaho", "83401");
        Address address2 = new Address("6401 Westwind Way", "Crestwood", "Kentucky", "40014");
        
        Lectures lecture = new Lectures(
            "How to tie a fly",
            "Learn how to tie a wooly bugger",
            "July 17th 2024",
            "5:00 PM",
            address1,
            "Derek Peterson",
            25
        );

        Receptions reception = new Receptions(
            "Derek and Janeil Marriage",
            "Come celebrate our wedding with light refreshments",
            "April 9th 2016",
            "6:00 PM",
            address1,
            "pet08043@byui.edu"
        );

        OutdoorGatherings gathering = new OutdoorGatherings(
            "Family Fun Fest",
            "Fun, Rootbeer Floats, All About Me Booklets",
            "August 24th 2024",
            "2:00 - 4:00 PM",
            address2,
            "Sunny"
        );

        Events[] events = { lecture, reception, gathering };

        foreach (var evt in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.DisplayStandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(evt.DisplayFullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(evt.DisplayShortDescription());
            Console.WriteLine("\n-------------------\n");
        }    
    }
}