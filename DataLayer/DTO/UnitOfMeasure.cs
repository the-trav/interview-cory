using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTO
{
    public class UnitOfMeasure : IUnitOfMeasure
    {
        public UnitOfMeasure(int id, string name, decimal weight, int singlesPerUnit)
        {
            Id = id;
            Name = name;
            Weight = weight;
            SinglesPerUnit = singlesPerUnit;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public int SinglesPerUnit { get; set; }
    }
}
