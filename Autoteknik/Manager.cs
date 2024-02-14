using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Manager : Person
    {
        private int _bonus;
        //private int Limit
        private const double _pct = 6.66;

        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public Manager(int id, string name, string phone) : base(id, name, phone)
        {
            _bonus = 250;
        }
    }
}
