using eCommerce.Services.Database;
using MapsterMapper;

namespace eCommerce.Services.UserActivityStateMachine
{
    public class CancelledState : BaseUserActivityState
    {
        public CancelledState(IServiceProvider serviceProvider, eCommerceDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }
        public override List<string> AllowedActions(int id)
        {
            return new List<string>();
        }
    }
}
