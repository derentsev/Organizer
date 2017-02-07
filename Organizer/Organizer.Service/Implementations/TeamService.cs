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
    public class TeamService : ITeamServices
        
    {
        public TeamDTO GetTeamByID(int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                string teamName = Convert.ToString(db.team_table.Find(teamID));
                TeamDTO objTeamDTO = new TeamDTO();
                objTeamDTO = AutoMapper.Mapper.Map<TeamDTO>(teamName);
                return objTeamDTO;
            }
        }

        public void AddNewTeam(string newTeamName)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spCreateTeam(newTeamName);
            }
        }

        public void DeleteTeam(int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteTeamByID(teamID);
            }
        }


        public void UpdateTeam(string updateTeamName, int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spUpdateTeamByID(updateTeamName, teamID);
            }
        }
        
        public IEnumerable<string> GetAllTeams()
        {
            using (var db = new OrganizerDBEntities())
            {
                return db.spGetAllTeams();
            }
        }
    }
}
