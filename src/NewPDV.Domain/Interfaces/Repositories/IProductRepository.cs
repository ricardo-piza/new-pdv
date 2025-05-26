using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Delete(Guid id);
        Task<Product> GetById(Guid id);
        Task<Product> GetByName(string name);
        Task<List<Product>> List(ListParametersDto listParameters);

    }
}
