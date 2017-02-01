using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
    public interface ITeamTaskService
    {
        void InsertTeamTask(int teamID, int taskID);
        void DeleteTeamTask(int taskID, int teamID);
    }
}
