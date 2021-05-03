using Model.Tables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.DB.Tables
{
    /// <summary>メッセージテーブル</summary>
    public record Message
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>課題ID</summary>
        [ForeignKey(nameof(Issue))]
        public int IssueID { get; set; }

        /// <summary>課題</summary>
        public virtual Issue Issue { get; set; } = null!;

        /// <summary>ユーザーID</summary>
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        /// <summary>ユーザー</summary>
        public virtual User User { get; set; } = null!;

        /// <summary>投稿メッセージ</summary>
        public string PostMessage { get; set; } = string.Empty;

        /// <summary>投稿日付</summary>
        public DateTime CreateDate { get; set; }

        /// <summary>更新日付</summary>
        public DateTime UpdateDate { get; set; }
    }
}