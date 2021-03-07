using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Tables
{
    /// <summary>ユーザーテーブル</summary>
    public sealed record User
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>部署ID</summary>
        public int DepartmentID { get; set; }

        /// <summary>権限ID</summary>
        public int AuthorityID { get; set; }

        /// <summary>名前</summary>
        public string Neme { get; set; } = string.Empty;

        /// <summary>メールアドレス</summary>
        public string Mail { get; set; } = string.Empty;

        /// <summary>パスワード</summary>
        public string Password { get; set; } = string.Empty;
    }
}