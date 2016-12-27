using Organizer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service
{
    class UserTeam
    {
        OrganizerDBEntities UserTeamContext = new OrganizerDBEntities();

        public void InsertUserTeam(int userID, int teamID)
        {
            UserTeamContext.spInsertUserTeam(Convert.ToString(userID), teamID);
        }

        public void DeleteUserTeam(int userID, int teamID)
        {
            UserTeamContext.spDeleteUserTeam(Convert.ToString(userID), teamID);
        }
    }

}
