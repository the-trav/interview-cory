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
    public class PackagePackTests
    {
        private Package _packagePack;
        [TestInitialize]
        public void Initialize()
        {
            _packagePack = new Package(new PackUnit());
        }

        [TestMethod()]
        public void Pack_SixCases_ShouldHaveNoRemainer()
        {
            var result = _packagePack.Pack(36);
            Assert.AreEqual(0, result.UnitsRemaining);
            Assert.AreEqual(6, result.NumberOfPackages);

        }

        [TestMethod()]
        public void Pack_TwoPacks_ShouldHave2Remainer()
        {
            var result = _packagePack.Pack(14);
            Assert.AreEqual(2, result.UnitsRemaining);
            Assert.AreEqual(2, result.NumberOfPackages);

        }

        [TestMethod()]
        public void Pack_Zero_ShouldPackNone()
        {
            int numberOfUnits = 0;
            var result = _packagePack.Pack(numberOfUnits);
            Assert.AreEqual(0, result.UnitsRemaining);
            Assert.AreEqual(0, result.NumberOfPackages);

        }
    }

}
