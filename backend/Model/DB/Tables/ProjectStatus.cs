using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    /// <summary>案件ステータステーブル</summary>
    public class ProjectStatus
    {
        /// <summary>ID</summary>
        [Key]
        public ProjectStatuses ID { get; set; }

        /// <summary>ステータス</summary>
        public string Status { get; set; } = string.Empty;

        /// <summary>案件を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Project> Projects { get; set; } = null!;
    }
}
