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
				throw new ArgumentException("�����ڸ��û���");
			}

		}

		//����userId�����û�
		public User GetUser(long userId)
		{
			return dbContext.Users.FirstOrDefault(x => x.UserId == userId);
		}


		//�����û����������û�
		public List<User> QueryUserByName(string username)
		{
			var query = dbContext.Users
				.Where(user => user.UserName == username);
			return query.ToList();
		}


		//�޸��û���Ϣ
		public void ModifyUser(User newuser)
		{
			RemoveUser(newuser.UserId);
			AddUser(newuser);
		}


		//��¼
		public User CheckLogin(long id, long pwd)
		{
			var user = dbContext.Users.FirstOrDefault(x => x.UserId == id
													&& x.password == pwd);
			return user;

		}




	}
}