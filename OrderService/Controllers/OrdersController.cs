using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderService.Model;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static readonly List<Order> Orders = new();
        private readonly HttpClient _httpClient;

        public OrdersController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ProductService");
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(Order order)
        {
            var product = await _httpClient.GetFromJsonAsync<dynamic>($"api/products/{order.ProductId}");
            if (product == null) return NotFound("Product not found");

            order.Id = Orders.Count + 1;
            order.TotalAmount = (decimal)product.price * order.Quantity;
            Orders.Add(order);
            return Ok(order);
        }
    }
}
