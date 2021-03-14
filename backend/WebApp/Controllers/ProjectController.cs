using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>案件コントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {
        /// <summary>既存案件を取得</summary>
        /// <returns>案件一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Project>> GetAsync()
        {
            return null;
        }

        /// <summary>新規案件を追加</summary>
        /// <param name="projectStatusID">案件ステータスID</param>
        /// <param name="title">タイトル</param>
        /// <param name="update">更新日付</param>
        [HttpPost]
        public async Task AddAsync(int projectStatusID, string title, DateTime update)
        {
        }

        /// <summary>既存案件を更新</summary>
        /// <param name="id">案件ID</param>
        /// <param name="prijectStatusID">案件ステータスID</param>
        /// <param name="title">タイトル</param>
        /// <param name="update">更新日付</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, int prijectStatusID, string title, DateTime update)
        {
        }

        /// <summary>既存メッセージを削除</summary>
        /// <param name="id">案件ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
        }
    }
}