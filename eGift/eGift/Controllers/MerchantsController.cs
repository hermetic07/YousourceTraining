namespace Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Api.Extensions;
    using Api.Messages.Merchant;
    using Egift.Services.Merchant;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;

    [EnableCors("AllowOrigin")]
    [Route("api/[controller]/[action]")]
    public class MerchantsController : ControllerBase
    {
        private readonly IMerchantService service;

        public MerchantsController(IMerchantService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> GetMerchants()
        {
            var result = await this.service.GetMerchantsAsync();
            return this.Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetMerchant([FromBody]GetMerchantWebRequest webRequest)
        {
            var result = await this.service.GetMerchantAsync(webRequest.AsRequest());

            return this.Ok(result);
        }
    }
}
