using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities.Dtos;
using NewPDV.Domain.Interfaces;
using NewPDV.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDTO> Create(ProductDTO product)
        {

            
        }

        public Task<ProductDTO> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDTO>> List(ListParametersDto listParameters)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDTO> Update(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
