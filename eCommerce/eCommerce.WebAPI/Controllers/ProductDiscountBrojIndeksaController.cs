using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDiscountBrojIndeksaController : BaseCRUDController<ProductDiscountBrojIndeksaRESPONSE, ProductDiscountBrojIndeksaSOBJ, ProductDiscountBrojIndeksaUPSERT, ProductDiscountBrojIndeksaUPSERT>
    {
        protected readonly IProductDiscountBrojIndeksaService _service;

        public ProductDiscountBrojIndeksaController(IProductDiscountBrojIndeksaService service) : base(service)
        {
            _service = service;
        }
    }
}
