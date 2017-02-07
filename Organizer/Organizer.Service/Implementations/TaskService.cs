using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.DAL;
using Organizer.Service;
using AutoMapper;
using Utils;
using Organizer.Service.Interfaces;

namespace Service
{
    public class TaskService : ITaskService
    {
        public TaskDTO GetTaskByID(int taskID)
        {
            using ( var db = new OrganizerDBEntities())
            {
                var returnedTask = db.task_table.Find(taskID);
                TaskDTO objDTOTask = new TaskDTO();
                objDTOTask = AutoMapper.Mapper.Map<TaskDTO>(returnedTask);

                return objDTOTask;
            }            
        }
        
        public void AddNewTask(TaskDTO newTask)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spCreateTask(newTask.TaskTitle, newTask.TaskSubject, newTask.TaskStartDate, newTask.TaskEndDate,
                                         newTask.CreatorID, Convert.ToByte(newTask.TaskPriority), false, false, newTask.TaskCreationDate);
            }            
        }
        
        public void DeleteTask(int taskID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteTaskByID(taskID);
            }
        }

        
        public void UpdateTask(TaskDTO updateTask, int taskID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spUpdateTaskByID(taskID, updateTask.TaskTitle, updateTask.TaskSubject,
                                         updateTask.TaskStartDate, updateTask.TaskEndDate, updateTask.CreatorID,
                                         Convert.ToByte(updateTask.TaskPriority), updateTask.IsDeleted, updateTask.IsFinished, updateTask.TaskCreationDate);
            }            
        }
    }

    //Add Get All Tasks
}
