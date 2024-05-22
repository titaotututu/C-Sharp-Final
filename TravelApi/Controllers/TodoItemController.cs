using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Services;
using TravelApi.Models;
namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/xml")]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            this._todoItemService = todoItemService;
        }

        //新建待办
        [HttpPost]
        public ActionResult<TodoItem> AddTodo(TodoItem item)
        {
            try
            {
                IQueryable<TodoItem> query = _todoItemService.GetItemByTravel(item.Travel.TravelId);
                if (query.Count() != 0)
                {
                    item.ItemId = query.ToList().First().ItemId + 1;
                }
                else
                {
                    item.ItemId = item.Travel.TravelId * 100 + 1;
                }
                _todoItemService.Add(item);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return task;
        }

        //根据travelid获取待办
        [HttpGet("get")]
        public ActionResult<List<TodoItem>> GetRoute(long travelId)
        {
            IQueryable<TodoItem> query = _todoItemService.GetItemByTravel(travelId);
            if (query == null)
            {
                return NotFound();
            }
            return query.ToList();
        }

        //更该待办信息
        [HttpPut("update")]
        public ActionResult<TodoItem> UpdateRoute(long itemid, TodoItem todo)
        {
            if (itemid != todo.ItemId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _todoItemService.Update(todo);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        //按照id删除待办
        [HttpDelete("delete")]
        public ActionResult DeleteRoute(long itemId)
        {
            try
            {
                var todo = _todoItemService.GetItemById(itemId);
                if (todo != null)
                {
                    _todoItemService.Delete(todo);
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
