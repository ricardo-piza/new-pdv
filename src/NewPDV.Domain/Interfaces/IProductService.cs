using NewPDV.Domain.Dtos;
using NewPDV.Domain.Entities;
using NewPDV.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPDV.Domain.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> Create(ProductDTO product);
        Task<ProductDTO> Update(ProductDTO product);
        Task<ProductDTO> Delete(Guid id);
        Task<ProductDTO> GetById(Guid id);
        Task<ProductDTO> GetByName(string name);
        Task<List<ProductDTO>> List(ListParametersDto listParameters);
    }
}
