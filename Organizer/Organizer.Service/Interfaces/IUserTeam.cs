using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
    public interface IUserTeam
    {
        void InsertUserTeam(int userID, int teamID);
        void DeleteUserTeam(int userID, int teamID);
    }
}
