using ProjectManagment.Models;
using System.Linq;

namespace ProjectManagment.DAL
{
    public class UserProjectRepository : IRepository<UserProject>
    {
        private readonly PMContext context;
        public UserProjectRepository()
        {
            context = new PMContext();
        }

        public IQueryable<UserProject> List()
        {
            return context.UsersProjects;
        }



    }
}