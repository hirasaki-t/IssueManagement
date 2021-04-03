using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>課題ステータスコントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class IssueStatusController : ControllerBase
    {
        /// <summary>既存課題ステータスを取得</summary>
        /// <returns>課題ステータス一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<IssueStatus>> GetAsync()
        {
            return null;
        }
    }
}