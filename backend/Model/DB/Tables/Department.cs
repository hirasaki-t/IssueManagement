using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Model.Tables;

namespace Model.DB.Tables
{
    /// <summary>部門テーブル</summary>
    public class Department
    {
        /// <summary>ID</summary>
        [Key]
        public Departments ID { get; set; }

        /// <summary>部署名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>ユーザーを識別するためのキー情報の一覧</summary>
        public virtual ICollection<User> Users { get; set; } = null!;
    }
}
