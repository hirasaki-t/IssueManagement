using Microsoft.AspNetCore.Mvc;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>部門コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        public DepartmentController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        /// <summary>既存部門を取得</summary>
        /// <returns>部門一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Department>> GetAsync() =>
            await dataService.GetDepartmentDatasAsync();
    }
}