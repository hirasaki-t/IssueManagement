using Model.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.DB.Tables
{
    /// <summary>サインインテーブル</summary>
    public record SignIn
    {
        /// <summary>ユーザーID</summary>
        [Key, ForeignKey(nameof(User))]
        public int ID { get; set; }

        /// <summary>ユーザー</summary>
        public virtual User User { get; set; } = null!;

        /// <summary>サインインID</summary>
        public string SignInID { get; set; } = string.Empty;

        /// <summary>パスワード</summary>
        public string PassWord { get; set; } = string.Empty;
    }
}