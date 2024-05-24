using System;
using System.Collections.Generic;
using System.Linq;
using TravelApi.Models;
using TravelApi.Repository;
namespace TravelApi.Services
{
    public interface ITodoItemService : IEntityService<TodoItem>
    {
        
        TodoItem GetItemById(long itemId);
        IQueryable<TodoItem> GetItemByTravel(long travelid);
    }
    public class TodoItemService : EntityService<TodoItem>, ITodoItemService
    {
        public TodoItemService(TravelContext db) : base(db)
        {
        }
        public TodoItem GetItemById(long itemId)
        {
            return this.dbset.FirstOrDefault(t => t.ItemId==itemId);
        }
        public IQueryable<TodoItem> GetItemByTravel(long travelid)
        {
            return this.dbset.Where(t => t.TravelId == travelid).OrderByDescending(t => t.ItemId);
        }
        
    }
}
