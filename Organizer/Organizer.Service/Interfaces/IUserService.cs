using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer.Service.Interfaces
{
    public interface IUserService
    {
        UserDTO GetUserByID(int userID);
        void AddNewUser(UserDTO newUser);
        void DeleteUser(int userID);
        void UpdateUserEmail(string newEmail, int userID);
        void UpdateUsername(string newUsername, int userID);
        void UpdatePhoneNumber(string newPhoneNumber, int userID);
    }
}
