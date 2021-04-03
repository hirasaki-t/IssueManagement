using Microsoft.AspNetCore.Mvc;
using Model.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    /// <summary>ユーザーコントローラー</summary>
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        /// <summary>既存ユーザーを取得</summary>
        /// <param name="id">ユーザーID</param>
        /// <returns>ユーザーIDに紐づくユーザー一覧</returns>
        [HttpGet]
        public async Task<IEnumerable<User>> GetAsync(int id)
        {
            return null;
        }

        /// <summary>新規ユーザーを追加</summary>
        /// <param name="userName">登録するユーザー名</param>
        /// <param name="departmentID">登録する部署ID</param>
        /// <param name="authorityID">登録する権限ID</param>
        /// <param name="email">登録するメールアドレス</param>
        [HttpPost]
        public List<User> PostUserList(string userName, int departmentID, int authorityID, string email)
        {
            return null;
        }

        /// <summary>既存ユーザーを更新</summary>
        /// <param name="id">変更するユーザーID</param>
        /// <param name="departmentID">変更後の部署ID</param>
        /// <param name="authorityID">変更後の権限ID</param>
        /// <param name="email">変更後のメールアドレス</param>
        [HttpPut("{id}")]
        public List<User> PutUserList(int id, int departmentID, int authorityID, string email)
        {
            return null;
        }

        /// <summary>既存ユーザーを削除</summary>
        /// <param name="id">削除したいユーザーID</param>
        [HttpDelete("{id}")]
        public List<User> DeleteUserList(int id)
        {
            return null;
        }
    }
}