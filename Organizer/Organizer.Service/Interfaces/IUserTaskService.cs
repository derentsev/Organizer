using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
    public interface IUserTaskService
    {
        void InsertUserTask(int userID, int taskID);
        void DeleteUserTask(int userID, int teamID);
    }
}
