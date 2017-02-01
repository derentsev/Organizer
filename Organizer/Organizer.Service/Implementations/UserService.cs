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
    public class UserService : IUserService
    {
        OrganizerDBEntities UserContext = new OrganizerDBEntities();

        public UserDTO GetUserByID(int userID)
        {
           
            var returnedUser = UserContext.AspNetUsers.Find(userID);
            //Return message for deleted user
            if (returnedUser.IsDeleted == true)
            {
                   
            }

            UserDTO objDTOUser = new UserDTO();
            objDTOUser.Email = returnedUser.Email;
            objDTOUser.EmailConfirmed = returnedUser.EmailConfirmed;
            objDTOUser.PasswordHash = returnedUser.PasswordHash;
            objDTOUser.PhoneNumber = returnedUser.PhoneNumber;
            objDTOUser.SecurityStamp = returnedUser.SecurityStamp;
            objDTOUser.UserName = returnedUser.UserName;

            return objDTOUser;
        }

        public void AddNewUser(UserDTO newUser)
        {
            //Add rest of the information
            UserContext.spCreateUser(newUser.UserName, newUser.Email);
        }

        public void DeleteUser(int userID)
        {
            UserContext.spDeleteUser(userID);
        }


        public void UpdateUserEmail(string newEmail, int userID)
        {
            UserContext.spUpdateUserEmail(userID, newEmail);
        }

        public void UpdateUsername(string newUsername, int userID)
        {
            UserContext.spUpdateUserNameByID(userID, newUsername);
        }

        public void UpdatePhoneNumber(string newPhoneNumber, int userID)
        {
            UserContext.spUpdateUserPhone(userID, newPhoneNumber);
        }
    }

    //AddGetAllUsers

}