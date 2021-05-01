using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>案件コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        public ProjectController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        /// <summary>既存案件を取得</summary>
        /// <returns>案件一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Project>> GetAsync() =>
            await dataService.GetProjectDatasAsync();

        /// <summary>新規案件を追加</summary>
        /// <param name="departmentIDs">部門ID</param>
        /// <param name="projectStatuses">案件ステータス</param>
        /// <param name="title">タイトル</param>
        [HttpPost]
        public async Task AddAsync(int[] departmentIDs, ProjectStatuses projectStatuses, string title) =>
            await dataService.AddProjectDataAsync(departmentIDs, projectStatuses, title);

        /// <summary>既存案件を更新</summary>
        /// <param name="id">ID</param>
        /// <param name="departmentIDs">部門ID</param>
        /// <param name="projectStatuses">案件ステータス</param>
        /// <param name="title">タイトル</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, int[] departmentIDs, ProjectStatuses projectStatuses, string title) =>
            await dataService.UpdateProjectDataAsync(id, departmentIDs, projectStatuses, title);

        /// <summary>既存メッセージを削除</summary>
        /// <param name="id">ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await dataService.DeleteProjectDataAsync(id);
    }
}