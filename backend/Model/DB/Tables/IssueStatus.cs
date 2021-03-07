using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record IssueStatus
    {
        /// <summary>ID</summary>
        [Key]
        public IssueStatuses ID { get; set; }

        /// <summary>ステータス</summary>
        public string Status { get; set; } = string.Empty;
    }
}
