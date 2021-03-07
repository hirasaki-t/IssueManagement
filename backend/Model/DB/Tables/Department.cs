using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record Department
    {
        /// <summary>ID</summary>
        [Key]
        public Departments ID { get; set; }

        /// <summary>部署名</summary>
        public string Name { get; set; } = string.Empty;
    }
}
