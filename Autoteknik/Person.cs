using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public abstract class Person : IComparable<Person>
    {
        private int _id;
        private string _name;
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Person(int id, string name, string phone)
        {
            _id = id;
            _name = name;
            _phone = phone;
        }
        public override string ToString()
        {
            return $"Id: {_id} - Name: {_name} - Phone {_phone}";
        }
        //public string IdInfo()
        //{
        //    return $"Id {_id}";
        //}
        public int CompareTo(Person? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
