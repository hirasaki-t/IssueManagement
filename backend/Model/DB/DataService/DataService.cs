using Microsoft.EntityFrameworkCore;
using Model.DB.DataContext;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Model.DB.DataService
{
    /// <summary>データ更新・操作用サービス</summary>
    public sealed partial class DataService : IDataService
    {
        /// <summary>データコンテキスト</summary>
        private readonly IDataContext dataContext;

        /// <summary>コンストラクタ</summary>
        /// <param name="dataContext">データコンテキスト</param>
        public DataService(IDataContext dataContext) => this.dataContext = dataContext;

        /// <summary>オブジェクトを破棄する</summary>
        public void Dispose() => dataContext.Dispose();

        /// <summary>オブジェクトを破棄する</summary>
        public ValueTask DisposeAsync() => dataContext.DisposeAsync();

        /// <inheritdoc/>
        public int SaveChanges() => dataContext.SaveChanges();

        /// <inheritdoc/>
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => dataContext.SaveChangesAsync(cancellationToken);

        /// <summary>オブジェクトをデタッチする</summary>
        /// <param name="targets">デタッチ対象のオブジェクト一覧</param>
        private void DetachEntities<T>(IEnumerable<T> targets) where T : class
        {
            foreach (var target in targets) dataContext.Entry(target).State = EntityState.Detached;
        }
    }
}