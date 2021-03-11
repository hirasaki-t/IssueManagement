using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;

namespace WebApp.Controllers
{
    /// <summary>権限コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class AuthorityController : ControllerBase
    {
        /// <summary>既存権限を取得</summary>
        /// <returns>権限一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Authority>> GetAsync()
        {
            return null;
        }
    }
}
