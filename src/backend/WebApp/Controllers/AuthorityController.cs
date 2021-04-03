using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>権限コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class AuthorityController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>ロガー</summary>
        private readonly ILogger<AuthorityController> logger;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        /// <param name="logger">ロガー</param>
        public AuthorityController(IDataService dataService, ILogger<AuthorityController> logger)
        {
            this.dataService = dataService;
            this.logger = logger;
        }

        /// <summary>既存権限を取得</summary>
        /// <returns>権限一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Authority>> GetAsync() =>
            await dataService.GetAuthoritiesDatasAsync();
    }
}