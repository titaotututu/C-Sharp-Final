using System;
using System.Collections.Generic;
using System.Linq;
using TravelApi.Models;
using TravelApi.Repository;

namespace TravelApi.Services
{
    public interface ITravelService : IEntityService<Travel>
    {
        IQueryable<Travel> GetTravelByDate(string date);// 这里的date是string的
        Travel GetTravelById(long TravelId);
        IQueryable<Travel> GetTravelByUserId(long uid);
    }

    public class TravelService : EntityService<Travel>, ITravelService
    {
        public TravelService(TravelContext db) : base(db)
        {
        }

        public IQueryable<Travel> GetTravelByDate(String date)
        {
            return this.dbset.Where(t => t.CreatedAt== date).OrderByDescending(t => t.TravelId);
        }



        public Travel GetTravelById(long travelId)
        {
            return this.dbset.FirstOrDefault(t => t.TravelId == travelId);
        }

        public IQueryable<Travel> GetTravelByUserId(long uid)
        {
            return this.dbset.Where(t => t.UserId == uid).OrderByDescending(t => t.TravelId);
        }
    }
}
