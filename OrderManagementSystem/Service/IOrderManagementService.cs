using OrderManagementSystem.Data.Model;

namespace OrderManagementSystem.Service
{
    public interface IOrderManagementService
    {
        public Task<string> AddProduct(ProductModel productModel);
        public Task<string> AddCustomer(CustomerModel customerModel);
        public List<ProductModel> GetProduct(ProductModel productModel);
    }
}
