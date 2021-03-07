using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DB.Tables
{
    public sealed record Authority
    {
        /// <summary>ID</summary>
        [Key]
        public Authorities ID { get; set; }

        /// <summary>権限名</summary>
        public string Name { get; set; } = string.Empty;
    }
}
