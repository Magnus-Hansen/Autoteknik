using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik.Tests
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void AddItem_NoException()
        {
            IRepository<Owner> ownerRepo = new Repository();
            Owner o = new Owner("title", 2, "name", "phone");
            int beforeResult = ownerRepo.Count;

            ownerRepo.Add(o);
            int afterResult = ownerRepo.Count;

            Assert.AreEqual(beforeResult + 1, afterResult);
        }
        [TestMethod]
        public void AddItem_Exception() 
        {
            IRepository<Owner> ownerRepo = new Repository();
            Owner o = new Owner("title", 2, "name", "phone");
            ownerRepo.Add(o);
            int beforeResult = ownerRepo.Count;

            ownerRepo.Add(o);
            int afterResult = ownerRepo.Count;

            Assert.AreNotEqual(beforeResult + 1, afterResult);
        }
        [TestMethod]
        public void RemoveItem_NoException() 
        {
            IRepository<Owner> ownerRepo = new Repository();
            Owner o = new Owner("title", 2, "name", "phone");
            ownerRepo.Add(o);
            int beforeResult = ownerRepo.Count;

            ownerRepo.Delete(o);
            int afterResult = ownerRepo.Count;

            Assert.AreEqual(beforeResult - 1, afterResult);
        }
        [TestMethod]
        public void RemoveItem_Exception()
        {
            IRepository<Owner> ownerRepo = new Repository();
            Owner o = new Owner("title", 2, "name", "phone");
            Owner o2 = new Owner("title", 3, "name", "phone");
            ownerRepo.Add(o);
            int beforeResult = ownerRepo.Count;

            ownerRepo.Delete(o2);
            int afterResult = ownerRepo.Count;

            Assert.AreNotEqual(beforeResult - 1, afterResult);
        }
    }
}
