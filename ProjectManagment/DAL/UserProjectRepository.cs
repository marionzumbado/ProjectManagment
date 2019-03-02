using ProjectManagment.Models;
using System.Linq;

namespace ProjectManagment.DAL
{
    public class UserProjectRepository : IRepository<UserProject>
    {
        private PMContext context;
        public UserProjectRepository()
        {
            this.context = new PMContext();
        }

        public IQueryable<UserProject> List()
        {
            return context.UsersProjects;
        }



    }
}