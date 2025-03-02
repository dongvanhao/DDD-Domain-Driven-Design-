using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.API.Service;
using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Repositories;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
            try
            {
                var orders = await _orderService.GetAllOrdersAsync();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi và trả về mã lỗi 500
                // Log the exception (ex) here
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Đã xảy ra lỗi khi lấy danh sách đơn hàng." });
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(string customerName, decimal totalPrice)
        {
            try
            {
                await _orderService.AddOrderAsync(customerName, totalPrice);
                return Ok(new { Message = "Đơn hàng đã tạo thành công!" });
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi và trả về mã lỗi 500
                // Log the exception (ex) here
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "Đã xảy ra lỗi khi tạo đơn hàng." });
            }
        }
    }
}
