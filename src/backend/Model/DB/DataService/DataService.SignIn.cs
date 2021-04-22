using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <inheritdoc/>
    public partial class DataService
    {
        /// <inheritdoc/>
        public async Task<bool> CanSignInAsync(SignIn signIn)
        {
            // IDが存在しなければ無効
            if (!await dataContext.SignIns.AnyAsync(x => x.ID == signIn.ID))
                return false;

            // RandomNumberGeneratorを使用したソルトの生成
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // パスワードをハッシュ化
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: signIn.PassWord,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            // パスワードが一致しなければ無効
            if (!await dataContext.SignIns.AnyAsync(x => x.ID == signIn.ID && x.PassWord == hashed))
                return false;

            return true;
        }
    }
}