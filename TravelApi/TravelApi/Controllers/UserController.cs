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

        //�û���¼
        [HttpGet]
        public ActionResult<string> CheckLogin(long id, long pwd)
        {
            var user = userService.CheckLogin(id, pwd);
            if (user == null)
            {

                return BadRequest("�����ڸ��û����û��������");
            }
            return Convert.ToString(user.UserId);
        }

        //�����û�
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
                    return BadRequest("���û��Ѿ����ڣ�");
                }
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return user;

        }

        //ɾ��ָ��id�û�
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(string id)
        {
            try
            {
                //ɾ��user�����user
                userService.RemoveUser(long.Parse(id));

            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }

        //�޸�ָ��id�û��˺���Ϣ
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

        //�����û�id�����û�
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

        //�����û����������û�
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
                    return BadRequest("δ�ҵ�����Ҫ����û���");
                }
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}