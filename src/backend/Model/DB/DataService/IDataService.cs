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

        /// <summary>案件一覧の取得</summary>
        /// <returns>案件一覧</returns>
        Task<Project[]> GetProjectDatasAsync();

        /// <summary>案件の新規追加</summary>
        /// <param name="departmentsIDs">部署ID</param>
        /// <param name="projectStatusID">案件ステータスID</param>
        /// <param name="name">案件名</param>
        Task AddProjectDataAsync(int[] departmentsIDs, ProjectStatuses projectStatusID, string name);

        /// <summary>案件の更新</summary>
        /// <param name="id">ID</param>
        /// <param name="departmentsIDs">部署ID</param>
        /// <param name="projectStatuses">案件ステータス</param>
        /// <param name="name">案件名</param>
        Task UpdateProjectDataAsync(int id, int[] departmentsIDs, ProjectStatuses projectStatuses, string name);

        /// <summary>案件の削除</summary>
        /// <param name="id">ID</param>
        Task DeleteProjectDataAsync(int id);

        /// <summary>案件詳細の更新</summary>
        /// <param name="id">ID</param>
        /// <param name="detail">案件詳細</param>
        Task UpdateProjectDetailAsync(int id, string detail);

        /// <summary>課題一覧の取得</summary>
        /// <returns>課題一覧</returns>
        Task<Issue[]> GetIssueDatasAsync();

        /// <summary>課題の新規追加</summary>
        /// <param name="projectID">案件ID</param>
        /// <param name="issueStatuses">課題ステータス</param>
        /// <param name="name">課題名</param>
        Task AddIssueDataAsync(int projectID, IssueStatuses issueStatuses, string name);

        /// <summary>課題の更新</summary>
        /// <param name="id">ID</param>
        /// <param name="issueStatuses">課題ステータス</param>
        /// <param name="name">課題名</param>
        Task UpdateIssueDataAsync(int id, IssueStatuses issueStatuses, string name);

        /// <summary>課題の削除</summary>
        /// <param name="id">ID</param>
        Task DeleteIssueDataAsync(int id);
    }
}