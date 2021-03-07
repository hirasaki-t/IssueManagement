using Model.DB.DataService;

namespace Model.DataService
{
    /// <summary>データサービス生成インタフェース</summary>
    public interface IDataServiceCreator
    {
        /// <summary>データサービスを生成する</summary>
        /// <returns>生成したデータサービス</returns>
        IDataService Create();
    }
}