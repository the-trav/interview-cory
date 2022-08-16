using BusinessLogic.Interface;
using DataLayer.DTO;
using DataLayer.Interface;

namespace BusinessLogic
{
    public class PackageSodaBottle : IOptimizePackaging
    {
        private readonly IProduct _product;

        public PackageSodaBottle(IProduct product)
        {
            _product = product;
            _product.PackageConfigurations.OrderByDescending(i => i.SinglesPerUnit).ToList();
        }

        public List<IUnitOfMeasure> Optimize(int numberOfUnits)
        {
            var unitsForSodaBottle = new List<IUnitOfMeasure>();

            foreach (var unitOfMeasure in _product.PackageConfigurations)
            {
                if (unitOfMeasure.SinglesPerUnit > numberOfUnits)
                {
                    continue;
                }

                var package = new Package(unitOfMeasure);
                var result = package.Pack(numberOfUnits);
                numberOfUnits = result.UnitsRemaining;

                for (int i = 0; i < result.NumberOfPackages; i++)
                {
                    var newUnitOfMeasure = new UnitOfMeasure(unitOfMeasure.Id, unitOfMeasure.Name, unitOfMeasure.Weight, unitOfMeasure.SinglesPerUnit);
                    unitsForSodaBottle.Add(newUnitOfMeasure);
                }
            }

            return unitsForSodaBottle;
        }

    }
}