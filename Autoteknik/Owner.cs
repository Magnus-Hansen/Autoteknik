using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Owner : Person
    {
		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

        public Owner(string title, int id, string name, string phone) : base(id, name, phone)
        {
            _title = title;
        }
        //public override string IdInfo() 
        //{
        //    return Id + "Owner";
        //}
    }
}
