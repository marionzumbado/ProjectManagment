using ProjectManagment.Models;
using System.Linq;

namespace ProjectManagment.DAL
{
    public class UserRepository : IRepository<User>
    {
        private PMContext context;
        public UserRepository()
        {
            this.context = new PMContext();
        }

        public IQueryable<User> List()
        {
            return context.Users;
        }

    }
}