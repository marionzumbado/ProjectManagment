using ProjectManagment.Models;
using System;
using System.Collections.Generic;

namespace ProjectManagment.DAL
{
    public class PMInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PMContext>
    {
        protected override void Seed(PMContext context)
        {
            var users = new List<User>
            {
                new User{Id =1, FirstName="Marion",LastName="Zumbado"},
                new User{Id =1, FirstName="Victor",LastName="Lopez"},
                new User{Id =1, FirstName="Naydelin",LastName="Zumbado"}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var projects = new List<Project>
            {
                new Project{Id=1,StartDate=new DateTime(2019,01,01),EndDate=new DateTime(2020,01,01),Credits=1,},
                new Project{Id=2,StartDate=new DateTime(2019,01,02),EndDate=new DateTime(2020,01,02),Credits=2,},
                new Project{Id=3,StartDate=new DateTime(2019,01,03),EndDate=new DateTime(2020,01,03),Credits=3,},
                new Project{Id=4,StartDate=new DateTime(2019,01,04),EndDate=new DateTime(2020,01,04),Credits=4,},
                new Project{Id=5,StartDate=new DateTime(2019,01,05),EndDate=new DateTime(2020,01,05),Credits=5,},
                new Project{Id=6,StartDate=new DateTime(2019,01,06),EndDate=new DateTime(2020,01,06),Credits=6,},
                new Project{Id=7,StartDate=new DateTime(2019,01,07),EndDate=new DateTime(2020,01,07),Credits=7,},
                new Project{Id=8,StartDate=new DateTime(2019,01,08),EndDate=new DateTime(2020,01,08),Credits=8,},
                new Project{Id=9,StartDate=new DateTime(2019,01,09),EndDate=new DateTime(2020,01,09),Credits=9,},
                new Project{Id=10,StartDate=new DateTime(2019,01,10),EndDate=new DateTime(2020,01,10),Credits=10,},
                new Project{Id=11,StartDate=new DateTime(2019,01,11),EndDate=new DateTime(2020,01,11),Credits=11,},
                new Project{Id=12,StartDate=new DateTime(2019,01,12),EndDate=new DateTime(2020,01,12),Credits=12,},
                new Project{Id=13,StartDate=new DateTime(2019,01,13),EndDate=new DateTime(2020,01,13),Credits=13,},
                new Project{Id=14,StartDate=new DateTime(2019,01,14),EndDate=new DateTime(2020,01,14),Credits=14,},
                new Project{Id=15,StartDate=new DateTime(2019,01,15),EndDate=new DateTime(2020,01,15),Credits=15,},
            };
            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();
            var usersProjects = new List<UserProject>
            {
                new UserProject{UserId=1,ProjectId=1,AssignedDate=new DateTime(2018,01,01),IsActive=true},
                new UserProject{UserId=1,ProjectId=2,AssignedDate=new DateTime(2019,02,02),IsActive=true},
                new UserProject{UserId=1,ProjectId=3,AssignedDate=new DateTime(2019,01,15),IsActive=false},
                new UserProject{UserId=1,ProjectId=4,AssignedDate=new DateTime(2017,01,01),IsActive=false},
                new UserProject{UserId=1,ProjectId=5,AssignedDate=new DateTime(2019,03,03),IsActive=true},
                new UserProject{UserId=2,ProjectId=6,AssignedDate=new DateTime(2018,01,01),IsActive=true},
                new UserProject{UserId=2,ProjectId=7,AssignedDate=new DateTime(2019,02,02),IsActive=false},
                new UserProject{UserId=2,ProjectId=8,AssignedDate=new DateTime(2019,03,01),IsActive=true},
                new UserProject{UserId=2,ProjectId=9,AssignedDate=new DateTime(2017,01,01),IsActive=true},
                new UserProject{UserId=2,ProjectId=10,AssignedDate=new DateTime(2019,03,03),IsActive=false},
                new UserProject{UserId=3,ProjectId=11,AssignedDate=new DateTime(2018,01,01),IsActive=false},
                new UserProject{UserId=3,ProjectId=12,AssignedDate=new DateTime(2019,02,02),IsActive=true},
                new UserProject{UserId=3,ProjectId=13,AssignedDate=new DateTime(2019,03,01),IsActive=true},
                new UserProject{UserId=3,ProjectId=14,AssignedDate=new DateTime(2017,01,01),IsActive=false},
                new UserProject{UserId=3,ProjectId=15,AssignedDate=new DateTime(2019,03,03),IsActive=true},
            };
            usersProjects.ForEach(s => context.UsersProjects.Add(s));
            context.SaveChanges();
        }
    }
}