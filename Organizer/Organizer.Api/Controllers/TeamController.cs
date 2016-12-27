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
    public class TeamController : ApiController
    {
        private TeamService teamService = new TeamService();

        [HttpGet]
        [Route("api/team/{teamId}")]
        public IHttpActionResult GetTeamByID(int teamID)
        {
            var ReturnedTeamByID = teamService.GetTeamByID(teamID);
            return this.Ok(ReturnedTeamByID);
        }

        [HttpPost]
        [Route("api/team/addNewTeam")]
        public IHttpActionResult AddTeam(string teamName)
        {
            teamService.AddNewTeam(teamName);
            return this.Ok();
        }

        [Route("api/team/delete/{teamId}")]
        [HttpDelete]
        public IHttpActionResult DeleteTeamByID(int teamID)
        {
            teamService.DeleteTeam(teamID);
            return this.Ok();
        }

        [Route("api/team/update/{teamId}")]
        [HttpPut]
        public IHttpActionResult UpdateTeamByID(int teamID, string newTeamName)
        {
            teamService.UpdateTeam(newTeamName, teamID);
            return this.Ok();
        }
    }
}
