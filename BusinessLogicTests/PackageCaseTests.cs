using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Units;

namespace BusinessLogic.Tests
{
    [TestClass()]
    public class PackageCaseTests
    {
        private Package _packageCase;
        [TestInitialize]
        public void Initialize()
        {
            _packageCase = new Package(new CaseUnit());

        }
        [TestMethod()]
        public void Pack_TwoCases_ShouldHave14Remainder()
        {
            var result = _packageCase.Pack(62);
            Assert.AreEqual(14, result.UnitsRemaining);
            Assert.AreEqual(2, result.NumberOfPackages);

        }

        [TestMethod()]
        public void Pack_LessThenCase_ShouldPackNone()
        {
            for (var units = 23; units >= 0; units--)
            {
                var result = _packageCase.Pack(units);
                Assert.AreEqual(units, result.UnitsRemaining);
                Assert.AreEqual(0, result.NumberOfPackages);

            }

        }
    }
}