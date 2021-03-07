using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record Project
    {
        /// <summary>ID</summary>
        [Key]
        public int ID { get; set; }

        /// <summary>案件ステータスID</summary>
        public int ProjectStatusID { get; set; }

        /// <summary>課題ID</summary>
        public int IssueID { get; set; }

        /// <summary>タイトル</summary>
        public string Title { get; set; } = string.Empty;
    }
}
