using Model.Tables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    /// <summary>部門テーブル</summary>
    public record Department
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>部署名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>案件を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Project> Project { get; set; } = null!;

        /// <summary>ユーザーを識別するためのキー情報の一覧</summary>
        public virtual ICollection<User> User { get; set; } = null!;
    }
}