using DataLayer.DTO;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries.Products
{
    public class UpdateProduct : IUpdate<Product>
    {
        public Product Update(Product itemToUpdate)
        {
            return itemToUpdate;
        }
    }
}
