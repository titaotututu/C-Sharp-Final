using TravelApi.Repository;
using TravelApi.Models;

namespace TravelApi.Services
{
	public class UserService
	{

		TravelContext dbContext;
		public UserService(TravelContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public void AddUser(User user)
		{

			dbContext.Users.Add(user);
			dbContext.SaveChanges();

		}


		public void RemoveUser(long userId)
		{
			var user = dbContext.Users.FirstOrDefault(x => x.UserId == userId);
			if (user != null)
			{
				dbContext.Users.Remove(user);
				dbContext.SaveChanges();
			}
			else
			{
				throw new ArgumentException("不存在该用户！");
			}

		}

		//根据userId查找用户
		public User GetUser(long userId)
		{
			return dbContext.Users.FirstOrDefault(x => x.UserId == userId);
		}


		//根据用户姓名查找用户
		public List<User> QueryUserByName(string username)
		{
			var query = dbContext.Users
				.Where(user => user.UserName == username);
			return query.ToList();
		}


		//修改用户信息
		public void ModifyUser(User newuser)
		{
			RemoveUser(newuser.UserId);
			AddUser(newuser);
		}


		//登录
		public User CheckLogin(long id, long pwd)
		{
			var user = dbContext.Users.FirstOrDefault(x => x.UserId == id
													&& x.password == pwd);
			return user;

		}




	}
}