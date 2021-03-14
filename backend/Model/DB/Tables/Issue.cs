using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.DB.Tables
{
    /// <summary>課題テーブル</summary>
    public record Issue
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>課題ステータスID</summary>
        [ForeignKey(nameof(IssueStatus))]
        public IssueStatuses IssueStatusID { get; set; }

        /// <summary>メッセージID</summary>
        public int MessageID { get; set; }

        /// <summary>タイトル</summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>更新日付</summary>
        public DateTime Update { get; set; }

        /// <summary>課題ステータス</summary>
        public virtual IssueStatus IssueStatus { get; set; } = null!;

        /// <summary>メッセージを識別するためのキー情報の一覧</summary>
        public virtual ICollection<Message> Messages { get; set; } = null!;

        /// <summary>案件を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Project> Projects { get; set; } = null!;
    }
}