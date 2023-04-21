using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Data.Context;
using OrderManagementSystem.Data.Model;

namespace OrderManagementSystem.Data.Repository
{
    public class OrderManagementRepository : IOrderManagementRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public OrderManagementRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<string> AddProduct(ProductModel productModel)
        {
            await _applicationDbContext.Products.AddAsync(productModel);
            await _applicationDbContext.SaveChangesAsync();
            return ("Product Added");
        }
        public async Task<string> AddCustomer(CustomerModel customerModel)
        {
            await _applicationDbContext.Customers.AddAsync(customerModel);
            await _applicationDbContext.SaveChangesAsync();
            return ("Customer Added");
        }
        public List<ProductModel> GetProduct(ProductModel productModel)
        {
            var result = new List<ProductModel>();
            result =  _applicationDbContext.Products.Where(p => p.Barcode == productModel.Barcode).ToList();
            return result;
        }
    }
}
