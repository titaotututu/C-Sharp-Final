using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Services;
using TravelApi.Models;
using TravelApi.Services;


namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class TravelController : ControllerBase
    {
        private readonly ITravelService _travelService;

        public TravelController(ITravelService travelService)
        {
            this._travelService = travelService;
        }

        // POST: api/travel
        [HttpPost]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/Travel 
        // 请求体：json { "TravelTitle": "Summer Vacation","TravelCity": "Beach City","TodoItems": [],"TravelTime": "2024-07-01","UserId": 1234 }
        // 成功的话会返回travelid：成功创建旅行。 失败（比如说用户不存在会报错具体信息
        public ActionResult<Travel> AddTravel(Travel travel)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");
                var query = _travelService.GetTravelByDate(date);
                if (query.Count() == 0)
                {
                    travel.TravelId = System.Convert.ToInt64(date + "0000");
                }
                else
                {
                    travel.TravelId = query.First().TravelId + 1;
                }
                _travelService.Add(travel);
                return Ok(new { message = "成功创建旅行。", travelId = travel.TravelId });
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        [HttpGet("get")]
        // 根据uid获取travel
        // 已测试，成功。不过由于创建的时候没有添加user和todoitem，所以是空的
        //示例： api http://localhost:5199/api/Travel/get?uid=1234 无请求体
        // 如果有travel会返回travel列表，如果没有travel就返回不存在旅行
        // 不过查询前要先确认uid存在。在api中似乎没有直接实现，可能需要在实际应用的时候调用user的api确认之后再实现

        public ActionResult<List<Travel>> GetTravel(long uid)
        {
            var query = _travelService.GetTravelByUserId(uid);
            var travelList = query.ToList();

            if (travelList.Count == 0)
            {
                return NotFound("不存在旅行");
            }

            return Ok(travelList);
        }

        [HttpPut("update")]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/Travel/update?travelId=1234 
        // 请求体：{ "TravelId":202405240000,"TravelTitle": "Vacation","TravelCity": "City","TodoItems": [],"TravelTime": "2024-07-01","UserId": 123 }
        //注意请求体要提供travelId。成功会返回text“成功修改travel”。失败会返回"The travel cannot be modified."
        public ActionResult<Travel> UpdateTravel(long travelId, Travel travel)
        {
            if (travelId != travel.TravelId)
            {
                return BadRequest("The travel cannot be modified.");
            }
            try
            {
                _travelService.Update(travel);
                return Ok("成功修改travel！");
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("delete")]
        // 已测试，成功。
        // 示例：api http://localhost:5199/api/Travel/delete?travelId=202405240000 无请求体
        // 成功会返回“已删除”，失败会返回"不存在该travel！"
        public ActionResult DeleteTravel(long travelId)
        {
            try
            {
                var travel = _travelService.GetTravelById(travelId);
                if (travel != null)
                {
                    _travelService.Delete(travel);
                    return Ok("已删除！");
                }
            }
            catch (Exception e)
            {
                return BadRequest("不存在该travel！");
            }
            return NoContent();
        }


        [HttpGet("{travelId}")]
        // 已测试，成功
        // 示例：api http://localhost:5199/api/Travel/202405240000
        // 没有请求体
        // 如果找到对应travel会返回travel对象，如果找不到则返回"Not found"
        public ActionResult<Travel> GetTravelById(long travelId)
        {
            try
            {
                var travel = _travelService.GetTravelById(travelId);
                if (travel != null)
                {
                    return Ok(travel);
                }
                else
                {
                    return NotFound("Not found");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}