using eCommerce.Model;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services.UserActivityStateMachine
{
    public class AssignedState : BaseUserActivityState
    {
        public AssignedState(IServiceProvider serviceProvider, eCommerceDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {

        }

        public override async Task<UserActivityBrojIndeksaRESPONSE> UpdateAsync(int id, UserActivityBrojIndeksaUPDATEREQUEST request)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();

            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);

        }

        public override async Task<UserActivityBrojIndeksaRESPONSE> InProgress(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.Include(x => x.ActivityBrojIndeksa).FirstOrDefaultAsync(x => x.Id == id);
            var dueDate = entity?.ActivityBrojIndeksa?.DueDate;
            if (DateTime.UtcNow > dueDate.Value)
            {
                throw new UserException("Nemoze DueDate istekao");
            }

            entity.Status = nameof(InProgressState).Replace("State", "");
            entity.Note = entity.Note + " -> InProgress";

            await _context.SaveChangesAsync();

            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);
        }

        public override async Task<UserActivityBrojIndeksaRESPONSE> Cancelled(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);
            entity.Status = nameof(CancelledState).Replace("State", "");
            entity.Note = entity.Note + "-> Cancelled";

            await _context.SaveChangesAsync();

            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);
        }

        public override List<string> AllowedActions(int id)
        {
            return new List<string>() { nameof(InProgress), nameof(UpdateAsync), nameof(Cancelled) };
        }

    }
}
