using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectManagment.DAL;
using ProjectManagment.Models;

namespace ProjectManagment.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> userRepository;
        private IRepository<UserProject> userProjectRepository;
        public UserService(IRepository<User> userRepository, IRepository<UserProject> userProjectRepository)
        {
            this.userRepository = userRepository;
            this.userProjectRepository = userProjectRepository;
        }

        public List<UserProject> GetProjects(int userId)
        {
            return userProjectRepository.List().Where(x => x.UserId == userId).Include(x => x.Project).ToList();
        }

        public List<User> GetUsers()
        {
            return userRepository.List().ToList();
        }
    }
}