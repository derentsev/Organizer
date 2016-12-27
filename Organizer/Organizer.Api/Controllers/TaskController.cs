using Organizer.Service;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Organizer.Api.Controllers
{
    public class TaskController : ApiController
    {
        private TaskService tasksService = new TaskService();

        [HttpGet]
        [Route("api/task/{taskId}")]
        public IHttpActionResult GetTaskByID(int taskID)
        {
            var ReturnedTaskByID = tasksService.GetTaskByID(taskID);           
            return this.Ok(ReturnedTaskByID);
        }

        [HttpPost]
        [Route("api/task/addnewtask")]
        public IHttpActionResult AddTask(TaskDTO newTask)
        {
            tasksService.AddNewTask(newTask);
            return this.Ok();
        }

        [Route("api/task/delete/{taskId}")]
        [HttpDelete]
        public IHttpActionResult DeleteTaskByID(int taskID)
        {
            tasksService.DeleteTask(taskID);
            return this.Ok();
        }

        [Route("api/task/update/{taskId}")]
        [HttpPut]
        public IHttpActionResult UpdateTaskByID(int taskID, TaskDTO newTaskInfo)
        {
            tasksService.UpdateTask(newTaskInfo, taskID);
            return this.Ok();
        }


    }
}
