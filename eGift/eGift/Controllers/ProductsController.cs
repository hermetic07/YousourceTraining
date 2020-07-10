namespace Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Api.Extensions;
    using Api.Messages.Products;
    using eGift.Services.Product;
    using eGift.Services.Product.Models;

    /// <summary>
    /// Api Controllers should only depend on Services
    /// Controllers are kept thin containing only 2-3 lines of code
    /// Entry/Exit point of the application is the only responsibility that a controller/api should do
    /// Api Controllers accepts Web Models and transforms them to Service Models while both Models are mostly identical,
    /// the goal is to decouple class libraries.
    /// </summary>

    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> CreateProduct(CreateProductWebRequest webRequest)
        {
            var result = await this.service.CreateProductAsync(webRequest.AsRequest());
            return this.StatusCode(result.Code);
        }
    }
}
