using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record ProjectStatus
    {
        /// <summary>ID</summary>
        [Key]
        public ProjectStatuses ID { get; set; }

        /// <summary>ステータス</summary>
        public string Status { get; set; } = string.Empty;
    }
}
