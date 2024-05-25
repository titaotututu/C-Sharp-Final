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
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            this._todoItemService = todoItemService;
        }

        //新建待办
        [HttpPost]
        // 已测试，成功。
        // 示例：api http://localhost:5199/api/TodoItem 
        // 请求体：{ "TravelId": 202405240000,"Time":"2024-05-24T00:00:00","Place":"武汉大学","Description":"Eating","IsCompleted":false }
        // 成功会返回“成功创建待办” 失败返回失败信息
        public ActionResult<TodoItem> AddTodo(TodoItem item)
        {
            try
            {
                IQueryable<TodoItem> query = _todoItemService.GetItemByTravel(item.TravelId);
                if (query.Count() != 0)
                {
                    item.ItemId = query.ToList().First().ItemId + 1;
                }
                else
                {
                    item.ItemId = item.TravelId * 100 + 1;
                }
                _todoItemService.Add(item);
                return Ok("成功创建待办！");
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return item;
        }

        //根据travelid获取待办
        [HttpGet("get")]
        // 已测试，成功。
        // 示例：api=http://localhost:5199/api/TodoItem/get?travelId=202405240000 无请求体
        // 找到了返回Item列表。找不到返回404
        public ActionResult<List<TodoItem>> GetRoute(long travelId)
        {
            IQueryable<TodoItem> query = _todoItemService.GetItemByTravel(travelId);
            if (query.Count() == 0)
            {
                return  new List<TodoItem>(); // 返回一个空列表
            }
            return query.ToList();
        }

        //更该待办信息
        [HttpPut("update")]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/TodoItem/update?itemid=20240524000001 
        // 请求体：{ "ItemId": 20240524000001,"Time": "2024-05-24T00:00:00", "Place": "湖北大学","Description": "Eating"，
        //"ComplicationNote": "Updated ComplicationNote", "Picture": "Updated Picture", "IsCompleted": true,"TravelId": 202405240000}
        public ActionResult<TodoItem> UpdateRoute(long itemid, TodoItem todo)
        {
            if (itemid != todo.ItemId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _todoItemService.Update(todo);
                return Ok("成功修改待办！");
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
        // 已测试，成功
        // 示例：api http://localhost:5199/api/TodoItem/delete?itemId=20240524000001 无请求体
        // 成功不返回内容，失败了返回错误信息
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
