using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Units;

namespace BusinessLogicTests
{
    [TestClass()]
    public class PackageEachTests
    {
        private Package _packageEach;
        [TestInitialize]
        public void Initialize()
        {
            _packageEach = new Package(new EachUnit());

        }

        [TestMethod()]
        public void Pack_60Singles_ShouldPack60()
        {
            int numberOfUnits = 60;
            var result = _packageEach.Pack(60);
            Assert.AreEqual(0, result.UnitsRemaining);
            Assert.AreEqual(numberOfUnits, result.NumberOfPackages);

        }

        [TestMethod()]
        public void Pack_Zero_ShouldPackNone()
        {
            int numberOfUnits = 0;
            var result = _packageEach.Pack(numberOfUnits);
            Assert.AreEqual(0, result.UnitsRemaining);
            Assert.AreEqual(0, result.NumberOfPackages);

        }

    }
}
