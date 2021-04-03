using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.DB.Tables
{
    /// <summary>案件テーブル</summary>
    public record Project
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>案件ステータスID</summary>
        [ForeignKey(nameof(ProjectStatus))]
        public ProjectStatuses ProjectStatusID { get; set; }

        /// <summary>案件ステータス</summary>
        public virtual ProjectStatus ProjectStatus { get; set; } = null!;

        /// <summary>部署ID</summary>
        [ForeignKey(nameof(Department))]
        public Departments DepartmentID { get; set; }

        /// <summary>部署</summary>
        public virtual Department Department { get; set; } = null!;

        /// <summary>案件名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>作成日</summary>
        public DateTime CreateDate { get; set; }

        /// <summary>課題を識別するためのキー情報の一覧</summary>
        public virtual ICollection<Issue> Issue { get; set; } = null!;
    }
}