using ProjectManagment.Models;
using System.Linq;

namespace ProjectManagment.DAL
{
    public class UserRepository : IRepository<User>
    {
        private readonly PMContext context;
        public UserRepository()
        {
            context = new PMContext();
        }

        public IQueryable<User> List()
        {
            return context.Users;
        }

    }
}