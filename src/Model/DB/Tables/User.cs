using Model.DB.Tables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Tables
{
    /// <summary>ユーザーテーブル</summary>
    public record User
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>部署ID</summary>
        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }

        /// <summary>部門</summary>
        public virtual Department Department { get; set; } = null!;

        /// <summary>権限ID</summary>
        [ForeignKey(nameof(Authority))]
        public Authorities AuthorityID { get; set; }

        /// <summary>権限</summary>
        public virtual Authority Authority { get; set; } = null!;

        /// <summary>サインインID</summary>
        [ForeignKey(nameof(SignIn))]
        public int SignInID { get; set; }

        /// <summary>サインイン</summary>
        public virtual SignIn SignIn { get; set; } = null!;

        /// <summary>名前</summary>
        public string Neme { get; set; } = string.Empty;

        /// <summary>メールアドレス</summary>
        public string Mail { get; set; } = string.Empty;

        /// <summary>課題を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Issue> Issues { get; set; } = null!;

        /// <summary>メッセージを識別するためのキー情報の一覧</summary>
        public virtual ICollection<Message> Messages { get; set; } = null!;
    }
}