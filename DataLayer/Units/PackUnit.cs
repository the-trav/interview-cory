using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Units
{
    public class PackUnit : IUnitOfMeasure
    {
        public int Id => 2;

        public string Name => "Pack";

        public decimal Weight => 6.0m;

        public int SinglesPerUnit => 6;
    }
}
