using OrderManagementSystem.Data.Model;

namespace OrderManagementSystem.Data.Repository
{
    public interface IOrderManagementRepository
    {
        public Task<string> AddProduct(ProductModel productModel);
        public Task<string> AddCustomer(CustomerModel customerModel);
        public List<ProductModel> GetProduct(ProductModel productModel);
    }
}
