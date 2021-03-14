using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>課題コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {
        /// <summary>既存課題を取得</summary>
        /// <returns>課題一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Issue>> GetAsync()
        {
            return null;
        }

        /// <summary>新規課題を追加</summary>
        /// <param name="issueStatusID">課題ステータスID</param>
        /// <param name="title">課題タイトル</param>
        /// <param name="update">更新日付</param>
        [HttpPost]
        public async Task AddAsync(int issueStatusID, string title, DateTime update)
        {
        }

        /// <summary>既存課題を更新</summary>
        /// <param name="id">課題ID</param>
        /// <param name="issueStatusID">課題ステータスID</param>
        /// <param name="title">課題タイトル</param>
        /// <param name="update">更新日付</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, int issueStatusID, string title, DateTime update)
        {
        }

        /// <summary>既存課題を削除</summary>
        /// <param name="id">課題ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
        }
    }
}