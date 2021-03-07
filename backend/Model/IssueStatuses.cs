using System;
namespace Model
{
    public enum IssueStatuses
    {
        /// <summary>未解決</summary>
        Unsolved = 1,

        /// <summary>解決</summary>
        Solved,

        /// <summary>保留</summary>
        Hold,

        /// <summary>取消</summary>
        Cancel,
    }
}
