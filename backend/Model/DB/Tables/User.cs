using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.DB.Tables;

namespace Model.Tables
{
    /// <summary>ユーザーテーブル</summary>
    public class User
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>部署ID</summary>
        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }

        /// <summary>権限ID</summary>
        [ForeignKey(nameof(Authority))]
        public int AuthorityID { get; set; }

        /// <summary>名前</summary>
        public string Neme { get; set; } = string.Empty;

        /// <summary>メールアドレス</summary>
        public string Mail { get; set; } = string.Empty;

        /// <summary>パスワード</summary>
        public string Password { get; set; } = string.Empty;

        /// <summary>部門</summary>
        public virtual Department Department { get; set; } = null!;

        /// <summary>権限</summary>
        public virtual Authority Authority { get; set; } = null!;

        /// <summary>メッセージを識別するためのキー情報の一覧</summary>
        public virtual ICollection<Message> Messages { get; set; } = null!;
    }
}