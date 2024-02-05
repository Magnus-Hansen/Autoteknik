using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class OwnerRepository : IRepository<Owner>
    {
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public OwnerRepository()
        {
            
        }

        public void Add(Owner item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Owner item)
        {
            throw new NotImplementedException();
        }

        public void printAll()
        {
            throw new NotImplementedException();
        }
    }
}
