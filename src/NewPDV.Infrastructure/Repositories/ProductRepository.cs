using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities;
using NewPDV.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> List(ListParametersDto listParameters)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
