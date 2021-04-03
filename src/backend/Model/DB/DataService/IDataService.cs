using Model.DB.Tables;
using Model.Tables;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <summary>データサービス</summary>
    public interface IDataService : IDisposable, IAsyncDisposable
    {
        /// <summary>変更の保存をする</summary>
        /// <returns>影響を与えた行数</returns>
        int SaveChanges();

        /// <summary>非同期的に変更の保存をする</summary>
        /// <param name="cancellationToken">キャンセルトークン</param>
        /// <returns>影響を与えた行数</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        Task<User[]> GetUserAsync();

        /// <summary>権限一覧の取得</summary>
        /// <returns>権限一覧</returns>
        Task<Authority[]> GetAuthoritiesDatasAsync();

        /// <summary>部署一覧の取得</summary>
        /// <returns>部署一覧</returns>
        Task<Department[]> GetDepartmentDatasAsync();

        /// <summary>案件ステータス一覧の取得</summary>
        /// <returns>案件ステータス一覧</returns>
        Task<ProjectStatus[]> GetProjectStatusDatasAsync();

        /// <summary>課題ステータス一覧の取得</summary>
        /// <returns>課題ステータス一覧</returns>
        Task<IssueStatus[]> GetIssueStatusDatasAsync();

    }
}