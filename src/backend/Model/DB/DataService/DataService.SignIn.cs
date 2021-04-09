using Model.DB.Tables;
using System;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public Task<bool> CanSignInAsync(SignIn signIn)
        {
            // TODO:認証処理を実装する
            return Task.FromResult(new Random().Next(1, 3) == 1);
        }
    }
}