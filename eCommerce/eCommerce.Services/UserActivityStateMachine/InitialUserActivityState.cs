using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Services.Database;
using MapsterMapper;

namespace eCommerce.Services.UserActivityStateMachine
{
    public class InitialUserActivityState : BaseUserActivityState
    {
        public InitialUserActivityState(IServiceProvider serviceProvider, eCommerceDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }

        public override async Task<UserActivityBrojIndeksaRESPONSE> CreateAsync(UserActivityBrojIndeksaINSERTREQUEST request)
        {

            var entity = new Database.UserActivityBrojIndeksa();
            _mapper.Map(request, entity);

            entity.Status = nameof(AssignedState).Replace("State", "");
            entity.Note = "Assigned";
            _context.UserActivityBrojIndeksa.Add(entity);
            await _context.SaveChangesAsync();


            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);
        }


        public override List<string> AllowedActions(int id)
        {
            return new List<string>() { nameof(CreateAsync) };
        }
    }
}
