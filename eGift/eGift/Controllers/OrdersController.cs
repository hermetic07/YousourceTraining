using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Extensions;
using Api.Messages.Order;
using eGift.Services.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eGift.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService service;

        public OrdersController(IOrderService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderWebRequest webRequest)
        {
            var result = await this.service.CreateOrderAsync(webRequest.AsRequest());
            return this.StatusCode(result.Code);
        }

        public async Task<IActionResult> GetOrders()
        {
            var result = await this.service.GetOrdersAsync();
            return Ok(result);
        }

        public async Task<IActionResult> GetOrder([FromBody] GetOrderWebRequest webRequest)
        {
            var result = await this.service.GetOrderAsync(webRequest.AsRequest());

            return Ok(result);
        }
    }
}
