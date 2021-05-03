using Microsoft.AspNetCore.Mvc;
using Model.DB.DataService;
using Model.DB.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>メッセージコントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        /// <summary>データサービス</summary>
        private readonly IDataService dataService;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataService">データサービス</param>
        public MessageController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        /// <summary>既存メッセージを取得</summary>
        /// <param name="issueID">課題ID</param>
        /// <returns>課題IDに紐づくメッセージ一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<Message>> GetAsync(int issueID) =>
            await dataService.GetMessagesDataAsync(issueID);

        /// <summary>新規メッセージを追加</summary>
        /// <param name="issueID">課題ID</param>
        /// <param name="userID">ユーザーID</param>
        /// <param name="message">投稿メッセージ</param>
        [HttpPost]
        public async Task AddAsync(int issueID, int userID, string message) =>
            await dataService.AddMessageDataAsync(issueID, userID, message);

        /// <summary>既存メッセージを更新</summary>
        /// <param name="id">ID</param>
        /// <param name="userID">ユーザーID</param>
        /// <param name="message">投稿メッセージ</param>
        [HttpPut("{id}")]
        public async Task UpdateAsync(int id, int userID, string message) =>
            await dataService.UpdateMessageDataAsync(id, userID, message);

        /// <summary>既存メッセージを削除</summary>
        /// <param name="id">ID</param>
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id) =>
            await dataService.DeleteMessageDataAsync(id);
    }
}