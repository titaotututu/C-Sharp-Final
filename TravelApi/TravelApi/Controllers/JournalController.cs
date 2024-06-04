using Microsoft.AspNetCore.Mvc;
using TravelApi.Services;
using TravelApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JournalController : ControllerBase
    {
        private readonly IJournalService _JournalService;
        private readonly ITravelService _travelService;
        private readonly ITodoItemService _todoItemService;
        public JournalController(IJournalService journalService, ITravelService travelService, ITodoItemService todoItemService)
        {
            this._JournalService = journalService;
            this._travelService = travelService;
            this._todoItemService = todoItemService;
        }
       
        [HttpPost]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/Journal 
        // 请求体：{ "Time": "2024-05-24T10:30:00"，"Title": "My Travel Journal","Weather": "Sunny","Emotion": "Happy",
        // "Description": "Today was a great day!","Picture": "https://example.com/image.jpg","UserId": 123,"TravelId": 202405240000}
        public ActionResult<Journal> AddJournal(Journal journal)
        {
            try
            {
                lock (_JournalService) // 使用锁定机制，确保线程安全
                {
                    string date = DateTime.Now.ToString("yyyyMMdd");
                    IQueryable<Journal> query = _JournalService.GetJournalByDate(date);
                    if (query.Count() == 0)
                    {
                        journal.JournalId = System.Convert.ToInt64(date + "0000");
                    }
                    else
                    {
                        journal.JournalId = query.OrderByDescending(j => j.JournalId).First().JournalId + 1;
                    }
                    _JournalService.Add(journal);
                }
                return journal;
            }
            catch (Exception e)
            {
                string errorMessage = e.Message;
                if (e.InnerException != null)
                {
                    errorMessage += " Inner Exception: " + e.InnerException.Message;
                }
                return BadRequest(errorMessage);
            }
        }

        //根据日记ID获取日志
        [HttpGet("get")]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/Journal/get?journalid=202405240000 无请求体
        // 成功则返回journal，失败返回404
        public ActionResult<Journal> GetJournal(long journalId)
        {
            var journal = _JournalService.GetJournalById(journalId);
            if (journal != null)
            {
                return journal;
            }
            else
            {
                return NotFound();
            }
        }

        //根据用户获取日志
        [HttpGet("getByUser")]
        public ActionResult<List<Journal>> GetJournalByUser(long userId)
        {
            IQueryable<Journal> query = _JournalService.GetJournalByUserId(userId);
            if (query.Count() == 0)
            {
                return new List<Journal>(); // 返回一个空列表
            }
            else
            {
                return query.ToList();
            }
        }

        [HttpPut("update")]
        // 已测试，成功。
        // 示例：api http://localhost:5199/api/Journal/update?journalId=202405240000
        // 请求体：{ "JournalId":202405240000,Time": "2024-05-24T10:30:00"，"Title": "My Travel Journal","Weather": "Sunny","Emotion": "Happy",
        // "Description": "Today was a great day!","Picture": "https://example.com/image.jpg","UserId": 123,"TravelId": 202405240000}
        public ActionResult<Journal> UpdateJournal(long journalId, Journal journal)
        {
            if (journalId != journal.JournalId)
            {
                return BadRequest("The Journal cannot be modified.");
            }
            try
            {
                _JournalService.Update(journal);
                return NoContent();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
        }

        [HttpDelete("delete")]
        // 已测试，成功。
        public ActionResult DeleteJournal(long journalId)
        {
            try
            {
                var journal = _JournalService.GetJournalById(journalId);
                if (journal != null)
                {
                    _JournalService.Delete(journal);
                    return Ok("已删除！");
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
