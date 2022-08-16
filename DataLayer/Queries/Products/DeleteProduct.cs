using DataLayer.DTO;
using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Queries.Products
{
    public class DeleteProduct : IDelete
    {
        public bool Delete(int id)
        {
            return true;
        }
    }
}
