using eCommerce.Model;
using eCommerce.Model.Responses;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services.UserActivityStateMachine
{
    public class InProgressState : BaseUserActivityState
    {
        public InProgressState(IServiceProvider serviceProvider, eCommerceDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }


        public override async Task<UserActivityBrojIndeksaRESPONSE> Cancelled(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.FindAsync(id);
            entity.Status = nameof(CancelledState).Replace("State", "");
            entity.Note = entity.Note + " -> Cancelled";

            await _context.SaveChangesAsync();

            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);
        }

        public override async Task<UserActivityBrojIndeksaRESPONSE> Completed(int id)
        {
            var entity = await _context.UserActivityBrojIndeksa.Include(x => x.ActivityBrojIndeksa).FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
            {
                throw new UserException("entity je null");
            }
            var reward = await _context.RewardRuleBrojIndeksa.Include(x => x.ActivityBrojIndeksa).FirstOrDefaultAsync(x => x.ActivityBrojIndeksaId == entity.ActivityBrojIndeksaId);

            var dueDate = entity?.ActivityBrojIndeksa?.DueDate;
            entity.Status = nameof(CompletedState).Replace("State", "");
            entity.Note = entity.Note + " -> Completed";
            entity.CompletedAt = DateTime.UtcNow;
            entity.NumberOfPoints = reward.NumberOfPoints;
            var maxDays = reward?.MaxDaysToComplete;
            var days = (dueDate.Value.Date - DateTime.UtcNow.Date).TotalDays;

            if (maxDays >= days)
            {
                entity.RewardTitle = reward.RewardTitle;
                entity.RewardedAt = DateTime.UtcNow;

            }

            await _context.SaveChangesAsync();

            return _mapper.Map<UserActivityBrojIndeksaRESPONSE>(entity);
        }

        public override List<string> AllowedActions(int id)
        {
            return new List<string>() { nameof(Completed), nameof(Cancelled) };
        }

    }
}
