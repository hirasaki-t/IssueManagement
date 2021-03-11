using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;

namespace WebApp.Controllers
{
    /// <summary>部門コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        /// <summary>既存部門を取得</summary>
        /// <returns>部門一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Department>> GetAsync()
        {
            return null;
        }
    }
}
