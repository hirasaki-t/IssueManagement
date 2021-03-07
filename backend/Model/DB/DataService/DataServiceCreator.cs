using Microsoft.Extensions.DependencyInjection;
using Model.DB.DataService;
using System;

namespace Model.DataService
{
    /// <summary>データサービス生成クラス</summary>
    public sealed class DataServiceCreator : IDataServiceCreator
    {
        /// <summary>サービスプロバイダ</summary>
        private readonly IServiceProvider serviceProvider;

        /// <summary>コンストラクタ</summary>
        /// <param name="serviceProvider">サービスプロバイダ</param>
        public DataServiceCreator(IServiceProvider serviceProvider) =>
            this.serviceProvider = serviceProvider;

        /// <inheritdoc/>
        public IDataService Create() => serviceProvider.GetRequiredService<IDataService>();
    }
}