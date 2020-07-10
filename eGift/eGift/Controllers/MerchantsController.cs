namespace Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Api.Extensions;
    using Api.Messages.Merchant;
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

        [HttpPost]
        public async Task<IActionResult> GetMerchant([FromBody]GetMerchantWebRequest webRequest)
        {
            var result = await this.service.GetMerchantAsync(webRequest.AsRequest());

            return Ok(result);
        }

        public IActionResult GetMerchantRequest()
        {
            GetMerchantWebRequest webRequest = new GetMerchantWebRequest()
            {
                Data = new Merchant()
                {
                    MerchantId = Guid.Parse("333760CA-3A91-4278-AF73-46257EF7E0F1")
                }
            };

            return Ok(webRequest);
        }
    }
}
