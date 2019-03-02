using ProjectManagment.Models;
using System.Collections.Generic;

namespace ProjectManagment.Services
{
    public interface IUserService
    {
        IEnumerable<UserProject> GetProjects(int userId);
        IEnumerable<User> GetUsers();
    }
}
