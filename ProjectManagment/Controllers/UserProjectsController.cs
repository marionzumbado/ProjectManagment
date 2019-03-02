using AutoMapper;
using ProjectManagment.ExternalModels;
using ProjectManagment.Models;
using ProjectManagment.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjectManagment.Controllers
{
    [RoutePrefix("user")]
    public class UserProjectsController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserProjectsController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("{userId}/projects")]
        public ActionResult GetProjects(int userId)
        {
            IEnumerable<UserProject> userProjects = userService.GetProjects(userId);
            IEnumerable<ProjectModel> projects = Mapper.Map<IEnumerable<UserProject>, List<ProjectModel>>(userProjects);
            return Json(projects, JsonRequestBehavior.AllowGet);
        }
    }
}