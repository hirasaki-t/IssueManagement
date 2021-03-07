using Microsoft.EntityFrameworkCore;
using Model.Tables;
using System;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    public partial class DataService
    {
        /// <summary>ユーザーの一覧を取得する</summary>
        /// <returns>ユーザーの一覧</returns>
        public Task<User[]> GetUserAsync() => dataContext.Users.ToArrayAsync();
    }
}