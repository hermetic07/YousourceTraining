﻿namespace Api.Controllers
{
    using System.Threading.Tasks;
    using Api.Extensions;
    using Api.Messages.Products;
    using Egift.Services.Product;
    using Egift.Services.Product.Models;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Api Controllers should only depend on Services
    /// Controllers are kept thin containing only 2-3 lines of code
    /// Entry/Exit point of the application is the only responsibility that a controller/api should do
    /// Api Controllers accepts Web Models and transforms them to Service Models while both Models are mostly identical,
    /// the goal is to decouple class libraries.
    /// </summary>
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> GetProducts([FromBody] GetProductWebRequest webRequest)
        {
            var result = await this.service.GetProductsAsync(webRequest.AsRequest());
            return this.Ok(result);
        }

        public async Task<IActionResult> GetProduct([FromBody]GetProductWebRequest webRequest)
        {
            var result = await this.service.GetProductAsync(webRequest.AsRequest());

            return this.Ok(result);
        }
    }
}
