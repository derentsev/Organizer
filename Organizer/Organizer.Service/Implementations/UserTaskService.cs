using Organizer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Service.Interfaces;

namespace Organizer.Service
{
    class UserTaskService : IUserTaskService
    {
        public void InsertUserTask(int userID, int taskID)
        { 
            using (var db = new OrganizerDBEntities())
            {
                db.spInsertUserTask(Convert.ToString(userID), taskID);
            }
        }

        public void DeleteUserTask(int userID, int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteUserTask(Convert.ToString(userID), teamID);
            }
        }
    }
}
