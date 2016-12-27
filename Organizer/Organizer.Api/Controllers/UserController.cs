using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Organizer.Service;

namespace Organizer.Api.Controllers
{
    public class UserController : ApiController
    {
        private UserService userService = new UserService();

        [HttpGet]
        [Route("api/user/{userId}")]
        public IHttpActionResult GetUserByID(int userID)
        {
            var returnedUser = userService.GetUserByID(userID);
            return this.Ok(returnedUser);
        }

        [HttpPost]
        [Route("api/user/addNewUser")]
        public IHttpActionResult AddUser(UserDTO newUser)
        {
            userService.AddNewUser(newUser);
            return this.Ok();
        }

        [Route("api/user/delete/{userId}")]
        [HttpDelete]
        public IHttpActionResult DeleteUserByID(int userID)
        {
            userService.DeleteUser(userID);
            return this.Ok();
        }

        [Route("api/user/update/{userId}")]
        [HttpPut]
        public IHttpActionResult UpdateUserByID(int userID, string userEmail, string userPhoneNumber, string userName)
        {
            userService.UpdateUserEmail(userEmail, userID);
            userService.UpdateUsername(userName, userID);
            userService.UpdatePhoneNumber(userPhoneNumber, userID);
            return this.Ok();
        }
    }
}
