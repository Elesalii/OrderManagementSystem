using OrderManagementSystem.Data.Model;
using OrderManagementSystem.Data.Repository;
using System.Text;

namespace OrderManagementSystem.Service
{
    public class OrderManagementService : IOrderManagementService
    {
        private readonly IOrderManagementRepository _orderManagementRepository;
        public OrderManagementService(IOrderManagementRepository orderManagementRepository)
        {
            _orderManagementRepository = orderManagementRepository;
        }

        public async Task<string> AddProduct(ProductModel productModel)
        {
            var result = await _orderManagementRepository.AddProduct(productModel);
            return result;
        }
        public async Task<string> AddCustomer(CustomerModel customerModel)
        {
            var result = await _orderManagementRepository.AddCustomer(customerModel);
            return result;
        }
        public List<ProductModel> GetProduct(ProductModel productModel)
        {
            var result =  _orderManagementRepository.GetProduct(productModel);
            return result;
        }
    }
}
