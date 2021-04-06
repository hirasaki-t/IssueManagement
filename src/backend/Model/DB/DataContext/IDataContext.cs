using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Model.DB.Tables;
using Model.Tables;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Model.DB.DataContext
{
    /// <summary>データコンテキスト</summary>
    public interface IDataContext : IDisposable, IAsyncDisposable
    {
        /// <summary>権限</summary>
        public DbSet<Authority> Authorities { get; }

        /// <summary>部署</summary>
        public DbSet<Department> Departments { get; }

        /// <summary>課題</summary>
        public DbSet<Issue> Issues { get; }

        /// <summary>課題ステータス</summary>
        public DbSet<IssueStatus> IssueStatuses { get; }

        /// <summary>メッセージ</summary>
        public DbSet<Message> Messages { get; }

        /// <summary>案件</summary>
        public DbSet<Project> Projects { get; }

        /// <summary>案件ステータス</summary>
        public DbSet<ProjectStatus> ProjectStatuses { get; }

        /// <summary>ユーザー</summary>
        public DbSet<User> Users { get; }

        /// <summary>サインイン</summary>
        public DbSet<SignIn> SignIns { get; }

        /// <summary>トランザクションを開始する</summary>
        public Task BeginTransactionAsync();

        /// <summary>トランザクションをコミットする</summary>
        public Task CommitAsync();

        /// <summary>変更の保存</summary>
        /// <returns>変更を及ぼした行数</returns>
        int SaveChanges();

        /// <summary>指定されたエンティティに関する情報を取得する</summary>
        /// <param name="entity">情報取得対象のエンティティ</param>
        /// <returns>エンティティに関する情報</returns>
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>変更の保存</summary>
        /// <param name="cancellationToken">処理キャンセル用トークン</param>
        /// <returns>変更を及ぼした行数</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}