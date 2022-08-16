using BusinessLogic.DTO;
using BusinessLogic.Interface;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Package : IPackage
    {
        private readonly IUnitOfMeasure _unitOfMeasure;

        public Package(IUnitOfMeasure unitOfMeasure)
        {
            _unitOfMeasure = unitOfMeasure;
        }
        public PackageRemainder Pack(int numberOfUnits)
        {
            var result = new PackageRemainder();

            if (_unitOfMeasure.SinglesPerUnit > numberOfUnits)
            {
                result.UnitsRemaining = numberOfUnits;
                return result;
            }

            int numberOfPackages = numberOfUnits / _unitOfMeasure.SinglesPerUnit;
            int remainder = numberOfUnits % _unitOfMeasure.SinglesPerUnit;
            result.UnitsRemaining = remainder;
            result.NumberOfPackages = numberOfPackages;
            return result;
        }
    }
}
