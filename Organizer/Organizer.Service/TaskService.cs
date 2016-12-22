﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.DAL;
using Organizer.Service;

namespace Service
{
    public class TaskService
    {
        OrganizerDBEntitiesUpdated TaskContext = new OrganizerDBEntitiesUpdated();

        public TaskDTO GetTaskByID(int taskID)
        {
            var returnedTask = TaskContext.task_table.Find(taskID);
            TaskDTO objDTOTask = new TaskDTO();
            objDTOTask.CreatorID = returnedTask.TaskCreatorID;
            objDTOTask.IsDeleted = returnedTask.TaskIsDeleted;
            objDTOTask.IsFinished = returnedTask.TaskIsFinished;
            objDTOTask.TaskCreationDate = returnedTask.TaskCreationDate;
            objDTOTask.TaskEndDate = returnedTask.TaskEndDate;
            objDTOTask.TaskPriority = returnedTask.TaskPriority;
            objDTOTask.TaskStartDate = returnedTask.TaskStartDate;
            objDTOTask.TaskSubject = returnedTask.TaskSubject;
            objDTOTask.TaskTitle = returnedTask.TaskTitle;
            
            return objDTOTask;
        }
        
        public void AddNewTask(TaskDTO newTask)
        {
            TaskContext.spCreateTask(newTask.TaskTitle, newTask.TaskSubject, newTask.TaskStartDate, newTask.TaskEndDate,
                                     newTask.CreatorID, Convert.ToByte(newTask.TaskPriority), false, false, newTask.TaskCreationDate);
        }
        
        public void DeleteAuthor(int taskID)
        {
            TaskContext.spDeleteTaskByID(taskID);
        }

        
        public void UpdateAuthor(TaskDTO updateTask, int taskID)
        {
            TaskContext.spUpdateTaskByID(taskID, updateTask.TaskTitle, updateTask.TaskSubject, 
                                         updateTask.TaskStartDate, updateTask.TaskEndDate, updateTask.CreatorID,
                                         Convert.ToByte(updateTask.TaskPriority), updateTask.IsDeleted, updateTask.IsFinished, updateTask.TaskCreationDate);
        }
    }
}