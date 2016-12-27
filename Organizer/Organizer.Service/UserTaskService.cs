using Organizer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service
{
    class UserTaskService
    {
        OrganizerDBEntities UserTaskContext = new OrganizerDBEntities();

        public void InsertUserTask(int userID, int taskID)
        { 
            UserTaskContext.spInsertUserTask(Convert.ToString(userID), taskID);
        }

        public void DeleteUserTask(int userID, int teamID)
        {
            UserTaskContext.spDeleteUserTask(Convert.ToString(userID), teamID);
        }
    }
}
