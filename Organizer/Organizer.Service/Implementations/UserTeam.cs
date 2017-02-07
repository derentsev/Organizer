using Organizer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organizer.Service.Interfaces;

namespace Organizer.Service
{
    class UserTeam : IUserTeam
    {
        OrganizerDBEntities UserTeamContext = new OrganizerDBEntities();

        public void InsertUserTeam(int userID, int teamID)
        {
            using (var db = new OrganizerDBEntities())
            {
                   db.spInsertUserTeam(Convert.ToString(userID), teamID);
            }
        }

        public void DeleteUserTeam(int userID, int teamID)
        { 
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteUserTeam(Convert.ToString(userID), teamID);
            }
        }
    }
}
