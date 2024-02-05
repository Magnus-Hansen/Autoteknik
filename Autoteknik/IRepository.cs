using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public interface IRepository <T> where T : class
    {
        int Count { get; set; }

        void Add(T item);
        void Delete(T item);
        void printAll();
    }

}
