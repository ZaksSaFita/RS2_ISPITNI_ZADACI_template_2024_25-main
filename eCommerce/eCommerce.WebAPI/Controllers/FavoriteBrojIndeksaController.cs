using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteBrojIndeksaController : BaseCRUDController<FavoriteBrojIndeksaRESPONSE, FavoriteBrojIndeksaSOBJ, FavoriteBrojIndeksaREQUEST, FavoriteBrojIndeksaREQUEST>
    {
        protected readonly IFavoriteBrojIndeksaService _service;
        public FavoriteBrojIndeksaController(IFavoriteBrojIndeksaService service) : base(service)
        {
            _service = service;
        }
    }
}
