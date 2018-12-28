using NewsReleaseSystem.Models;
using System.Web.Mvc;
using System.Web.Script;

namespace NewsReleaseSystem.BLL.Authentication
{
    public static class Authenticator
    {
        private static CofeDbContext _context = new CofeDbContext();

        /// <summary>
        /// 在数据库中查找一个对象是否存在
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>该用户是否存在</returns>
        public static bool CheckUserExists(User user)
        {
            if (_context.Users.Find(user.UserId) == null)
            {
                return false;
            }
            return true;
        }
    }
}