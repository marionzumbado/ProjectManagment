using AutoMapper;
using ProjectManagment.ExternalModels;
using ProjectManagment.Models;
using ProjectManagment.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectManagment.Controllers
{
    [RoutePrefix("user")]
    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route]
        public ActionResult Get()
        {
            IEnumerable<User> users = userService.GetUsers();
            IEnumerable<UserModel> userList = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
            return Json(userList, JsonRequestBehavior.AllowGet);
        }
    }
}