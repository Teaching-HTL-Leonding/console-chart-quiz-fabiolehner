using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartQuiz
{
    class Entry
    {
        private string _animal;
        private int _attacks;
        private string _country;
        private string _dayTime;
        
        public Entry(string country, string dayTime, string animal, int attacks)
        {
            _animal = animal;
            _attacks = attacks;
            _country = country;
            _dayTime = dayTime;
        }

        public string Animal
        {
            get => _animal;
            set => _animal = value;
        }

        public int Attacks
        {
            get => _attacks;
            set => _attacks = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string DayTime
        {
            get => _dayTime;
            set => _dayTime = value;
        }
    }
}
