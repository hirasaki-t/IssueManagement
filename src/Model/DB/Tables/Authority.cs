using Model.Tables;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    /// <summary>権限テーブル</summary>
    public record Authority
    {
        /// <summary>ID</summary>
        [Key]
        public Authorities ID { get; set; }

        /// <summary>権限名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>ユーザーを識別するためのキー情報の一覧</summary>
        public virtual ICollection<User> Users { get; set; } = null!;
    }
}