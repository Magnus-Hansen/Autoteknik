using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Mechanics : Person
    {
		private string _education;

		public string Education
		{
			get { return _education; }
			set { _education = value; }
		}

        public Mechanics(string education, int id, string name, string phone) : base(id, name, phone)
        {
            _education = education;
        }
        //public override string IdInfo()
        //{
        //    return Id + "Internal";
        //}
    }
}
