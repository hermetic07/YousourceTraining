namespace Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Api.Extensions;
    using Api.Messages.Products;
    using eGift.Services.Merchant;
    using eGift.Services.Merchant.Models;
    using System;
    using eGift.Services.Merchant.Messages;

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
            return Ok(result);
        }

        public async Task<IActionResult> GetMerchant()
        {
            Merchant merchant = new Merchant()
            {
                MerchantId = Guid.Parse("333760CA-3A91-4278-AF73-46257EF7E0F1")
            };

            GetMerchantRequest getMerchantRequest = new GetMerchantRequest()
            {
                Merchant = merchant
            };

            var result = await this.service.GetMerchantAsync(getMerchantRequest);
            return Ok(result);
        }
    }
}
