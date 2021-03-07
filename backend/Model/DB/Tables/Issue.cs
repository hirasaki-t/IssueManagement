using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record Issue
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>課題ステータスID</summary>
        public int IssueStatusID { get; set; }

        /// <summary>メッセージID</summary>
        public int MessageID { get; set; }

        /// <summary>タイトル</summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>更新日付</summary>
        public DateTime Update { get; set; }
    }
}
