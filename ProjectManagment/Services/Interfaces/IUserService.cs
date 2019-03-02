using ProjectManagment.Models;
using System.Collections.Generic;

namespace ProjectManagment.Services
{
    public interface IUserService
    {
        List<UserProject> GetProjects(int userId);
        List<User> GetUsers();
    }
}
