using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;

namespace eCommerce.Services
{
    public interface IUserActivityBrojIndeksaService : ICRUDService<UserActivityBrojIndeksaRESPONSE, UserActivityBrojIndeksaSOBJ, UserActivityBrojIndeksaINSERTREQUEST, UserActivityBrojIndeksaUPDATEREQUEST>
    {
        Task<UserActivityBrojIndeksaRESPONSE> InProgress(int id);
        Task<UserActivityBrojIndeksaRESPONSE> Cancelled(int id);
        Task<UserActivityBrojIndeksaRESPONSE> Completed(int id);


        List<string> AllowedActions(int id);
    }
}
