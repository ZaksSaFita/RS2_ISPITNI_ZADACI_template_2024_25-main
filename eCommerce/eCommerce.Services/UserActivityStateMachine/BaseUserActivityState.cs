using eCommerce.Model;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.Services.UserActivityStateMachine
{
    public class BaseUserActivityState
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly eCommerceDbContext _context;
        protected readonly IMapper _mapper;

        public BaseUserActivityState(IServiceProvider serviceProvider, eCommerceDbContext context, IMapper mapper)
        {
            _serviceProvider = serviceProvider;
            _context = context;
            _mapper = mapper;

        }
        public virtual async Task<UserActivityBrojIndeksaRESPONSE> CreateAsync(UserActivityBrojIndeksaINSERTREQUEST request)
        {
            throw new UserException("Not allowed");
        }

        public virtual async Task<UserActivityBrojIndeksaRESPONSE> UpdateAsync(int id, UserActivityBrojIndeksaUPDATEREQUEST request)
        {
            throw new UserException("Not allowed");
        }

        public virtual async Task<UserActivityBrojIndeksaRESPONSE> InProgress(int id)
        {
            throw new UserException("Not allowed");
        }

        public virtual async Task<UserActivityBrojIndeksaRESPONSE> Completed(int id)
        {
            throw new UserException("Not allowed");
        }

        public virtual async Task<UserActivityBrojIndeksaRESPONSE> Cancelled(int id)
        {
            throw new UserException("Not allowed");
        }


        public BaseUserActivityState GetActivityState(string stateName)
        {
            if (!stateName.EndsWith("State"))
            {
                stateName += "State";
            }

            switch (stateName)
            {
                case nameof(InitialUserActivityState):
                    return _serviceProvider.GetService<InitialUserActivityState>();

                case nameof(AssignedState):
                    return _serviceProvider.GetService<AssignedState>();

                case nameof(InProgressState):
                    return _serviceProvider.GetService<InProgressState>();

                case nameof(CompletedState):
                    return _serviceProvider.GetService<CompletedState>();

                case nameof(CancelledState):
                    return _serviceProvider.GetService<CancelledState>();

                default:
                    throw new Exception($"State {stateName} not defined");
            }
        }

        public virtual List<string> AllowedActions(int id)
        {
            throw new UserException("Metoda nije dozvoljena");
        }
    }
}
