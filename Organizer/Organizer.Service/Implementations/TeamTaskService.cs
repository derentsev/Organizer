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
        OrganizerDBEntities TeamTaskContext = new OrganizerDBEntities();

        public void InsertTeamTask(int teamID, int taskID)
        {
            TeamTaskContext.spInsertTeamTask(teamID, taskID);
        }

        public void DeleteTeamTask(int taskID, int teamID)
        {
            TeamTaskContext.spDeleteTeamTask(teamID, taskID);
        }
    }
}
