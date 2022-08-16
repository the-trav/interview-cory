using DataLayer.DTO;
using DataLayer.Interface;
using DataLayer.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries.Products
{
    public class GetProductByCode : IGet<Product>
    {
        private readonly string _name;

        public GetProductByCode(string name)
        {
            _name = name;
        }
        public Product Get()
        {
            //query db to get product by name
            return new Product
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
            };
        }
    }
}
