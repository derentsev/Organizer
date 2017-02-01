using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
    public interface ITeamServices
    {

        string GetTeamByID(int teamID);
        void AddNewTeam(string newTeamName);
        void DeleteTeam(int teamID);
        void UpdateTeam(string updateTeamName, int teamID);
        IEnumerable<string> GetAllTeams();
    }
}
