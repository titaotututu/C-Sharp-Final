using TravelApi.Repository;
using TravelApi.Models;

namespace TravelApi.Services
{
    public interface IJournalService : IEntityService<Journal>
    {
        IQueryable<Journal> GetJournalByDate(string date);
        Journal GetJournalById(long journalId);
        IQueryable<Journal> GetJournalByUserId(long uid);
    }

    public class JournalService : EntityService<Journal>, IJournalService
    {
        public JournalService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Journal> GetJournalByDate(string date)
        {
            return this.dbset.Where(d => d.JournalId.ToString().StartsWith(date)).OrderBy(d => d.JournalId);
        }

        public Journal GetJournalById(long journalId)
        {
            return this.dbset.FirstOrDefault(t => t.JournalId == journalId);
        }
        
        public IQueryable<Journal> GetJournalByUserId(long uid)
        {
            return this.dbset.Where(d => d.UserId == uid).OrderByDescending(d => d.Time);
        }
    }
}
