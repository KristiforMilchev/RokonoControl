using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Rokono_Control;
using Rokono_Control.DatabaseHandlers;
using Rokono_Control.Models;
using RokonoControl.Models;

namespace RokonoControl.Controllers
{
    public class BoardsController : Controller
    {
        
        public IActionResult Index(int projectId)
        {
            var currentUser = this.User;
            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            using(var context = new DatabaseController())
            {
                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["ProjectId"] = projectId;
                ViewData["WorkItemTypes"] = context.GetAllWorkItemTypes();
                ViewData["ProjectName"] = context.GetProjectName(projectId);

             }
            return View();
        }

        public IActionResult ProjectBacklog(int projectId, int boardId)
        {
            var currentUser = this.User;
            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            using(var context = new DatabaseController())
            {
                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["ProjectId"] = projectId;
                ViewData["WorkItemTypes"] = context.GetAllWorkItemTypes();
                ViewData["ProjectName"] = context.GetProjectName(projectId);
                ViewData["BoardId"] = boardId;

             }
            return View();
        }
        public IActionResult SprintBacklogs(int projectId, int boardId)
        {
            var currentUser = this.User;
            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            using (var context = new DatabaseController())
            {
                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["ProjectId"] = projectId;
                ViewData["WorkItemTypes"] = context.GetAllWorkItemTypes();
                ViewData["ProjectName"] = context.GetProjectName(projectId);
                ViewData["BoardId"] = boardId;

            }
            return View();
        }

        public IActionResult Sprints(int projectId, int iteration, int person)
        {
            var currentUser = this.User;
            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;
            using(var context = new DatabaseController())
            {
                ViewData["ProjectId"] = projectId;
                ViewData["WorkItemTypes"] = context.GetAllWorkItemTypes();
                ViewData["ProjectName"] = context.GetProjectName(projectId);
                ViewData["Iteration"] = iteration;
                ViewData["Person"] = person;
            }
            return View();
        }


        [HttpGet]
        public List<BindingCards> GetWorkItems(int projectId, int workItemType)
        {
            var result = new List<BindingCards>();
            using(var context = new DatabaseController())
            {
               result =context.GetProjectCards(projectId, workItemType);
            }
            return result;
        }
        [HttpPost]
        public List<OutgoingIterationModel> GetIterations([FromBody] IncomingIterationRequest request)
        {
            var result = new List<OutgoingIterationModel>();
            using (var context = new DatabaseController())
            {
                var dataResult = context.GetProjectIterations(request.ProjectId);
                dataResult.ForEach(x =>
                {
                    result.Add(new OutgoingIterationModel
                    {
                        Text = x.IterationName,
                        IconCss = "e-ddb-icons e-settings",
                        Url = $"/Boards/Sprints?projectId={request.ProjectId}&&workItemType=7&&iteration={x.Id}&&person={request.Iteration}"
                    });
                });
            }
            return result;
        }
        [HttpPost]
        public List<OutgoingIterationModel> GetPersons([FromBody] IncomingIterationRequest request)
        {
            var result = new List<OutgoingIterationModel>();
            using (var context = new DatabaseController())
            {
                var dataResult = new List<UserAccounts>();
                var currentUser = this.User;
                var email = currentUser.Claims.LastOrDefault().Value;
                var userRights = context.GetUserAccounts(int.Parse(email));
                if (userRights != null)
                {
                    result.Add(new OutgoingIterationModel
                    {
                        Text = "All",
                        IconCss = "e-ddb-icons e-settings",
                        Url = $"/Boards/Sprints?projectId={request.ProjectId}&&workItemType=7&&iteration={request.Iteration}&&person=0"
                    });
                    result.Add(new OutgoingIterationModel
                    {
                        Text = "@Mine",
                        IconCss = "e-ddb-icons e-settings",
                        Url = $"/Boards/Sprints?projectId={request.ProjectId}&&workItemType=7&&iteration={request.Iteration}&&person={userRights.Id}"
                    });
                    dataResult = context.GetProjectPerons(request.ProjectId);
                }
                dataResult.ForEach(x =>
                {
                    result.Add(new OutgoingIterationModel
                    {
                        Text = x.GitUsername,
                        IconCss = "e-ddb-icons e-settings",
                        Url = $"/Boards/Sprints?projectId={request.ProjectId}&&workItemType=7&&iteration={request.Iteration}&&person={x.Id}"
                    });
                });
            }
            return result;
        }
        
        [HttpPost]
        public List<BindingCards> GetSprints([FromBody] IncomingSprintRequest dataRequest)
        {
            var result = new List<BindingCards>();
            using(var context = new DatabaseController())
            {
                var currentUser = this.User;
                var email = currentUser.Claims.LastOrDefault().Value;
                var userRights = context.GetUserAccounts(int.Parse(email));
                if(userRights != null)
                    result = context.GetProjectSprints(dataRequest, userRights.ProjectRights == 1 ? true: false, userRights.Id);
            }
            return result;
        }

        [HttpPost]
        public bool ChangeWorkItemBoard([FromBody] IncomingCardRequest card)
        {
            using(var context = new DatabaseController())
            {
                context.ChangeWorkItemBoard(card);
            }
            return true;
        }

        [HttpGet]
        public bool LogRepository(string repoName)
        {
            Program.InitCron(repoName);
            return true;
        }
    }
}