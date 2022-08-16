using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IUnitOfMeasure
    {
        int Id { get; }
        string Name { get; }
        decimal Weight { get; }
        int SinglesPerUnit { get; }

    }
}
