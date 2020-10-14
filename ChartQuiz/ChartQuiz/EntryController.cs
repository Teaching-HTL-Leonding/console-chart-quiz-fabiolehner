using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartQuiz
{
    class EntryController
    {
        private List<Entry> _list;
        private string _groupingCol;
        private string _summarizeCol;
        private int _maxVal;
        public EntryController(List<Entry> list, string groupingCol, string summarizeCol)
        {
            List = list;
            GroupingCol = groupingCol;
            SummarizeCol = summarizeCol;
            MaxVal = 0;
        }


        public List<Entry> List
        {
            get => _list;
            set => _list = value;
        }

        public string GroupingCol
        {
            get => _groupingCol;
            set => _groupingCol = value;
        }

        public string SummarizeCol
        {
            get => _summarizeCol;
            set => _summarizeCol = value;
        }

        public int MaxVal
        {
            get => _maxVal;
            set
            {
                _maxVal = value;
                foreach (var item in List)
                {
                    if (item.Attacks > _maxVal)
                    {
                        _maxVal = item.Attacks;
                    }
                }
            }
        }
        
     

        public void PrintList()
        {
            foreach (var entry in _list)
            {
                switch (GroupingCol.ToLower())
                {
                    case "country":
                        Console.Write($"{entry.Country,-50}");
                        PrintChart(entry);
                        break;
                    case "timeofday":
                        Console.Write($"{entry.DayTime,-50}");
                        PrintChart(entry);
                        break;
                    case "animal":
                        Console.Write($"{entry.Animal,- 50}");
                        PrintChart(entry);
                        break;
                    case "attacks":
                        Console.Write($"{entry.Attacks,-50}");
                        PrintChart(entry);
                        break;
                }
                Console.ResetColor();
            }
        }

        private void PrintChart(Entry entry)
        {
            if (SummarizeCol.ToLower() == "attacks")
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write($"{new string(' ', CalculatePercentage(entry.Attacks)), -5}\n");
            }
        }

        private int CalculatePercentage(int value)
        {
            return (int)Math.Round((double)value / MaxVal * 100);
        }
    }
}
