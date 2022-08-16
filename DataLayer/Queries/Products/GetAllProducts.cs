using DataLayer.DTO;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries.Products
{
    public class GetAllProducts : IGet<List<Product>>
    {
        public List<Product> Get()
        {
            return new List<Product>();
        }
    }
}
