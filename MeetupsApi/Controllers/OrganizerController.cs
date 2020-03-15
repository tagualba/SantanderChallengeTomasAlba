using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetupsApi.Models;
using MeetupsApi.Data;


namespace MeetupsApi.Controllers
{
    [ApiController]
    
    [Route("[controller]")]
    public class OrganizerController : ControllerBase
    {


        [HttpGet]        
        [Route("api/getAll")]
        public ActionResult<List<MeetupResponse>> GetAllMetups(int userId)
        {
            var metupModel = new MeetupModel();
            return metupModel.GetAll(userId);
        }

        [HttpGet]
        [Route("api/create")]
        public ActionResult<String> Create(int userOrganizer, string title,DateTime date,int guests)
        {
            var metupModel = new MeetupModel();
            return metupModel.Create( userOrganizer,  title,date ,guests);            
        }

        [HttpGet]
        [Route("api/cancel")]
        public ActionResult<String> Cancel(int id,int userId)
        {
            var metupModel = new MeetupModel();
            return metupModel.Cancel(id,userId);
        }

        [HttpGet]
        [Route("api/update")]
        public ActionResult<String> Update(string title,DateTime date,int id,int userId)
        {
            var metupModel = new MeetupModel();
            return metupModel.Update(id ,title,date,userId);
        }

        [HttpGet]
        [Route("api/delete")]
        public ActionResult<String> Delete(int id,int userId)
        {
            var metupModel = new MeetupModel();
            return metupModel.Delete(id,userId);

        }    
    }
}
