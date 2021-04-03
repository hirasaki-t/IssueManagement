using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>案件ステータスコントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class ProjectStatusController : ControllerBase
    {
        /// <summary>既存案件ステータスを取得</summary>
        /// <returns>案件ステータス一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<ProjectStatus>> GetAsync()
        {
            return null;
        }
    }
}