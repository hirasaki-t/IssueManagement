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
        public int ProjectStatusID { get; set; }

        /// <summary>課題ID</summary>
        [ForeignKey(nameof(Issue))]
        public int IssueID { get; set; }

        /// <summary>案件名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>案件ステータス</summary>
        public virtual ProjectStatus ProjectStatus { get; set; } = null!;

        /// <summary>課題</summary>
        public virtual Issue Issue { get; set; } = null!;
    }
}