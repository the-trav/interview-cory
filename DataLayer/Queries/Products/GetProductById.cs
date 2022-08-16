using DataLayer.DTO;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries.Products
{
    public class GetProductById : IGet<Product>
    {
        private readonly int _id;

        public GetProductById(int id)
        {
            _id = id;
        }
        public Product Get()
        {
            return new Product();
        }
    }
}
