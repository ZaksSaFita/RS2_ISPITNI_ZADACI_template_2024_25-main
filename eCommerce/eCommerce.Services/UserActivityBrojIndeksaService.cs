using eCommerce.Model;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using eCommerce.Services.UserActivityStateMachine;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class UserActivityBrojIndeksaService : BaseCRUDService<UserActivityBrojIndeksaRESPONSE, UserActivityBrojIndeksaSOBJ, Database.UserActivityBrojIndeksa, UserActivityBrojIndeksaINSERTREQUEST, UserActivityBrojIndeksaUPDATEREQUEST>, IUserActivityBrojIndeksaService
    {
        protected readonly BaseUserActivityState _baseState;

        public UserActivityBrojIndeksaService(eCommerceDbContext context, IMapper mapper, BaseUserActivityState state) : base(context, mapper)
        {
            _baseState = state;
        }


        protected override IQueryable<UserActivityBrojIndeksa> ApplyFilter(IQueryable<UserActivityBrojIndeksa> query, UserActivityBrojIndeksaSOBJ search)
        {
            query = query.Include(x => x.User).Include(x => x.ActivityBrojIndeksa);
            if (!string.IsNullOrEmpty(search.Status))
            {
                query = query.Where(x => x.Status == search.Status);
            }


            return base.ApplyFilter(query, search);
        }



        public override async Task<UserActivityBrojIndeksaRESPONSE> CreateAsync(UserActivityBrojIndeksaINSERTREQUEST request)
        {
            var baseState = _baseState.GetActivityState(nameof(InitialUserActivityState));
            var result = await baseState.CreateAsync(request);

            return result;

        }

        public override async Task<UserActivityBrojIndeksaRESPONSE?> UpdateAsync(int id, UserActivityBrojIndeksaUPDATEREQUEST request)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);

            if (entity == null)
            {
                throw new UserException("activity not found");
            }
            var baseState = _baseState.GetActivityState(entity.Status);
            return await baseState.UpdateAsync(id, request);

        }

        public async Task<UserActivityBrojIndeksaRESPONSE> InProgress(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);
            var baseState = _baseState.GetActivityState(entity.Status);

            return await baseState.InProgress(id);
        }


        public async Task<UserActivityBrojIndeksaRESPONSE> Completed(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);
            var baseState = _baseState.GetActivityState(entity.Status);

            return await baseState.Completed(id);
        }

        public async Task<UserActivityBrojIndeksaRESPONSE> Cancelled(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);
            var baseState = _baseState.GetActivityState(entity.Status);

            return await baseState.Cancelled(id);
        }

        public List<string> AllowedActions(int id)
        {
            if (id <= 0)
            {
                var initialBaseState = _baseState.GetActivityState("InitialUserActivityState");
                return initialBaseState.AllowedActions(id);
            }

            var entity = _context.UserActivityBrojIndeksa.Find(id);
            if (entity == null)
            {
                throw new UserException("Activity not found");
            }
            var baseState = _baseState.GetActivityState(entity.Status);
            return baseState.AllowedActions(id);
        }

    }
}
