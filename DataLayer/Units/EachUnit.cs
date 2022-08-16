using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Units
{
    public class EachUnit : IUnitOfMeasure
    {
        public int Id => 3;

        public string Name => "Single";

        public decimal Weight => 1.0m;

        public int SinglesPerUnit => 1;
    }
}
