using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.DAL;
using Organizer.Service;

namespace Service
{
    public class TeamService
        
    {
        OrganizerDBEntities TeamContext = new OrganizerDBEntities();

        public string GetTeamByID(int teamID)
        {
            //If not working use DTO
            return  Convert.ToString(TeamContext.team_table.Find(teamID));
           
        }

        public void AddNewTeam(string newTeamName)
        {
            TeamContext.spCreateTeam(newTeamName);
        }

        public void DeleteTeam(int teamID)
        {
            TeamContext.spDeleteTeamByID(teamID);
        }


        public void UpdateTeam(string updateTeamName, int teamID)
        {
            TeamContext.spUpdateTeamByID(updateTeamName, teamID);
        }
        
        public IEnumerable<string> GetAllTeams()
        {
           return TeamContext.spGetAllTeams();
        }
    }
}
