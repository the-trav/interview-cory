using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interface
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        List<IUnitOfMeasure> PackageConfigurations { get; set; }

    }
}
