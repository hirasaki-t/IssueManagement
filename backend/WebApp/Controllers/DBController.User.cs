using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Model.Tables;

namespace WebApp.Controllers
{
    public partial class DBController
    {
        [HttpGet("list/{userName}")]
        public List<User> GetUserList(string userName)
        {
            return null;   
        }

        [HttpPost("list/{userName}")]
        public List<User> SetUserList(string userName)
        {
            return null;
        }

        [HttpPut("list/{userName}")]
        public List<User> PutUserList(string userName)
        {
            return null;
        }

        [HttpDelete("list/{userName}")]
        public List<User> DeleteUserList(string userName)
        {
            return null;
        }
    }
}
