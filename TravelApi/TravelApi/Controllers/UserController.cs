using TravelApi.Repository;
using TravelApi.Models;
using TravelApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Repository.TravelContext userDb;
        private readonly UserService userService;

        public UserController(Repository.TravelContext userDb)
        {
            this.userDb = userDb;
            userService = new UserService(userDb);
        }

        //用户登录
        [HttpGet]
        public ActionResult<string> CheckLogin(long id, long pwd)
        // 已测试，成功。
        // 示例 api：https://localhost:7119/api/User?id=1234&pwd=123456 无请求体
        // 成功的话返回id
        // 不成功返回text"不存在该用户或用户密码错误！"
        {
            var user = userService.CheckLogin(id, pwd);
            if (user == null)
            {

                return BadRequest("不存在该用户或用户密码错误！");
            }
            return Convert.ToString(user.UserId);
        }

        //增加用户
        [HttpPost]
        // 已测试，成功。
        // 示例：api https://localhost:7119/api/User 
        // 请求体：json格式：{ "UserId": 1234,"UserName": "wangyao","password": 123456 }
        // xml格式：好像不行，会报错
        // 成功的话返回整个user
        // 不成功返回“该用户已存在”
        public ActionResult<User> PostUser(User user)
        {
            try
            {
                if (userService.GetUser(user.UserId) == null)
                {
                    userService.AddUser(user);
                }
                else
                {
                    return BadRequest("该用户已经存在！");
                }
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return user;

        }

        //删除指定id用户
        [HttpDelete("{id}")]
        // 已测试，成功
        // 示例：api https://localhost:7119/api/User/1234 无请求体
        // 成功的话无返回值。
        // 不成功的话返回text：不存在该用户！
        public ActionResult DeleteUser(string id)
        {
            try
            {
                //删除user表里的user
                userService.RemoveUser(long.Parse(id));

            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }

        //修改指定id用户账号信息
        // 已测试，成功
        // 示例：api https://localhost:7119/api/User/123
        // 请求体：json：{"UserId": 123,"UserName": "duhuang2","password": 123456}
        // 修改成功的话没有返回值，不成功的话返回text"Id cannot be modified!"
        [HttpPut("{id}")]
        public ActionResult<User> ModifyUser(string id, User user)
        {
            if (long.Parse(id) != user.UserId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                userService.ModifyUser(user);
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }

        //根据用户id查找用户
        // 已测试，成功
        //示例： api https://localhost:7119/api/User/123 无请求体
        // 成功的话返回user
        // 不成功的话没有返回文本（建议可以加上）
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(string id)
        {
            User user;
            try
            {
                user = userService.GetUser(long.Parse(id));
                return user;
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }

        }

        //根据用户姓名查找用户
        // 已测试，成功、
        // 示例：api https://localhost:7119/api/User/name?name=duhuang 无请求体
        // 如果成功返回整个user，如果失败则返回text"未找到符合要求的用户！"

        [HttpGet("name")]
        public ActionResult<List<User>> GetUserByName(string name)
        {

            try
            {
                var users = userService.QueryUserByName(name);
                if (users.Count > 0)
                {
                    return users;
                }
                else
                {
                    return BadRequest("未找到符合要求的用户！");
                }
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}