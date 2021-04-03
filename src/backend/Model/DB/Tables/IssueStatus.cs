using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    /// <summary>課題ステータステーブル</summary>
    public record IssueStatus
    {
        /// <summary>ID</summary>
        [Key]
        public IssueStatuses ID { get; set; }

        /// <summary>ステータス</summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>課題を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Issue> Issues { get; set; } = null!;
    }
}