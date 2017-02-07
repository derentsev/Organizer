using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.DAL;
using Organizer.Service;
using Organizer.Service.Interfaces;

namespace Service
{
    public class TeamTaskService : ITeamTaskService
    {
        public void InsertTeamTask(int teamID, int taskID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spInsertTeamTask(teamID, taskID);
            }
        }

        public void DeleteTeamTask(int taskID, int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteTeamTask(teamID, taskID);
            }
        }
    }
}
