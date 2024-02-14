using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _list;
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Repository()
        {
            _list = new List<T>();
        }

        public void Add(T item)
        {
            if (item == null) throw new ArgumentNullException();

            if (!_list.Contains(item))
            {
                _list.Add(item);
                Count++;
            }
        }

        public void Delete(T item)
        {
            if (_list.Contains(item))
            {
                _list.Remove(item);
                Count--;
            }
        }
        public List<T> GetCustomOrdering(Comparison<T> comparison)
        {
            _list.Sort(comparison);
            return _list;
        }
        public void printAll()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
