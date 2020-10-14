using System;
using System.Collections.Generic;

namespace ChartQuiz
{
    //Fabio Lehner
    //mit Hilfe von Samuel Kowatschek 
    class Program
    {
        static void Main(string[] args) { 
        
            List<Entry> listOfItems = new List<Entry>();

            Console.ReadLine();
            string line = Console.ReadLine();
            string groupingCol = args[0];
            string summarizeCol = args[1];
            
            while (!String.IsNullOrEmpty(line))
            {
                listOfItems.Add(new Entry(line.Split('\t')[0], line.Split('\t')[1], line.Split('\t')[2], Int32.Parse( line.Split('\t')[3])));
                line = Console.ReadLine();
            }

            EntryController controller = new EntryController(listOfItems, groupingCol, summarizeCol);
            controller.PrintList();
        }

    }
}
