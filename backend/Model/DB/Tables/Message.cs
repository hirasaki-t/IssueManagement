using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record Message
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>課題ID</summary>
        public int IssueID { get; set; }

        /// <summary>ユーザーID</summary>
        public int UserID { get; set; }

        /// <summary>投稿メッセージ</summary>
        public string PostMessage { get; set; } = string.Empty;

        /// <summary>更新日付</summary>
        public DateTime Update { get; set; }
    }
}
