using Microsoft.EntityFrameworkCore;
using Model.DB.Tables;
using Model.Tables;
using System.Threading.Tasks;
using X = Model;

namespace Model.DB.DataContext
{
    public abstract class DataContextBase : DbContext, IDataContext
    {
        // <summary>権限</summary>
        public DbSet<Authority> Authorities => Set<Authority>();

        // <summary>部署</summary>
        public DbSet<Department> Departments => Set<Department>();

        // <summary>課題</summary>
        public DbSet<Issue> Issues => Set<Issue>();

        // <summary>課題ステータス</summary>
        public DbSet<IssueStatus> IssueStatuses => Set<IssueStatus>();

        // <summary>メッセージ</summary>
        public DbSet<Message> Messages => Set<Message>();

        // <summary>案件</summary>
        public DbSet<Project> Projects => Set<Project>();

        // <summary>案件ステータス</summary>
        public DbSet<ProjectStatus> ProjectStatuses => Set<ProjectStatus>();

        // <summary>ユーザー</summary>
        public DbSet<User> Users => Set<User>();

        /// <inheritdoc/>
        public Task BeginTransactionAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task CommitAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>モデル生成時処理</summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SetPrimary(modelBuilder);
            SetUnique(modelBuilder);
            SetSeed(modelBuilder);
        }

        /// <summary>主キーの設定を行う</summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        private static void SetPrimary(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authority>().HasKey(x => x.ID);
            modelBuilder.Entity<Department>().HasKey(x => x.ID);
            modelBuilder.Entity<Issue>().HasKey(x => x.ID);
            modelBuilder.Entity<IssueStatus>().HasKey(x => x.ID);
            modelBuilder.Entity<Message>().HasKey(x => x.ID);
            modelBuilder.Entity<Project>().HasKey(x => x.ID);
            modelBuilder.Entity<ProjectStatus>().HasKey(x => x.ID);
            modelBuilder.Entity<User>().HasKey(x => x.ID);
        }

        /// <summary>一意列の設定を行う</summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        private static void SetUnique(ModelBuilder modelBuilder)
        {
        }

        /// <summary>シードデータを投入する</summary>
        /// <param name="modelBuilder">モデルビルダー</param>
        private static void SetSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authority>().HasData(
                new() { ID = X.Authorities.Owner, Name = "管理者" },
                new() { ID = X.Authorities.General, Name = "一般ユーザー" });

            modelBuilder.Entity<Department>().HasData(
                new() { ID = X.Departments.Development, Name = "開発" },
                new() { ID = X.Departments.Sales, Name = "営業" });

            modelBuilder.Entity<IssueStatus>().HasData(
                new() { ID = X.IssueStatuses.Unsolved, Status = "未解決" },
                new() { ID = X.IssueStatuses.Solved, Status = "解決" },
                new() { ID = X.IssueStatuses.Hold, Status = "保留" },
                new() { ID = X.IssueStatuses.Cancel, Status = "取下" });

            modelBuilder.Entity<ProjectStatus>().HasData(
                new() { ID = X.ProjectStatuses.NotStarted, Status = "未着手" },
                new() { ID = X.ProjectStatuses.RequestAnalysis, Status = "要求分析" },
                new() { ID = X.ProjectStatuses.RequestDefinition, Status = "要件定義" },
                new() { ID = X.ProjectStatuses.BasicDesign, Status = "基本設計" },
                new() { ID = X.ProjectStatuses.DetailDesign, Status = "詳細設計" },
                new() { ID = X.ProjectStatuses.Development, Status = "開発" },
                new() { ID = X.ProjectStatuses.InnerTest, Status = "内部テスト" },
                new() { ID = X.ProjectStatuses.UserTest, Status = "ユーザーテスト" },
                new() { ID = X.ProjectStatuses.ReleasePreparation, Status = "リリース準備" },
                new() { ID = X.ProjectStatuses.Release, Status = "リリース" });
        }
    }
}