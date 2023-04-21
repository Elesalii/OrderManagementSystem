using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Data.Context;
using OrderManagementSystem.Data.Model;
using OrderManagementSystem.Service;
using System.Security.Claims;

namespace ECommerceItemDiscount.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderManagementController : ControllerBase
    {
        private readonly IOrderManagementService _orderManagementService;

        public OrderManagementController(IOrderManagementService orderManagementService)
        {
            _orderManagementService = orderManagementService;
        }

        [HttpPost("AddProduct")]
        public async Task<string> AddProduct(ProductModel productModel)
        {
          var result = await _orderManagementService.AddProduct(productModel);
          return result;
        }

        [HttpPost("AddCustomer")]
        public async Task<string> AddCustomer(CustomerModel customerModel)
        {
            var result = await _orderManagementService.AddCustomer(customerModel);
            return result;
        }
        [HttpGet("GetProductByBarcode")]
        public List<ProductModel> GetProduct([FromQuery] ProductModel productModel)
        {
            var result =  _orderManagementService.GetProduct(productModel);
            return result;
        }
    }
}