using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.DB.Tables;

namespace WebApp.Controllers
{
    /// <summary>メッセージコントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        /// <summary>既存メッセージを取得</summary>
        /// <param name="issueID">課題ID</param>
        /// <returns>課題IDに紐づくメッセージ一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Message>> GetAsync(int issueID)
        {
            return null;
        }

        /// <summary>新規メッセージを追加</summary>
        /// <param name="issueID">課題ID</param>
        /// <param name="userID">ユーザーID</param>
        /// <param name="message">投稿メッセージ</param>
        /// <param name="update">更新日付</param>
        [HttpPost]
        public async Task AddAsync(int issueID, int userID, string message, DateTime update)
        {
        }

        /// <summary>既存メッセージを更新</summary>
        /// <param name="id">ID</param>
        /// <param name="issueID">課題ID</param>
        /// <param name="userID">ユーザーID</param>
        /// <param name="message">投稿メッセージ</param>
        /// <param name="update">更新日付</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, int issueID, int userID, string message, DateTime update)
        {
        }

        /// <summary>既存メッセージを削除</summary>
        /// <param name="id">ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
        }
    }
}
