using BusinessLogic;
using DataLayer.DTO;
using DataLayer.Interface;
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
    public class PackageSodaBottleTests
    {
        private PackageSodaBottle _packageSodaBottles;

        [TestInitialize]
        public void Initialize()
        {
            _packageSodaBottles = new PackageSodaBottle(new Product
            {
                Id = 1,
                Name = "Soda Bottle",
                Description = "I am a refreshing bottle of soda.",
                PackageConfigurations = new List<IUnitOfMeasure>
                    {
                        new CaseUnit(),
                        new PackUnit(),
                        new EachUnit()
                    }
            });

        }

        [TestMethod()]
        public void Pack_62Bottles_ShouldPack_2Cases_2Packs_2Eaches()
        {
            var results = _packageSodaBottles.Optimize(62);
            var groupedByPackages = results.GroupBy(i => i.SinglesPerUnit);
            foreach (var groupedByPackage in groupedByPackages)
            {
                Assert.AreEqual(2, groupedByPackage.Count());
            }
            Assert.AreEqual(6, results.Count());
            Assert.AreEqual(3, groupedByPackages.Count());
        }

        [TestMethod()]
        public void Pack_5Bottles_ShouldPack_5Eaches()
        {
            var results = _packageSodaBottles.Optimize(5);
            foreach (var package in results)
            {
                Assert.AreEqual(1, package.SinglesPerUnit);
            }
            Assert.AreEqual(5, results.Count());
        }

        [TestMethod()]
        public void Pack_6Bottles_ShouldPack_1Pack()
        {
            var results = _packageSodaBottles.Optimize(6);
            foreach (var package in results)
            {
                Assert.AreEqual(6, package.SinglesPerUnit);
            }
            Assert.AreEqual(1, results.Count());
        }
    }

}
