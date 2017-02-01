using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
     public interface ITaskService
    {
        TaskDTO GetTaskByID(int taskID);
        void AddNewTask(TaskDTO newTask);
        void DeleteTask(int taskID);
        void UpdateTask(TaskDTO updateTask, int taskID);

    }
}
