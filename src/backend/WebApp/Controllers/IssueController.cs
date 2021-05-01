using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>課題コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        public IssueController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        /// <summary>既存課題を取得</summary>
        /// <returns>課題一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Issue>> GetAsync() =>
            await dataService.GetIssueDatasAsync();

        /// <summary>新規課題を追加</summary>
        /// <param name="projectID">案件ID</param>
        /// <param name="userID">ユーザーID</param>
        /// <param name="issueStatuses">課題ステータス</param>
        /// <param name="title">タイトル</param>
        [HttpPost]
        public async Task AddAsync(int projectID, int userID, IssueStatuses issueStatuses, string title) =>
            await dataService.AddIssueDataAsync(projectID, userID, issueStatuses, title);

        /// <summary>既存課題を更新</summary>
        /// <param name="id">課題ID</param>
        /// <param name="issueStatuses">課題ステータス</param>
        /// <param name="title">課題タイトル</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, IssueStatuses issueStatuses, string title) =>
            await dataService.UpdateIssueDataAsync(id, issueStatuses, title);

        /// <summary>既存課題を削除</summary>
        /// <param name="id">課題ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await dataService.DeleteIssueDataAsync(id);
    }
}