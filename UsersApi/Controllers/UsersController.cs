using Microsoft.AspNetCore.Mvc;
using UsersApi.Data;
using UsersApi.Models;
using System;

namespace UsersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("api/create")]
        public ActionResult<string> Create(string userName, string name,string pass,string email, bool admin)
        {
            var userModel = new UsersModels();
            return userModel.Create(userName,name,pass,email,admin);
        }

        [HttpGet]
        [Route("api/delete")]
        public ActionResult<string> Delete(int id)
        { 
            var userModel = new UsersModels();
            return userModel.Delete(id);
        }

        [HttpGet]
        [Route("api/login")]
        public ActionResult<Users> Login(string userName, string pass)
        {         
            var userModel = new UsersModels();
            return userModel.Login(userName,pass);            
        }
    }
}
