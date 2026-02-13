using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserActivityBrojIndeksaController : BaseCRUDController<UserActivityBrojIndeksaRESPONSE, UserActivityBrojIndeksaSOBJ, UserActivityBrojIndeksaINSERTREQUEST, UserActivityBrojIndeksaUPDATEREQUEST>
    {
        protected readonly IUserActivityBrojIndeksaService _service;
        public UserActivityBrojIndeksaController(IUserActivityBrojIndeksaService service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public override async Task<UserActivityBrojIndeksaRESPONSE> Create([FromBody] UserActivityBrojIndeksaINSERTREQUEST request)
        {
            return await _crudService.CreateAsync(request);
        }

        [HttpPut("{id}/inProgress")]
        public virtual async Task<UserActivityBrojIndeksaRESPONSE?> InProgress(int id)
        {
            return await _service.InProgress(id);
        }

        [HttpPut("{id}/completed")]
        public virtual async Task<UserActivityBrojIndeksaRESPONSE?> Completed(int id)
        {
            return await _service.Completed(id);
        }

        [HttpPut("{id}/cancelled")]
        public virtual async Task<UserActivityBrojIndeksaRESPONSE?> Cancelled(int id)
        {
            return await _service.Cancelled(id);
        }
        [HttpGet("{id}/allowed-actions")]
        public virtual List<string> AllowedActions(int id)
        {
            return _service.AllowedActions(id);
        }
    }
}
