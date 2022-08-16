using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Units
{
    public class CaseUnit : IUnitOfMeasure
    {
        public int Id => 1;

        public string Name => "Case";

        public decimal Weight => 24.0m;

        public int SinglesPerUnit => 24;
    }
}
