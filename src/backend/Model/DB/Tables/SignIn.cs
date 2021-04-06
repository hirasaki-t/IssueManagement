using Model.Tables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    /// <summary>サインインテーブル</summary>
    public record SignIn
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>サインインID</summary>
        public string SignInID { get; set; } = string.Empty;

        /// <summary>パスワード</summary>
        public string PassWord { get; set; } = string.Empty;

        /// <summary>ユーザーを識別するためのキー情報の一覧</summary>
        public virtual ICollection<User> User { get; set; } = null!;
    }
}