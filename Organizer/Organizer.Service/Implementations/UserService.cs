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
        public UserDTO GetUserByID(int userID)
        {
            using (var db = new OrganizerDBEntities())
            {
                var returnedUser = db.AspNetUsers.Find(userID);
                //Check if user is deleted and throw a message
                UserDTO objDTOUser = new UserDTO();
                objDTOUser = AutoMapper.Mapper.Map<UserDTO>(returnedUser);
                return objDTOUser;
            }
        }

        public void AddNewUser(UserDTO newUser)
        {
            //Add rest of the information
            using (var db = new OrganizerDBEntities())
            {
                db.spCreateUser(newUser.UserName, newUser.Email);
            }
        }

        public void DeleteUser(int userID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spDeleteUser(userID);
            }
        }

        public void UpdateUserEmail(string newEmail, int userID)
        {            
            using (var db = new OrganizerDBEntities())
            {
                db.spUpdateUserEmail(userID, newEmail);
            }
        }

        public void UpdateUsername(string newUsername, int userID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spUpdateUserNameByID(userID, newUsername);
            }
        }

        public void UpdatePhoneNumber(string newPhoneNumber, int userID)
        {
            using (var db = new OrganizerDBEntities())
            {
                db.spUpdateUserPhone(userID, newPhoneNumber);
            }
        }
    }

    //AddGetAllUsers

}