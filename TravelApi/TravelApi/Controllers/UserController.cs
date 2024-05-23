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
        [HttpGet("name")]
        public ActionResult<List<User>> GetUserByName(string name)
        {

            try
            {
                var users = userService.QueryUserByName(name);
                if (users != null)
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